namespace XPlaneHWITLConnect
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RawDataTextBox = new System.Windows.Forms.TextBox();
            this.UDPStartButton = new System.Windows.Forms.Button();
            this.FlightControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.G3LED8Segment = new PolyMonControls.LED8Segment();
            this.ElevatorLabel = new System.Windows.Forms.Label();
            this.ThrottleLabel = new System.Windows.Forms.Label();
            this.RudderLabel = new System.Windows.Forms.Label();
            this.AileronLabel = new System.Windows.Forms.Label();
            this.ElevatorTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ThrottleTrackBar = new System.Windows.Forms.TrackBar();
            this.RudderTrackBar = new System.Windows.Forms.TrackBar();
            this.AileronTrackBar = new System.Windows.Forms.TrackBar();
            this.RollLED8Segment = new PolyMonControls.LED8Segment();
            this.AttitudeTimer = new System.Windows.Forms.Timer(this.components);
            this.PitchLED8Segment = new PolyMonControls.LED8Segment();
            this.HeadingLED8Segment = new PolyMonControls.LED8Segment();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IASLED8Segment = new PolyMonControls.LED8Segment();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TGSLED8Segment = new PolyMonControls.LED8Segment();
            this.label7 = new System.Windows.Forms.Label();
            this.VVILED8Segment1 = new PolyMonControls.LED8Segment();
            this.label8 = new System.Windows.Forms.Label();
            this.G1LED8Segment = new PolyMonControls.LED8Segment();
            this.G2LED8Segment = new PolyMonControls.LED8Segment();
            this.RatesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AltitudeLED8Segment = new PolyMonControls.LED8Segment();
            this.label10 = new System.Windows.Forms.Label();
            this.RPMLED8Segment = new PolyMonControls.LED8Segment();
            this.GPSLabel = new System.Windows.Forms.Label();
            this.COMConnectButton = new System.Windows.Forms.Button();
            this.COMComboBox = new System.Windows.Forms.ComboBox();
            this.ArduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.CourseLED8Segment = new PolyMonControls.LED8Segment();
            this.FlightControlsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrottleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RudderTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AileronTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // RawDataTextBox
            // 
            this.RawDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RawDataTextBox.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawDataTextBox.Location = new System.Drawing.Point(16, 378);
            this.RawDataTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RawDataTextBox.Multiline = true;
            this.RawDataTextBox.Name = "RawDataTextBox";
            this.RawDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RawDataTextBox.Size = new System.Drawing.Size(600, 158);
            this.RawDataTextBox.TabIndex = 0;
            this.RawDataTextBox.WordWrap = false;
            // 
            // UDPStartButton
            // 
            this.UDPStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UDPStartButton.Location = new System.Drawing.Point(757, 15);
            this.UDPStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UDPStartButton.Name = "UDPStartButton";
            this.UDPStartButton.Size = new System.Drawing.Size(169, 28);
            this.UDPStartButton.TabIndex = 1;
            this.UDPStartButton.Text = "Start UDP Thread";
            this.UDPStartButton.UseVisualStyleBackColor = true;
            this.UDPStartButton.Click += new System.EventHandler(this.UDPStartButton_Click);
            // 
            // FlightControlsGroupBox
            // 
            this.FlightControlsGroupBox.Controls.Add(this.label6);
            this.FlightControlsGroupBox.Controls.Add(this.G3LED8Segment);
            this.FlightControlsGroupBox.Controls.Add(this.ElevatorLabel);
            this.FlightControlsGroupBox.Controls.Add(this.ThrottleLabel);
            this.FlightControlsGroupBox.Controls.Add(this.RudderLabel);
            this.FlightControlsGroupBox.Controls.Add(this.AileronLabel);
            this.FlightControlsGroupBox.Controls.Add(this.ElevatorTrackBar);
            this.FlightControlsGroupBox.Controls.Add(this.label2);
            this.FlightControlsGroupBox.Controls.Add(this.ThrottleTrackBar);
            this.FlightControlsGroupBox.Controls.Add(this.RudderTrackBar);
            this.FlightControlsGroupBox.Controls.Add(this.AileronTrackBar);
            this.FlightControlsGroupBox.Controls.Add(this.RollLED8Segment);
            this.FlightControlsGroupBox.Location = new System.Drawing.Point(16, 15);
            this.FlightControlsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlightControlsGroupBox.Name = "FlightControlsGroupBox";
            this.FlightControlsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlightControlsGroupBox.Size = new System.Drawing.Size(439, 314);
            this.FlightControlsGroupBox.TabIndex = 13;
            this.FlightControlsGroupBox.TabStop = false;
            this.FlightControlsGroupBox.Text = "Flight Controls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "G Side";
            // 
            // G3LED8Segment
            // 
            this.G3LED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.G3LED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.G3LED8Segment.LitColor = System.Drawing.Color.Black;
            this.G3LED8Segment.Location = new System.Drawing.Point(143, 256);
            this.G3LED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G3LED8Segment.Name = "G3LED8Segment";
            this.G3LED8Segment.NumDigits = 5;
            this.G3LED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.G3LED8Segment.Precision = 3;
            this.G3LED8Segment.Size = new System.Drawing.Size(155, 41);
            this.G3LED8Segment.TabIndex = 24;
            this.G3LED8Segment.Value = 0D;
            // 
            // ElevatorLabel
            // 
            this.ElevatorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElevatorLabel.Location = new System.Drawing.Point(279, 150);
            this.ElevatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElevatorLabel.Name = "ElevatorLabel";
            this.ElevatorLabel.Size = new System.Drawing.Size(83, 28);
            this.ElevatorLabel.TabIndex = 20;
            this.ElevatorLabel.Text = "0";
            this.ElevatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ThrottleLabel
            // 
            this.ThrottleLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThrottleLabel.Location = new System.Drawing.Point(76, 150);
            this.ThrottleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThrottleLabel.Name = "ThrottleLabel";
            this.ThrottleLabel.Size = new System.Drawing.Size(59, 28);
            this.ThrottleLabel.TabIndex = 19;
            this.ThrottleLabel.Text = "0";
            this.ThrottleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RudderLabel
            // 
            this.RudderLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RudderLabel.Location = new System.Drawing.Point(152, 224);
            this.RudderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RudderLabel.Name = "RudderLabel";
            this.RudderLabel.Size = new System.Drawing.Size(133, 28);
            this.RudderLabel.TabIndex = 18;
            this.RudderLabel.Text = "0";
            this.RudderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AileronLabel
            // 
            this.AileronLabel.BackColor = System.Drawing.Color.Transparent;
            this.AileronLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AileronLabel.Location = new System.Drawing.Point(152, 139);
            this.AileronLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AileronLabel.Name = "AileronLabel";
            this.AileronLabel.Size = new System.Drawing.Size(133, 28);
            this.AileronLabel.TabIndex = 17;
            this.AileronLabel.Text = "0";
            this.AileronLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElevatorTrackBar
            // 
            this.ElevatorTrackBar.LargeChange = 10;
            this.ElevatorTrackBar.Location = new System.Drawing.Point(369, 34);
            this.ElevatorTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ElevatorTrackBar.Maximum = 100;
            this.ElevatorTrackBar.Minimum = -100;
            this.ElevatorTrackBar.Name = "ElevatorTrackBar";
            this.ElevatorTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ElevatorTrackBar.Size = new System.Drawing.Size(56, 263);
            this.ElevatorTrackBar.TabIndex = 16;
            this.ElevatorTrackBar.TickFrequency = 10;
            this.ElevatorTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ElevatorTrackBar.ValueChanged += new System.EventHandler(this.ElevatorTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Roll";
            // 
            // ThrottleTrackBar
            // 
            this.ThrottleTrackBar.LargeChange = 10;
            this.ThrottleTrackBar.Location = new System.Drawing.Point(8, 34);
            this.ThrottleTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThrottleTrackBar.Maximum = 100;
            this.ThrottleTrackBar.Name = "ThrottleTrackBar";
            this.ThrottleTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ThrottleTrackBar.Size = new System.Drawing.Size(56, 263);
            this.ThrottleTrackBar.TabIndex = 15;
            this.ThrottleTrackBar.TickFrequency = 10;
            this.ThrottleTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ThrottleTrackBar.ValueChanged += new System.EventHandler(this.ThrottleTrackBar_ValueChanged);
            // 
            // RudderTrackBar
            // 
            this.RudderTrackBar.LargeChange = 10;
            this.RudderTrackBar.Location = new System.Drawing.Point(76, 183);
            this.RudderTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RudderTrackBar.Maximum = 100;
            this.RudderTrackBar.Minimum = -100;
            this.RudderTrackBar.Name = "RudderTrackBar";
            this.RudderTrackBar.Size = new System.Drawing.Size(285, 56);
            this.RudderTrackBar.TabIndex = 14;
            this.RudderTrackBar.TickFrequency = 10;
            this.RudderTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.RudderTrackBar.ValueChanged += new System.EventHandler(this.RudderTrackBar_ValueChanged);
            // 
            // AileronTrackBar
            // 
            this.AileronTrackBar.LargeChange = 10;
            this.AileronTrackBar.Location = new System.Drawing.Point(76, 92);
            this.AileronTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AileronTrackBar.Maximum = 100;
            this.AileronTrackBar.Minimum = -100;
            this.AileronTrackBar.Name = "AileronTrackBar";
            this.AileronTrackBar.Size = new System.Drawing.Size(285, 56);
            this.AileronTrackBar.TabIndex = 13;
            this.AileronTrackBar.TickFrequency = 10;
            this.AileronTrackBar.ValueChanged += new System.EventHandler(this.AileronTrackBar_ValueChanged);
            // 
            // RollLED8Segment
            // 
            this.RollLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.RollLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.RollLED8Segment.LitColor = System.Drawing.Color.Black;
            this.RollLED8Segment.Location = new System.Drawing.Point(143, 44);
            this.RollLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RollLED8Segment.Name = "RollLED8Segment";
            this.RollLED8Segment.NumDigits = 5;
            this.RollLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.RollLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.RollLED8Segment.TabIndex = 15;
            this.RollLED8Segment.Value = 0D;
            // 
            // AttitudeTimer
            // 
            this.AttitudeTimer.Enabled = true;
            this.AttitudeTimer.Interval = 40;
            this.AttitudeTimer.Tick += new System.EventHandler(this.AttitudeTimer_Tick);
            // 
            // PitchLED8Segment
            // 
            this.PitchLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.PitchLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.PitchLED8Segment.LitColor = System.Drawing.Color.Black;
            this.PitchLED8Segment.Location = new System.Drawing.Point(463, 59);
            this.PitchLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PitchLED8Segment.Name = "PitchLED8Segment";
            this.PitchLED8Segment.NumDigits = 5;
            this.PitchLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.PitchLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.PitchLED8Segment.TabIndex = 14;
            this.PitchLED8Segment.Value = 0D;
            // 
            // HeadingLED8Segment
            // 
            this.HeadingLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.HeadingLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.HeadingLED8Segment.LitColor = System.Drawing.Color.Black;
            this.HeadingLED8Segment.Location = new System.Drawing.Point(772, 400);
            this.HeadingLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeadingLED8Segment.Name = "HeadingLED8Segment";
            this.HeadingLED8Segment.NumDigits = 5;
            this.HeadingLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.HeadingLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.HeadingLED8Segment.TabIndex = 16;
            this.HeadingLED8Segment.Value = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Heading";
            // 
            // IASLED8Segment
            // 
            this.IASLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.IASLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.IASLED8Segment.LitColor = System.Drawing.Color.Black;
            this.IASLED8Segment.Location = new System.Drawing.Point(772, 448);
            this.IASLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IASLED8Segment.Name = "IASLED8Segment";
            this.IASLED8Segment.NumDigits = 5;
            this.IASLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.IASLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.IASLED8Segment.TabIndex = 20;
            this.IASLED8Segment.Value = 0D;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "IAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(732, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "TGS";
            // 
            // TGSLED8Segment
            // 
            this.TGSLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.TGSLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.TGSLED8Segment.LitColor = System.Drawing.Color.Black;
            this.TGSLED8Segment.Location = new System.Drawing.Point(772, 496);
            this.TGSLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TGSLED8Segment.Name = "TGSLED8Segment";
            this.TGSLED8Segment.NumDigits = 5;
            this.TGSLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.TGSLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.TGSLED8Segment.TabIndex = 22;
            this.TGSLED8Segment.Value = 0D;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "VVI";
            // 
            // VVILED8Segment1
            // 
            this.VVILED8Segment1.BackgroundImage = System.Drawing.Color.Empty;
            this.VVILED8Segment1.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.VVILED8Segment1.LitColor = System.Drawing.Color.Black;
            this.VVILED8Segment1.Location = new System.Drawing.Point(463, 142);
            this.VVILED8Segment1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VVILED8Segment1.Name = "VVILED8Segment1";
            this.VVILED8Segment1.NumDigits = 5;
            this.VVILED8Segment1.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.VVILED8Segment1.Size = new System.Drawing.Size(155, 41);
            this.VVILED8Segment1.TabIndex = 24;
            this.VVILED8Segment1.Value = 0D;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "G1, 2";
            // 
            // G1LED8Segment
            // 
            this.G1LED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.G1LED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.G1LED8Segment.LitColor = System.Drawing.Color.Black;
            this.G1LED8Segment.Location = new System.Drawing.Point(463, 226);
            this.G1LED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G1LED8Segment.Name = "G1LED8Segment";
            this.G1LED8Segment.NumDigits = 5;
            this.G1LED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.G1LED8Segment.Precision = 3;
            this.G1LED8Segment.Size = new System.Drawing.Size(155, 41);
            this.G1LED8Segment.TabIndex = 26;
            this.G1LED8Segment.Value = 0D;
            // 
            // G2LED8Segment
            // 
            this.G2LED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.G2LED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.G2LED8Segment.LitColor = System.Drawing.Color.Black;
            this.G2LED8Segment.Location = new System.Drawing.Point(463, 274);
            this.G2LED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G2LED8Segment.Name = "G2LED8Segment";
            this.G2LED8Segment.NumDigits = 5;
            this.G2LED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.G2LED8Segment.Precision = 3;
            this.G2LED8Segment.Size = new System.Drawing.Size(155, 41);
            this.G2LED8Segment.TabIndex = 28;
            this.G2LED8Segment.Value = 0D;
            // 
            // RatesLabel
            // 
            this.RatesLabel.AutoSize = true;
            this.RatesLabel.Location = new System.Drawing.Point(16, 332);
            this.RatesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatesLabel.Name = "RatesLabel";
            this.RatesLabel.Size = new System.Drawing.Size(53, 17);
            this.RatesLabel.TabIndex = 29;
            this.RatesLabel.Text = "Rates: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Altitude";
            // 
            // AltitudeLED8Segment
            // 
            this.AltitudeLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.AltitudeLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.AltitudeLED8Segment.LitColor = System.Drawing.Color.Black;
            this.AltitudeLED8Segment.Location = new System.Drawing.Point(625, 142);
            this.AltitudeLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AltitudeLED8Segment.Name = "AltitudeLED8Segment";
            this.AltitudeLED8Segment.NumDigits = 5;
            this.AltitudeLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.AltitudeLED8Segment.Precision = 1;
            this.AltitudeLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.AltitudeLED8Segment.TabIndex = 30;
            this.AltitudeLED8Segment.Value = 0D;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Motor RPM";
            // 
            // RPMLED8Segment
            // 
            this.RPMLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.RPMLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.RPMLED8Segment.LitColor = System.Drawing.Color.Black;
            this.RPMLED8Segment.Location = new System.Drawing.Point(629, 226);
            this.RPMLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RPMLED8Segment.Name = "RPMLED8Segment";
            this.RPMLED8Segment.NumDigits = 5;
            this.RPMLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.RPMLED8Segment.Precision = 0;
            this.RPMLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.RPMLED8Segment.TabIndex = 32;
            this.RPMLED8Segment.Value = 0D;
            // 
            // GPSLabel
            // 
            this.GPSLabel.AutoSize = true;
            this.GPSLabel.Location = new System.Drawing.Point(16, 348);
            this.GPSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GPSLabel.Name = "GPSLabel";
            this.GPSLabel.Size = new System.Drawing.Size(45, 17);
            this.GPSLabel.TabIndex = 34;
            this.GPSLabel.Text = "GPS: ";
            // 
            // COMConnectButton
            // 
            this.COMConnectButton.Location = new System.Drawing.Point(827, 49);
            this.COMConnectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMConnectButton.Name = "COMConnectButton";
            this.COMConnectButton.Size = new System.Drawing.Size(100, 28);
            this.COMConnectButton.TabIndex = 35;
            this.COMConnectButton.Text = "Connect";
            this.COMConnectButton.UseVisualStyleBackColor = true;
            this.COMConnectButton.Click += new System.EventHandler(this.COMConnectButton_Click);
            // 
            // COMComboBox
            // 
            this.COMComboBox.DisplayMember = "COM";
            this.COMComboBox.FormattingEnabled = true;
            this.COMComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10"});
            this.COMComboBox.Location = new System.Drawing.Point(736, 50);
            this.COMComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.COMComboBox.Name = "COMComboBox";
            this.COMComboBox.Size = new System.Drawing.Size(81, 24);
            this.COMComboBox.TabIndex = 36;
            this.COMComboBox.Text = "COM4";
            // 
            // ArduinoSerialPort
            // 
            this.ArduinoSerialPort.BaudRate = 57600;
            this.ArduinoSerialPort.ReadBufferSize = 256;
            this.ArduinoSerialPort.ReadTimeout = 200;
            this.ArduinoSerialPort.ReceivedBytesThreshold = 3;
            this.ArduinoSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ArduinoSerialPort_DataReceived);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 373);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Course";
            // 
            // CourseLED8Segment
            // 
            this.CourseLED8Segment.BackgroundImage = System.Drawing.Color.Empty;
            this.CourseLED8Segment.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.CourseLED8Segment.LitColor = System.Drawing.Color.Black;
            this.CourseLED8Segment.Location = new System.Drawing.Point(772, 348);
            this.CourseLED8Segment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseLED8Segment.Name = "CourseLED8Segment";
            this.CourseLED8Segment.NumDigits = 5;
            this.CourseLED8Segment.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.CourseLED8Segment.Size = new System.Drawing.Size(155, 41);
            this.CourseLED8Segment.TabIndex = 37;
            this.CourseLED8Segment.Value = 0D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 551);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CourseLED8Segment);
            this.Controls.Add(this.COMComboBox);
            this.Controls.Add(this.COMConnectButton);
            this.Controls.Add(this.GPSLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RPMLED8Segment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AltitudeLED8Segment);
            this.Controls.Add(this.RatesLabel);
            this.Controls.Add(this.G2LED8Segment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.G1LED8Segment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VVILED8Segment1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TGSLED8Segment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IASLED8Segment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeadingLED8Segment);
            this.Controls.Add(this.PitchLED8Segment);
            this.Controls.Add(this.FlightControlsGroupBox);
            this.Controls.Add(this.UDPStartButton);
            this.Controls.Add(this.RawDataTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Autopilot - X-Plane Hardware-in-the-Loop Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FlightControlsGroupBox.ResumeLayout(false);
            this.FlightControlsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElevatorTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrottleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RudderTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AileronTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RawDataTextBox;
        private System.Windows.Forms.Button UDPStartButton;
        private System.Windows.Forms.GroupBox FlightControlsGroupBox;
        private System.Windows.Forms.Label ElevatorLabel;
        private System.Windows.Forms.Label ThrottleLabel;
        private System.Windows.Forms.Label RudderLabel;
        private System.Windows.Forms.TrackBar ElevatorTrackBar;
        private System.Windows.Forms.TrackBar ThrottleTrackBar;
        private System.Windows.Forms.TrackBar RudderTrackBar;
        private System.Windows.Forms.TrackBar AileronTrackBar;
        private System.Windows.Forms.Label AileronLabel;
        private System.Windows.Forms.Timer AttitudeTimer;
        private PolyMonControls.LED8Segment PitchLED8Segment;
        private PolyMonControls.LED8Segment RollLED8Segment;
        private PolyMonControls.LED8Segment HeadingLED8Segment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PolyMonControls.LED8Segment IASLED8Segment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PolyMonControls.LED8Segment TGSLED8Segment;
        private System.Windows.Forms.Label label6;
        private PolyMonControls.LED8Segment G3LED8Segment;
        private System.Windows.Forms.Label label7;
        private PolyMonControls.LED8Segment VVILED8Segment1;
        private System.Windows.Forms.Label label8;
        private PolyMonControls.LED8Segment G1LED8Segment;
        private PolyMonControls.LED8Segment G2LED8Segment;
        private System.Windows.Forms.Label RatesLabel;
        private System.Windows.Forms.Label label9;
        private PolyMonControls.LED8Segment AltitudeLED8Segment;
        private System.Windows.Forms.Label label10;
        private PolyMonControls.LED8Segment RPMLED8Segment;
        private System.Windows.Forms.Label GPSLabel;
        private System.Windows.Forms.Button COMConnectButton;
        private System.Windows.Forms.ComboBox COMComboBox;
        private System.IO.Ports.SerialPort ArduinoSerialPort;
        private System.Windows.Forms.Label label11;
        private PolyMonControls.LED8Segment CourseLED8Segment;
    }
}

