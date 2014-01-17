using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using System.Threading;


namespace XPlaneHWITLConnect
{
    public partial class MainForm : Form
    {
        public class XPData
        {
            public int index;
            public float[] fdata;

            public XPData()
            {
                fdata = new float[8];
            }
        }

        Thread receiveThread;

        float Aileron, Rudder, Elevator, Throttle;
        float Roll, Pitch, Heading, Course, IAS, TGS;
        float VVI, Lat, Lon, Alt, RPM;
        float G1, G2, G3;
        float P, Q, R;

        string COMRx;

        int sendport = 49000;
        int receiveport = 49001;

        UdpClient XPUDPRClient, XPUDPSClient;
        IPEndPoint TxEP, RxEP;

        // Volatile is used as hint to the compiler that this data
        // member will be accessed by multiple threads.
        private volatile bool _shouldStop;

        #region Utilities
        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex;
        }

        public static byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            //TxEP = new IPEndPoint(IPAddress.Parse("192.168.1.146"), sendport);
            TxEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), sendport);
            RxEP = new IPEndPoint(IPAddress.Any, 0);

            XPUDPRClient = new UdpClient(receiveport);
            XPUDPSClient = new UdpClient();

            receiveThread = new Thread(ProcessUDPString);
        }

        delegate void SerialDataReceivedDelegate(object sender, SerialDataReceivedEventArgs e);

        delegate void SerialErrorReceivedDelegate(object sender, SerialErrorReceivedEventArgs e);

        #region X-Plane UDP stuff
        private void ProcessUDPString()
        {
            //need to have packs 3, 4, 17, 18 ,19, 20, 37 
            //3: kias, keas, ktas, ktgs
            //4: Mach, VVI, G1, G2, G3
            //17: Q, P, R
            //18: Pitch, Roll, Heading 
            //19: alpha, beta, hpath
            //20: lat, lon, alt
            //37: RPM

            while (!_shouldStop)
            {
                try
                {
                    byte[] data = XPUDPRClient.Receive(ref RxEP);
                    //UDPString = ByteArrayToString(data);

                    IAS = BitConverter.ToSingle(data, 9) * (Single)0.514444444; //IAS in metres/second
                    TGS = BitConverter.ToSingle(data, 9 + 12) * (Single)0.514444444; //IAS in metres/second

                    VVI = BitConverter.ToSingle(data, 53) * (Single)0.3048; //VVI in metres/minute
                    G1 = BitConverter.ToSingle(data, 53 + 8);
                    G2 = BitConverter.ToSingle(data, 53 + 12);
                    G3 = BitConverter.ToSingle(data, 53 + 16);

                    Q = BitConverter.ToSingle(data, 81);
                    P = BitConverter.ToSingle(data, 81 + 4);
                    R = BitConverter.ToSingle(data, 81 + 8);

                    Pitch = BitConverter.ToSingle(data, 117);
                    Roll = BitConverter.ToSingle(data, 117 + 4);
                    Heading = BitConverter.ToSingle(data, 117 + 8);

                    Course = BitConverter.ToSingle(data, 153 + 8);
                    
                    Lat = BitConverter.ToSingle(data, 189);
                    Lon = BitConverter.ToSingle(data, 189 + 4);
                    Alt = BitConverter.ToSingle(data, 189 + 8) * (Single)0.3048; //Altitude in metres/minute

                    RPM = BitConverter.ToSingle(data, 225);

                    this.Invoke((MethodInvoker)delegate
                    {
                        PitchLED8Segment.Value = Pitch;
                        RollLED8Segment.Value = Roll;
                        HeadingLED8Segment.Value = Heading;

                        CourseLED8Segment.Value = Course;

                        IASLED8Segment.Value = IAS;
                        TGSLED8Segment.Value = TGS;

                        VVILED8Segment1.Value = VVI;
                        G3LED8Segment.Value = G3;
                        G1LED8Segment.Value = G1;
                        G2LED8Segment.Value = G2;

                        AltitudeLED8Segment.Value = Alt;

                        RPMLED8Segment.Value = RPM;

                        RatesLabel.Text = string.Format("Rates: Q = {0,7:0.000}, P = {1,7:0.000}, R = {2,7:0.000}",
                            Q, P, R);
                        GPSLabel.Text = string.Format("GPS: Lat = {0,10:0.000000}, Lon = {1,10:0.000000}",
                            Lat, Lon);


                        //RawDataTextBox.AppendText(data.Length.ToString() + "\n");
                        //RawDataTextBox.AppendText(ByteArrayToString(data) + "\n");
                    });
                }
                catch
                {
                }
            }
        }

        private void XPUpdateControls()
        {
            XPData tempdata = new XPData();

            tempdata.index = 25;
            tempdata.fdata[0] = Throttle;
            XPlaneSend("DATA0", tempdata);

            tempdata.index = 10;
            tempdata.fdata[0] = Elevator;
            tempdata.fdata[1] = Aileron;
            tempdata.fdata[2] = Rudder;
            XPlaneSend("DATA0", tempdata);
        }

        private void XPlaneSend(string cmd, XPData data)
        {
            byte[] ByteArray = new byte[41];
            byte j = 9;

            StrToByteArray(cmd).CopyTo(ByteArray, 0); //add header
            BitConverter.GetBytes(data.index).CopyTo(ByteArray, 5); //add index number

            foreach (float k in data.fdata) //add data
            {
                BitConverter.GetBytes(k).CopyTo(ByteArray, j);
                j += 4;
            }

            XPUDPSClient.Send(ByteArray, ByteArray.Length, TxEP);
        }

        private void UDPStartButton_Click(object sender, EventArgs e)
        {
            if (receiveThread.IsAlive)
            {
                _shouldStop = true;
                UDPStartButton.Text = "Start UDP Thread";
                AttitudeTimer.Enabled = false;
            }
            else
            {
                _shouldStop = false;
                receiveThread = new Thread(ProcessUDPString);
                receiveThread.IsBackground = true;
                receiveThread.Start();
                UDPStartButton.Text = "Stop UDP Thread";
                AttitudeTimer.Enabled = true;
            }
        }
        #endregion

        #region Form Controls
        private void AileronTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Aileron = (float)AileronTrackBar.Value / 100;
            AileronLabel.Text = Aileron.ToString();
            XPUpdateControls();
        }

        private void ElevatorTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Elevator = (float)ElevatorTrackBar.Value / 100;
            ElevatorLabel.Text = Elevator.ToString();
            XPUpdateControls();
        }

        private void RudderTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Rudder = (float)RudderTrackBar.Value / 100;
            RudderLabel.Text = Rudder.ToString();
            XPUpdateControls();
        }

        private void ThrottleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Throttle = (float)ThrottleTrackBar.Value / 100;
            ThrottleLabel.Text = Throttle.ToString();
            XPUpdateControls();
        }
        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _shouldStop = true;
            XPUDPRClient.Close();
            XPUDPSClient.Close();

            if (ArduinoSerialPort.IsOpen)
            {
                ArduinoSerialPort.Close();
            }
        }

        private void AttitudeTimer_Tick(object sender, EventArgs e)
        {
            if (ArduinoSerialPort.IsOpen)
            {
                ArduinoSerialPort.WriteLine(string.Format("{0:0.00},{1:0.00},{2:0.00},{3:0.00},{4:0.00},{5:0.00},{6:0.000000},{7:0.000000}\r",
                    Pitch, Roll, VVI, IAS, Alt, Course, Lat, Lon));
            }
            //RawDataTextBox.AppendText(" [" + Pitch.ToString() + "] [" + Roll.ToString() + "] [" + Heading.ToString() + "]");
            //RawDataTextBox.AppendText("\n");
        }

        private void COMConnectButton_Click(object sender, EventArgs e)
        {
            COMConnectButton.Enabled = false;

            if (ArduinoSerialPort.IsOpen)
            {
                ArduinoSerialPort.Close();

                COMConnectButton.Text = "Connect";
            }
            else
            {
                ArduinoSerialPort.PortName = COMComboBox.Text;
                try
                {
                    ArduinoSerialPort.Open();
                }
                catch
                {
                    MessageBox.Show("Could not open " + COMComboBox.Text);
                }

                if (ArduinoSerialPort.IsOpen)
                {
                    COMConnectButton.Text = "Disconnect";
                }
            }

            COMConnectButton.Enabled = true;
        }

        private void ArduinoSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int BufferLength = ArduinoSerialPort.BytesToRead;
            //StringBuilder tempS = new StringBuilder();

            while (BufferLength > 0 && ArduinoSerialPort.IsOpen)
            {
                try
                {
                    //tempS.Append(MAASerialPort.ReadLine());
                    COMRx = ArduinoSerialPort.ReadLine();
                    //tempS.Length = 0;


                    // This is the fast way - run in the same thread
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new SerialDataReceivedDelegate(ProcessCOMRx), sender, e);
                    }
                    else
                    {
                        ProcessCOMRx(sender, e);
                    }

                    // This is the slow way - run in a new thread
                    //this.BeginInvoke(new EventHandler(ProcessCOMRx));

                    if (ArduinoSerialPort.IsOpen)
                        BufferLength = ArduinoSerialPort.BytesToRead;
                }
                catch
                {
                    this.BeginInvoke(new EventHandler(ReadLineError));
                }
            }
        }

        private void ReadLineError(object sender, EventArgs e)
        {
            RawDataTextBox.AppendText("Read Line Error\n");
        }

        private void ProcessCOMRx(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(COMRx))
            {
                try
                {
                    string[] parsed = COMRx.Split(';');

                    ElevatorTrackBar.Value = (int)Math.Round(double.Parse(parsed[0]));
                    AileronTrackBar.Value = (int)Math.Round(double.Parse(parsed[1]));
                    RudderTrackBar.Value = (int)Math.Round(double.Parse(parsed[2]));
                    ThrottleTrackBar.Value = (int)Math.Round(double.Parse(parsed[3]));

                    RawDataTextBox.AppendText(COMRx + '\n');
                    COMRx = "";
                }
                catch
                {
                    RawDataTextBox.AppendText("Parse Error: " + COMRx + '\n');
                }
            }
        }
    }
}
