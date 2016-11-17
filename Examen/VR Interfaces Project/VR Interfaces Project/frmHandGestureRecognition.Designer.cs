namespace VR_Interfaces_Project
{
    partial class frmHandGestureRecognition
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
            this.tcPages = new System.Windows.Forms.TabControl();
            this.tpProgram = new System.Windows.Forms.TabPage();
            this.gbThresholds = new System.Windows.Forms.GroupBox();
            this.tbMaxThresh = new System.Windows.Forms.TrackBar();
            this.tbMinThresh = new System.Windows.Forms.TrackBar();
            this.lblMaxThreshold = new System.Windows.Forms.Label();
            this.lblMinThreshold = new System.Windows.Forms.Label();
            this.bttnStop = new System.Windows.Forms.Button();
            this.bttnStart = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.ibOutput = new Emgu.CV.UI.ImageBox();
            this.ibPreview = new Emgu.CV.UI.ImageBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.lblPorts = new System.Windows.Forms.Label();
            this.cbBaudrates = new System.Windows.Forms.ComboBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.nbErode = new System.Windows.Forms.NumericUpDown();
            this.nbDilate = new System.Windows.Forms.NumericUpDown();
            this.ckbxShowLabels = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.ckbxDilate = new System.Windows.Forms.CheckBox();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.lblThickness = new System.Windows.Forms.Label();
            this.ckbxErode = new System.Windows.Forms.CheckBox();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.rtbOutputInfo = new System.Windows.Forms.RichTextBox();
            this.gbCameraSettings = new System.Windows.Forms.GroupBox();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbPCWebcam = new System.Windows.Forms.RadioButton();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.rbCanny = new System.Windows.Forms.RadioButton();
            this.rbColorRange = new System.Windows.Forms.RadioButton();
            this.rbHSV = new System.Windows.Forms.RadioButton();
            this.rbBGR = new System.Windows.Forms.RadioButton();
            this.tpColorSettings = new System.Windows.Forms.TabPage();
            this.gbFilterSettings = new System.Windows.Forms.GroupBox();
            this.rbHSVSettings = new System.Windows.Forms.RadioButton();
            this.rbColorRangeSettings = new System.Windows.Forms.RadioButton();
            this.lblColorPreview = new System.Windows.Forms.Label();
            this.ibPreviewSettings = new Emgu.CV.UI.ImageBox();
            this.gbYCbCrMax = new System.Windows.Forms.GroupBox();
            this.tbCbMax = new System.Windows.Forms.TrackBar();
            this.tbYMax = new System.Windows.Forms.TrackBar();
            this.tbCrMax = new System.Windows.Forms.TrackBar();
            this.lblCrMax = new System.Windows.Forms.Label();
            this.lblYMax = new System.Windows.Forms.Label();
            this.lblCbMax = new System.Windows.Forms.Label();
            this.gbYCbCrMin = new System.Windows.Forms.GroupBox();
            this.tbCbMin = new System.Windows.Forms.TrackBar();
            this.tbYMin = new System.Windows.Forms.TrackBar();
            this.tbCrMin = new System.Windows.Forms.TrackBar();
            this.lblCrMin = new System.Windows.Forms.Label();
            this.lblYMin = new System.Windows.Forms.Label();
            this.lblCbMin = new System.Windows.Forms.Label();
            this.gbMaxColors = new System.Windows.Forms.GroupBox();
            this.satMaxBar = new System.Windows.Forms.TrackBar();
            this.hueMaxBar = new System.Windows.Forms.TrackBar();
            this.valMaxBar = new System.Windows.Forms.TrackBar();
            this.lblValMax = new System.Windows.Forms.Label();
            this.lblHueMax = new System.Windows.Forms.Label();
            this.lblSatMax = new System.Windows.Forms.Label();
            this.gbMinColors = new System.Windows.Forms.GroupBox();
            this.satMinBar = new System.Windows.Forms.TrackBar();
            this.hueMinBar = new System.Windows.Forms.TrackBar();
            this.valMinBar = new System.Windows.Forms.TrackBar();
            this.lblValMin = new System.Windows.Forms.Label();
            this.lblHueMin = new System.Windows.Forms.Label();
            this.lblSatMin = new System.Windows.Forms.Label();
            this.tcPages.SuspendLayout();
            this.tpProgram.SuspendLayout();
            this.gbThresholds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreview)).BeginInit();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            this.gbInformation.SuspendLayout();
            this.gbCameraSettings.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.tpColorSettings.SuspendLayout();
            this.gbFilterSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreviewSettings)).BeginInit();
            this.gbYCbCrMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrMax)).BeginInit();
            this.gbYCbCrMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCbMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrMin)).BeginInit();
            this.gbMaxColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxBar)).BeginInit();
            this.gbMinColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMinBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPages
            // 
            this.tcPages.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPages.Controls.Add(this.tpProgram);
            this.tcPages.Controls.Add(this.tpColorSettings);
            this.tcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPages.Location = new System.Drawing.Point(0, 0);
            this.tcPages.Name = "tcPages";
            this.tcPages.SelectedIndex = 0;
            this.tcPages.Size = new System.Drawing.Size(1328, 667);
            this.tcPages.TabIndex = 9;
            // 
            // tpProgram
            // 
            this.tpProgram.Controls.Add(this.gbThresholds);
            this.tpProgram.Controls.Add(this.bttnStop);
            this.tpProgram.Controls.Add(this.bttnStart);
            this.tpProgram.Controls.Add(this.bttnClear);
            this.tpProgram.Controls.Add(this.ibOutput);
            this.tpProgram.Controls.Add(this.ibPreview);
            this.tpProgram.Controls.Add(this.lblOutput);
            this.tpProgram.Controls.Add(this.lblPreview);
            this.tpProgram.Controls.Add(this.lblBaudrate);
            this.tpProgram.Controls.Add(this.lblPorts);
            this.tpProgram.Controls.Add(this.cbBaudrates);
            this.tpProgram.Controls.Add(this.cbPorts);
            this.tpProgram.Controls.Add(this.gbParameters);
            this.tpProgram.Controls.Add(this.gbInformation);
            this.tpProgram.Controls.Add(this.gbCameraSettings);
            this.tpProgram.Controls.Add(this.gbFilters);
            this.tpProgram.Location = new System.Drawing.Point(4, 25);
            this.tpProgram.Name = "tpProgram";
            this.tpProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tpProgram.Size = new System.Drawing.Size(1320, 638);
            this.tpProgram.TabIndex = 0;
            this.tpProgram.Text = "Program";
            this.tpProgram.UseVisualStyleBackColor = true;
            // 
            // gbThresholds
            // 
            this.gbThresholds.Controls.Add(this.tbMaxThresh);
            this.gbThresholds.Controls.Add(this.tbMinThresh);
            this.gbThresholds.Controls.Add(this.lblMaxThreshold);
            this.gbThresholds.Controls.Add(this.lblMinThreshold);
            this.gbThresholds.Location = new System.Drawing.Point(11, 476);
            this.gbThresholds.Name = "gbThresholds";
            this.gbThresholds.Size = new System.Drawing.Size(516, 153);
            this.gbThresholds.TabIndex = 24;
            this.gbThresholds.TabStop = false;
            this.gbThresholds.Text = "Thresholds";
            // 
            // tbMaxThresh
            // 
            this.tbMaxThresh.Location = new System.Drawing.Point(79, 87);
            this.tbMaxThresh.Maximum = 255;
            this.tbMaxThresh.Minimum = 1;
            this.tbMaxThresh.Name = "tbMaxThresh";
            this.tbMaxThresh.Size = new System.Drawing.Size(428, 45);
            this.tbMaxThresh.TabIndex = 4;
            this.tbMaxThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMaxThresh.Value = 120;
            this.tbMaxThresh.Scroll += new System.EventHandler(this.tbMaxThresh_Scroll);
            // 
            // tbMinThresh
            // 
            this.tbMinThresh.Location = new System.Drawing.Point(79, 36);
            this.tbMinThresh.Maximum = 255;
            this.tbMinThresh.Minimum = 1;
            this.tbMinThresh.Name = "tbMinThresh";
            this.tbMinThresh.Size = new System.Drawing.Size(428, 45);
            this.tbMinThresh.TabIndex = 5;
            this.tbMinThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMinThresh.Value = 180;
            this.tbMinThresh.Scroll += new System.EventHandler(this.tbMaxThresh_Scroll);
            // 
            // lblMaxThreshold
            // 
            this.lblMaxThreshold.AutoSize = true;
            this.lblMaxThreshold.Location = new System.Drawing.Point(17, 87);
            this.lblMaxThreshold.Name = "lblMaxThreshold";
            this.lblMaxThreshold.Size = new System.Drawing.Size(59, 26);
            this.lblMaxThreshold.TabIndex = 2;
            this.lblMaxThreshold.Text = "Max value:\r\n120";
            // 
            // lblMinThreshold
            // 
            this.lblMinThreshold.AutoSize = true;
            this.lblMinThreshold.Location = new System.Drawing.Point(17, 37);
            this.lblMinThreshold.Name = "lblMinThreshold";
            this.lblMinThreshold.Size = new System.Drawing.Size(56, 26);
            this.lblMinThreshold.TabIndex = 3;
            this.lblMinThreshold.Text = "Min value:\r\n180";
            // 
            // bttnStop
            // 
            this.bttnStop.Location = new System.Drawing.Point(1239, 607);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(75, 23);
            this.bttnStop.TabIndex = 23;
            this.bttnStop.Text = "Stop";
            this.bttnStop.UseVisualStyleBackColor = true;
            this.bttnStop.Click += new System.EventHandler(this.bttnStop_Click);
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(1158, 607);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(75, 23);
            this.bttnStart.TabIndex = 22;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(926, 607);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 21;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // ibOutput
            // 
            this.ibOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOutput.Location = new System.Drawing.Point(926, 71);
            this.ibOutput.Name = "ibOutput";
            this.ibOutput.Size = new System.Drawing.Size(387, 530);
            this.ibOutput.TabIndex = 19;
            this.ibOutput.TabStop = false;
            // 
            // ibPreview
            // 
            this.ibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibPreview.Location = new System.Drawing.Point(533, 71);
            this.ibPreview.Name = "ibPreview";
            this.ibPreview.Size = new System.Drawing.Size(387, 530);
            this.ibPreview.TabIndex = 18;
            this.ibPreview.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(923, 41);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 20;
            this.lblOutput.Text = "Output:";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(530, 41);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(48, 13);
            this.lblPreview.TabIndex = 17;
            this.lblPreview.Text = "Preview:";
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(246, 15);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(53, 13);
            this.lblBaudrate.TabIndex = 16;
            this.lblBaudrate.Text = "Baudrate:";
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(8, 15);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(35, 13);
            this.lblPorts.TabIndex = 15;
            this.lblPorts.Text = "Poort:";
            // 
            // cbBaudrates
            // 
            this.cbBaudrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudrates.FormattingEnabled = true;
            this.cbBaudrates.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400"});
            this.cbBaudrates.Location = new System.Drawing.Point(305, 12);
            this.cbBaudrates.Name = "cbBaudrates";
            this.cbBaudrates.Size = new System.Drawing.Size(121, 21);
            this.cbBaudrates.TabIndex = 14;
            // 
            // cbPorts
            // 
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(49, 12);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 13;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.nbErode);
            this.gbParameters.Controls.Add(this.nbDilate);
            this.gbParameters.Controls.Add(this.ckbxShowLabels);
            this.gbParameters.Controls.Add(this.lblSize);
            this.gbParameters.Controls.Add(this.numSize);
            this.gbParameters.Controls.Add(this.ckbxDilate);
            this.gbParameters.Controls.Add(this.numThickness);
            this.gbParameters.Controls.Add(this.lblThickness);
            this.gbParameters.Controls.Add(this.ckbxErode);
            this.gbParameters.Controls.Add(this.cbColors);
            this.gbParameters.Controls.Add(this.lblColor);
            this.gbParameters.Controls.Add(this.cbFonts);
            this.gbParameters.Controls.Add(this.lblFont);
            this.gbParameters.Location = new System.Drawing.Point(11, 155);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(250, 315);
            this.gbParameters.TabIndex = 11;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // nbErode
            // 
            this.nbErode.Enabled = false;
            this.nbErode.Location = new System.Drawing.Point(79, 257);
            this.nbErode.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nbErode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbErode.Name = "nbErode";
            this.nbErode.Size = new System.Drawing.Size(56, 20);
            this.nbErode.TabIndex = 17;
            this.nbErode.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nbDilate
            // 
            this.nbDilate.Enabled = false;
            this.nbDilate.Location = new System.Drawing.Point(79, 280);
            this.nbDilate.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nbDilate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbDilate.Name = "nbDilate";
            this.nbDilate.Size = new System.Drawing.Size(56, 20);
            this.nbDilate.TabIndex = 18;
            this.nbDilate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ckbxShowLabels
            // 
            this.ckbxShowLabels.AutoSize = true;
            this.ckbxShowLabels.Checked = true;
            this.ckbxShowLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxShowLabels.Location = new System.Drawing.Point(10, 178);
            this.ckbxShowLabels.Name = "ckbxShowLabels";
            this.ckbxShowLabels.Size = new System.Drawing.Size(87, 17);
            this.ckbxShowLabels.TabIndex = 14;
            this.ckbxShowLabels.Text = "Show Labels";
            this.ckbxShowLabels.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(7, 144);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 13;
            this.lblSize.Text = "Size:";
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(48, 142);
            this.numSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(40, 20);
            this.numSize.TabIndex = 11;
            this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ckbxDilate
            // 
            this.ckbxDilate.AutoSize = true;
            this.ckbxDilate.Enabled = false;
            this.ckbxDilate.Location = new System.Drawing.Point(9, 283);
            this.ckbxDilate.Name = "ckbxDilate";
            this.ckbxDilate.Size = new System.Drawing.Size(53, 17);
            this.ckbxDilate.TabIndex = 15;
            this.ckbxDilate.Text = "Dilate";
            this.ckbxDilate.UseVisualStyleBackColor = true;
            this.ckbxDilate.CheckedChanged += new System.EventHandler(this.dilateChkBx_CheckedChanged);
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(190, 142);
            this.numThickness.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThickness.Name = "numThickness";
            this.numThickness.Size = new System.Drawing.Size(40, 20);
            this.numThickness.TabIndex = 12;
            this.numThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(125, 144);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(59, 13);
            this.lblThickness.TabIndex = 10;
            this.lblThickness.Text = "Thickness:";
            // 
            // ckbxErode
            // 
            this.ckbxErode.AutoSize = true;
            this.ckbxErode.Enabled = false;
            this.ckbxErode.Location = new System.Drawing.Point(9, 257);
            this.ckbxErode.Name = "ckbxErode";
            this.ckbxErode.Size = new System.Drawing.Size(54, 17);
            this.ckbxErode.TabIndex = 16;
            this.ckbxErode.Text = "Erode";
            this.ckbxErode.UseVisualStyleBackColor = true;
            this.ckbxErode.CheckedChanged += new System.EventHandler(this.erodeChkBx_CheckedChanged);
            // 
            // cbColors
            // 
            this.cbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(48, 68);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(182, 21);
            this.cbColors.TabIndex = 8;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 71);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color:";
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(48, 31);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(182, 21);
            this.cbFonts.TabIndex = 9;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(7, 34);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 13);
            this.lblFont.TabIndex = 7;
            this.lblFont.Text = "Font:";
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.rtbOutputInfo);
            this.gbInformation.Location = new System.Drawing.Point(267, 155);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(260, 315);
            this.gbInformation.TabIndex = 10;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Output information";
            // 
            // rtbOutputInfo
            // 
            this.rtbOutputInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbOutputInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutputInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutputInfo.Location = new System.Drawing.Point(3, 16);
            this.rtbOutputInfo.Name = "rtbOutputInfo";
            this.rtbOutputInfo.Size = new System.Drawing.Size(254, 296);
            this.rtbOutputInfo.TabIndex = 0;
            this.rtbOutputInfo.Text = "";
            // 
            // gbCameraSettings
            // 
            this.gbCameraSettings.Controls.Add(this.rbAndroid);
            this.gbCameraSettings.Controls.Add(this.rbPCWebcam);
            this.gbCameraSettings.Location = new System.Drawing.Point(267, 65);
            this.gbCameraSettings.Name = "gbCameraSettings";
            this.gbCameraSettings.Size = new System.Drawing.Size(260, 84);
            this.gbCameraSettings.TabIndex = 12;
            this.gbCameraSettings.TabStop = false;
            this.gbCameraSettings.Text = "Camera Settings";
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(6, 51);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(61, 17);
            this.rbAndroid.TabIndex = 1;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            this.rbAndroid.CheckedChanged += new System.EventHandler(this.rbAndroid_CheckedChanged);
            // 
            // rbPCWebcam
            // 
            this.rbPCWebcam.AutoSize = true;
            this.rbPCWebcam.Checked = true;
            this.rbPCWebcam.Location = new System.Drawing.Point(6, 23);
            this.rbPCWebcam.Name = "rbPCWebcam";
            this.rbPCWebcam.Size = new System.Drawing.Size(85, 17);
            this.rbPCWebcam.TabIndex = 2;
            this.rbPCWebcam.TabStop = true;
            this.rbPCWebcam.Text = "PC Webcam";
            this.rbPCWebcam.UseVisualStyleBackColor = true;
            this.rbPCWebcam.CheckedChanged += new System.EventHandler(this.rbAndroid_CheckedChanged);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.rbCanny);
            this.gbFilters.Controls.Add(this.rbColorRange);
            this.gbFilters.Controls.Add(this.rbHSV);
            this.gbFilters.Controls.Add(this.rbBGR);
            this.gbFilters.Location = new System.Drawing.Point(11, 65);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(250, 84);
            this.gbFilters.TabIndex = 9;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // rbCanny
            // 
            this.rbCanny.AutoSize = true;
            this.rbCanny.Location = new System.Drawing.Point(112, 51);
            this.rbCanny.Name = "rbCanny";
            this.rbCanny.Size = new System.Drawing.Size(55, 17);
            this.rbCanny.TabIndex = 1;
            this.rbCanny.TabStop = true;
            this.rbCanny.Text = "Canny";
            this.rbCanny.UseVisualStyleBackColor = true;
            // 
            // rbColorRange
            // 
            this.rbColorRange.AutoSize = true;
            this.rbColorRange.Location = new System.Drawing.Point(10, 51);
            this.rbColorRange.Name = "rbColorRange";
            this.rbColorRange.Size = new System.Drawing.Size(84, 17);
            this.rbColorRange.TabIndex = 0;
            this.rbColorRange.Text = "Color Range";
            this.rbColorRange.UseVisualStyleBackColor = true;
            this.rbColorRange.CheckedChanged += new System.EventHandler(this.rbHSV_CheckedChanged);
            // 
            // rbHSV
            // 
            this.rbHSV.AutoSize = true;
            this.rbHSV.Location = new System.Drawing.Point(79, 23);
            this.rbHSV.Name = "rbHSV";
            this.rbHSV.Size = new System.Drawing.Size(44, 17);
            this.rbHSV.TabIndex = 0;
            this.rbHSV.Text = "Hsv";
            this.rbHSV.UseVisualStyleBackColor = true;
            this.rbHSV.CheckedChanged += new System.EventHandler(this.rbHSV_CheckedChanged);
            // 
            // rbBGR
            // 
            this.rbBGR.AutoSize = true;
            this.rbBGR.Checked = true;
            this.rbBGR.Location = new System.Drawing.Point(10, 23);
            this.rbBGR.Name = "rbBGR";
            this.rbBGR.Size = new System.Drawing.Size(41, 17);
            this.rbBGR.TabIndex = 0;
            this.rbBGR.TabStop = true;
            this.rbBGR.Text = "Bgr";
            this.rbBGR.UseVisualStyleBackColor = true;
            this.rbBGR.CheckedChanged += new System.EventHandler(this.rbHSV_CheckedChanged);
            // 
            // tpColorSettings
            // 
            this.tpColorSettings.Controls.Add(this.gbFilterSettings);
            this.tpColorSettings.Controls.Add(this.lblColorPreview);
            this.tpColorSettings.Controls.Add(this.ibPreviewSettings);
            this.tpColorSettings.Controls.Add(this.gbYCbCrMax);
            this.tpColorSettings.Controls.Add(this.gbYCbCrMin);
            this.tpColorSettings.Controls.Add(this.gbMaxColors);
            this.tpColorSettings.Controls.Add(this.gbMinColors);
            this.tpColorSettings.Location = new System.Drawing.Point(4, 25);
            this.tpColorSettings.Name = "tpColorSettings";
            this.tpColorSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpColorSettings.Size = new System.Drawing.Size(1320, 638);
            this.tpColorSettings.TabIndex = 1;
            this.tpColorSettings.Text = "Color Settings";
            this.tpColorSettings.UseVisualStyleBackColor = true;
            // 
            // gbFilterSettings
            // 
            this.gbFilterSettings.Controls.Add(this.rbHSVSettings);
            this.gbFilterSettings.Controls.Add(this.rbColorRangeSettings);
            this.gbFilterSettings.Location = new System.Drawing.Point(18, 6);
            this.gbFilterSettings.Name = "gbFilterSettings";
            this.gbFilterSettings.Size = new System.Drawing.Size(429, 270);
            this.gbFilterSettings.TabIndex = 31;
            this.gbFilterSettings.TabStop = false;
            this.gbFilterSettings.Text = "Filters";
            // 
            // rbHSVSettings
            // 
            this.rbHSVSettings.AutoSize = true;
            this.rbHSVSettings.Checked = true;
            this.rbHSVSettings.Location = new System.Drawing.Point(19, 41);
            this.rbHSVSettings.Name = "rbHSVSettings";
            this.rbHSVSettings.Size = new System.Drawing.Size(44, 17);
            this.rbHSVSettings.TabIndex = 30;
            this.rbHSVSettings.TabStop = true;
            this.rbHSVSettings.Text = "Hsv";
            this.rbHSVSettings.UseVisualStyleBackColor = true;
            // 
            // rbColorRangeSettings
            // 
            this.rbColorRangeSettings.AutoSize = true;
            this.rbColorRangeSettings.Location = new System.Drawing.Point(19, 78);
            this.rbColorRangeSettings.Name = "rbColorRangeSettings";
            this.rbColorRangeSettings.Size = new System.Drawing.Size(84, 17);
            this.rbColorRangeSettings.TabIndex = 29;
            this.rbColorRangeSettings.Text = "Color Range";
            this.rbColorRangeSettings.UseVisualStyleBackColor = true;
            // 
            // lblColorPreview
            // 
            this.lblColorPreview.AutoSize = true;
            this.lblColorPreview.Location = new System.Drawing.Point(611, 6);
            this.lblColorPreview.Name = "lblColorPreview";
            this.lblColorPreview.Size = new System.Drawing.Size(48, 13);
            this.lblColorPreview.TabIndex = 28;
            this.lblColorPreview.Text = "Preview:";
            // 
            // ibPreviewSettings
            // 
            this.ibPreviewSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibPreviewSettings.Location = new System.Drawing.Point(669, 6);
            this.ibPreviewSettings.Name = "ibPreviewSettings";
            this.ibPreviewSettings.Size = new System.Drawing.Size(628, 270);
            this.ibPreviewSettings.TabIndex = 2;
            this.ibPreviewSettings.TabStop = false;
            // 
            // gbYCbCrMax
            // 
            this.gbYCbCrMax.BackColor = System.Drawing.Color.Transparent;
            this.gbYCbCrMax.Controls.Add(this.tbCbMax);
            this.gbYCbCrMax.Controls.Add(this.tbYMax);
            this.gbYCbCrMax.Controls.Add(this.tbCrMax);
            this.gbYCbCrMax.Controls.Add(this.lblCrMax);
            this.gbYCbCrMax.Controls.Add(this.lblYMax);
            this.gbYCbCrMax.Controls.Add(this.lblCbMax);
            this.gbYCbCrMax.Location = new System.Drawing.Point(669, 459);
            this.gbYCbCrMax.Name = "gbYCbCrMax";
            this.gbYCbCrMax.Size = new System.Drawing.Size(628, 173);
            this.gbYCbCrMax.TabIndex = 27;
            this.gbYCbCrMax.TabStop = false;
            this.gbYCbCrMax.Text = "Max Colors";
            // 
            // tbCbMax
            // 
            this.tbCbMax.BackColor = System.Drawing.SystemColors.Control;
            this.tbCbMax.Location = new System.Drawing.Point(73, 71);
            this.tbCbMax.Maximum = 255;
            this.tbCbMax.Name = "tbCbMax";
            this.tbCbMax.Size = new System.Drawing.Size(549, 45);
            this.tbCbMax.TabIndex = 3;
            this.tbCbMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCbMax.Value = 255;
            this.tbCbMax.ValueChanged += new System.EventHandler(this.tbCbMin_Scroll);
            // 
            // tbYMax
            // 
            this.tbYMax.BackColor = System.Drawing.SystemColors.Control;
            this.tbYMax.Location = new System.Drawing.Point(73, 31);
            this.tbYMax.Maximum = 255;
            this.tbYMax.Name = "tbYMax";
            this.tbYMax.Size = new System.Drawing.Size(549, 45);
            this.tbYMax.TabIndex = 3;
            this.tbYMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbYMax.Value = 20;
            this.tbYMax.ValueChanged += new System.EventHandler(this.tbYMin_Scroll);
            // 
            // tbCrMax
            // 
            this.tbCrMax.BackColor = System.Drawing.SystemColors.Control;
            this.tbCrMax.Location = new System.Drawing.Point(73, 122);
            this.tbCrMax.Maximum = 255;
            this.tbCrMax.Name = "tbCrMax";
            this.tbCrMax.Size = new System.Drawing.Size(549, 45);
            this.tbCrMax.TabIndex = 3;
            this.tbCrMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCrMax.Value = 255;
            this.tbCrMax.ValueChanged += new System.EventHandler(this.tbCrMin_Scroll);
            // 
            // lblCrMax
            // 
            this.lblCrMax.AutoSize = true;
            this.lblCrMax.Location = new System.Drawing.Point(15, 120);
            this.lblCrMax.Name = "lblCrMax";
            this.lblCrMax.Size = new System.Drawing.Size(29, 26);
            this.lblCrMax.TabIndex = 4;
            this.lblCrMax.Text = "Cr:\r\n255°";
            // 
            // lblYMax
            // 
            this.lblYMax.AutoSize = true;
            this.lblYMax.Location = new System.Drawing.Point(14, 31);
            this.lblYMax.Name = "lblYMax";
            this.lblYMax.Size = new System.Drawing.Size(23, 26);
            this.lblYMax.TabIndex = 4;
            this.lblYMax.Text = "Y:\r\n20°";
            // 
            // lblCbMax
            // 
            this.lblCbMax.AutoSize = true;
            this.lblCbMax.Location = new System.Drawing.Point(16, 73);
            this.lblCbMax.Name = "lblCbMax";
            this.lblCbMax.Size = new System.Drawing.Size(29, 26);
            this.lblCbMax.TabIndex = 4;
            this.lblCbMax.Text = "Cb:\r\n255°";
            // 
            // gbYCbCrMin
            // 
            this.gbYCbCrMin.BackColor = System.Drawing.Color.Transparent;
            this.gbYCbCrMin.Controls.Add(this.tbCbMin);
            this.gbYCbCrMin.Controls.Add(this.tbYMin);
            this.gbYCbCrMin.Controls.Add(this.tbCrMin);
            this.gbYCbCrMin.Controls.Add(this.lblCrMin);
            this.gbYCbCrMin.Controls.Add(this.lblYMin);
            this.gbYCbCrMin.Controls.Add(this.lblCbMin);
            this.gbYCbCrMin.Location = new System.Drawing.Point(18, 459);
            this.gbYCbCrMin.Name = "gbYCbCrMin";
            this.gbYCbCrMin.Size = new System.Drawing.Size(628, 173);
            this.gbYCbCrMin.TabIndex = 26;
            this.gbYCbCrMin.TabStop = false;
            this.gbYCbCrMin.Text = "Min Colors";
            // 
            // tbCbMin
            // 
            this.tbCbMin.BackColor = System.Drawing.SystemColors.Control;
            this.tbCbMin.Location = new System.Drawing.Point(54, 71);
            this.tbCbMin.Maximum = 255;
            this.tbCbMin.Name = "tbCbMin";
            this.tbCbMin.Size = new System.Drawing.Size(568, 45);
            this.tbCbMin.TabIndex = 3;
            this.tbCbMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCbMin.Value = 45;
            this.tbCbMin.Scroll += new System.EventHandler(this.tbCbMin_Scroll);
            this.tbCbMin.ValueChanged += new System.EventHandler(this.tbCbMin_Scroll);
            // 
            // tbYMin
            // 
            this.tbYMin.BackColor = System.Drawing.SystemColors.Control;
            this.tbYMin.Location = new System.Drawing.Point(54, 31);
            this.tbYMin.Maximum = 255;
            this.tbYMin.Name = "tbYMin";
            this.tbYMin.Size = new System.Drawing.Size(568, 45);
            this.tbYMin.TabIndex = 3;
            this.tbYMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbYMin.Scroll += new System.EventHandler(this.tbYMin_Scroll);
            this.tbYMin.ValueChanged += new System.EventHandler(this.tbYMin_Scroll);
            // 
            // tbCrMin
            // 
            this.tbCrMin.BackColor = System.Drawing.SystemColors.Control;
            this.tbCrMin.Location = new System.Drawing.Point(54, 122);
            this.tbCrMin.Maximum = 255;
            this.tbCrMin.Name = "tbCrMin";
            this.tbCrMin.Size = new System.Drawing.Size(568, 45);
            this.tbCrMin.TabIndex = 3;
            this.tbCrMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCrMin.Scroll += new System.EventHandler(this.tbCrMin_Scroll);
            this.tbCrMin.ValueChanged += new System.EventHandler(this.tbCrMin_Scroll);
            // 
            // lblCrMin
            // 
            this.lblCrMin.AutoSize = true;
            this.lblCrMin.Location = new System.Drawing.Point(17, 122);
            this.lblCrMin.Name = "lblCrMin";
            this.lblCrMin.Size = new System.Drawing.Size(20, 26);
            this.lblCrMin.TabIndex = 4;
            this.lblCrMin.Text = "Cr:\r\n0°";
            // 
            // lblYMin
            // 
            this.lblYMin.AutoSize = true;
            this.lblYMin.Location = new System.Drawing.Point(16, 31);
            this.lblYMin.Name = "lblYMin";
            this.lblYMin.Size = new System.Drawing.Size(17, 26);
            this.lblYMin.TabIndex = 4;
            this.lblYMin.Text = "Y:\r\n0°";
            // 
            // lblCbMin
            // 
            this.lblCbMin.AutoSize = true;
            this.lblCbMin.Location = new System.Drawing.Point(17, 73);
            this.lblCbMin.Name = "lblCbMin";
            this.lblCbMin.Size = new System.Drawing.Size(23, 26);
            this.lblCbMin.TabIndex = 4;
            this.lblCbMin.Text = "Cb:\r\n45°";
            // 
            // gbMaxColors
            // 
            this.gbMaxColors.BackColor = System.Drawing.Color.Transparent;
            this.gbMaxColors.Controls.Add(this.satMaxBar);
            this.gbMaxColors.Controls.Add(this.hueMaxBar);
            this.gbMaxColors.Controls.Add(this.valMaxBar);
            this.gbMaxColors.Controls.Add(this.lblValMax);
            this.gbMaxColors.Controls.Add(this.lblHueMax);
            this.gbMaxColors.Controls.Add(this.lblSatMax);
            this.gbMaxColors.Location = new System.Drawing.Point(669, 282);
            this.gbMaxColors.Name = "gbMaxColors";
            this.gbMaxColors.Size = new System.Drawing.Size(628, 173);
            this.gbMaxColors.TabIndex = 27;
            this.gbMaxColors.TabStop = false;
            this.gbMaxColors.Text = "Max Colors";
            // 
            // satMaxBar
            // 
            this.satMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.satMaxBar.Location = new System.Drawing.Point(73, 71);
            this.satMaxBar.Maximum = 255;
            this.satMaxBar.Name = "satMaxBar";
            this.satMaxBar.Size = new System.Drawing.Size(549, 45);
            this.satMaxBar.TabIndex = 3;
            this.satMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.satMaxBar.Value = 255;
            this.satMaxBar.ValueChanged += new System.EventHandler(this.satBar_Scroll);
            // 
            // hueMaxBar
            // 
            this.hueMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.hueMaxBar.Location = new System.Drawing.Point(73, 31);
            this.hueMaxBar.Maximum = 255;
            this.hueMaxBar.Name = "hueMaxBar";
            this.hueMaxBar.Size = new System.Drawing.Size(549, 45);
            this.hueMaxBar.TabIndex = 3;
            this.hueMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hueMaxBar.Value = 20;
            this.hueMaxBar.ValueChanged += new System.EventHandler(this.hueBar_Scroll);
            // 
            // valMaxBar
            // 
            this.valMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.valMaxBar.Location = new System.Drawing.Point(73, 122);
            this.valMaxBar.Maximum = 255;
            this.valMaxBar.Name = "valMaxBar";
            this.valMaxBar.Size = new System.Drawing.Size(549, 45);
            this.valMaxBar.TabIndex = 3;
            this.valMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valMaxBar.Value = 255;
            this.valMaxBar.ValueChanged += new System.EventHandler(this.valBar_Scroll);
            // 
            // lblValMax
            // 
            this.lblValMax.AutoSize = true;
            this.lblValMax.Location = new System.Drawing.Point(15, 120);
            this.lblValMax.Name = "lblValMax";
            this.lblValMax.Size = new System.Drawing.Size(29, 26);
            this.lblValMax.TabIndex = 4;
            this.lblValMax.Text = "Val:\r\n255°";
            // 
            // lblHueMax
            // 
            this.lblHueMax.AutoSize = true;
            this.lblHueMax.Location = new System.Drawing.Point(14, 31);
            this.lblHueMax.Name = "lblHueMax";
            this.lblHueMax.Size = new System.Drawing.Size(30, 26);
            this.lblHueMax.TabIndex = 4;
            this.lblHueMax.Text = "Hue:\r\n20°";
            // 
            // lblSatMax
            // 
            this.lblSatMax.AutoSize = true;
            this.lblSatMax.Location = new System.Drawing.Point(16, 73);
            this.lblSatMax.Name = "lblSatMax";
            this.lblSatMax.Size = new System.Drawing.Size(29, 26);
            this.lblSatMax.TabIndex = 4;
            this.lblSatMax.Text = "Sat:\r\n255°";
            // 
            // gbMinColors
            // 
            this.gbMinColors.BackColor = System.Drawing.Color.Transparent;
            this.gbMinColors.Controls.Add(this.satMinBar);
            this.gbMinColors.Controls.Add(this.hueMinBar);
            this.gbMinColors.Controls.Add(this.valMinBar);
            this.gbMinColors.Controls.Add(this.lblValMin);
            this.gbMinColors.Controls.Add(this.lblHueMin);
            this.gbMinColors.Controls.Add(this.lblSatMin);
            this.gbMinColors.Location = new System.Drawing.Point(18, 282);
            this.gbMinColors.Name = "gbMinColors";
            this.gbMinColors.Size = new System.Drawing.Size(628, 173);
            this.gbMinColors.TabIndex = 26;
            this.gbMinColors.TabStop = false;
            this.gbMinColors.Text = "Min Colors";
            // 
            // satMinBar
            // 
            this.satMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.satMinBar.Location = new System.Drawing.Point(54, 71);
            this.satMinBar.Maximum = 255;
            this.satMinBar.Name = "satMinBar";
            this.satMinBar.Size = new System.Drawing.Size(568, 45);
            this.satMinBar.TabIndex = 3;
            this.satMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.satMinBar.Value = 45;
            this.satMinBar.ValueChanged += new System.EventHandler(this.satBar_Scroll);
            // 
            // hueMinBar
            // 
            this.hueMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.hueMinBar.Location = new System.Drawing.Point(54, 31);
            this.hueMinBar.Maximum = 255;
            this.hueMinBar.Name = "hueMinBar";
            this.hueMinBar.Size = new System.Drawing.Size(568, 45);
            this.hueMinBar.TabIndex = 3;
            this.hueMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hueMinBar.ValueChanged += new System.EventHandler(this.hueBar_Scroll);
            // 
            // valMinBar
            // 
            this.valMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.valMinBar.Location = new System.Drawing.Point(54, 122);
            this.valMinBar.Maximum = 255;
            this.valMinBar.Name = "valMinBar";
            this.valMinBar.Size = new System.Drawing.Size(568, 45);
            this.valMinBar.TabIndex = 3;
            this.valMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valMinBar.ValueChanged += new System.EventHandler(this.valBar_Scroll);
            // 
            // lblValMin
            // 
            this.lblValMin.AutoSize = true;
            this.lblValMin.Location = new System.Drawing.Point(17, 122);
            this.lblValMin.Name = "lblValMin";
            this.lblValMin.Size = new System.Drawing.Size(25, 26);
            this.lblValMin.TabIndex = 4;
            this.lblValMin.Text = "Val:\r\n0°";
            // 
            // lblHueMin
            // 
            this.lblHueMin.AutoSize = true;
            this.lblHueMin.Location = new System.Drawing.Point(16, 31);
            this.lblHueMin.Name = "lblHueMin";
            this.lblHueMin.Size = new System.Drawing.Size(30, 26);
            this.lblHueMin.TabIndex = 4;
            this.lblHueMin.Text = "Hue:\r\n0°";
            // 
            // lblSatMin
            // 
            this.lblSatMin.AutoSize = true;
            this.lblSatMin.Location = new System.Drawing.Point(17, 73);
            this.lblSatMin.Name = "lblSatMin";
            this.lblSatMin.Size = new System.Drawing.Size(26, 26);
            this.lblSatMin.TabIndex = 4;
            this.lblSatMin.Text = "Sat:\r\n45°";
            // 
            // frmHandGestureRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 667);
            this.Controls.Add(this.tcPages);
            this.Name = "frmHandGestureRecognition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Gesture Recognition";
            this.tcPages.ResumeLayout(false);
            this.tpProgram.ResumeLayout(false);
            this.tpProgram.PerformLayout();
            this.gbThresholds.ResumeLayout(false);
            this.gbThresholds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreview)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            this.gbInformation.ResumeLayout(false);
            this.gbCameraSettings.ResumeLayout(false);
            this.gbCameraSettings.PerformLayout();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.tpColorSettings.ResumeLayout(false);
            this.tpColorSettings.PerformLayout();
            this.gbFilterSettings.ResumeLayout(false);
            this.gbFilterSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreviewSettings)).EndInit();
            this.gbYCbCrMax.ResumeLayout(false);
            this.gbYCbCrMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrMax)).EndInit();
            this.gbYCbCrMin.ResumeLayout(false);
            this.gbYCbCrMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCbMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrMin)).EndInit();
            this.gbMaxColors.ResumeLayout(false);
            this.gbMaxColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxBar)).EndInit();
            this.gbMinColors.ResumeLayout(false);
            this.gbMinColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMinBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPages;
        private System.Windows.Forms.TabPage tpProgram;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnClear;
        private Emgu.CV.UI.ImageBox ibOutput;
        private Emgu.CV.UI.ImageBox ibPreview;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cbBaudrates;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.NumericUpDown nbErode;
        private System.Windows.Forms.NumericUpDown nbDilate;
        private System.Windows.Forms.CheckBox ckbxShowLabels;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.CheckBox ckbxDilate;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.CheckBox ckbxErode;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.RichTextBox rtbOutputInfo;
        private System.Windows.Forms.GroupBox gbCameraSettings;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbPCWebcam;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TabPage tpColorSettings;
        private System.Windows.Forms.GroupBox gbYCbCrMax;
        private System.Windows.Forms.TrackBar tbCbMax;
        private System.Windows.Forms.TrackBar tbYMax;
        private System.Windows.Forms.TrackBar tbCrMax;
        private System.Windows.Forms.Label lblCrMax;
        private System.Windows.Forms.Label lblYMax;
        private System.Windows.Forms.Label lblCbMax;
        private System.Windows.Forms.GroupBox gbYCbCrMin;
        private System.Windows.Forms.TrackBar tbCbMin;
        private System.Windows.Forms.TrackBar tbYMin;
        private System.Windows.Forms.TrackBar tbCrMin;
        private System.Windows.Forms.Label lblCrMin;
        private System.Windows.Forms.Label lblYMin;
        private System.Windows.Forms.Label lblCbMin;
        private System.Windows.Forms.GroupBox gbMaxColors;
        private System.Windows.Forms.TrackBar satMaxBar;
        private System.Windows.Forms.TrackBar hueMaxBar;
        private System.Windows.Forms.TrackBar valMaxBar;
        private System.Windows.Forms.Label lblValMax;
        private System.Windows.Forms.Label lblHueMax;
        private System.Windows.Forms.Label lblSatMax;
        private System.Windows.Forms.GroupBox gbMinColors;
        private System.Windows.Forms.TrackBar satMinBar;
        private System.Windows.Forms.TrackBar hueMinBar;
        private System.Windows.Forms.TrackBar valMinBar;
        private System.Windows.Forms.Label lblValMin;
        private System.Windows.Forms.Label lblHueMin;
        private System.Windows.Forms.Label lblSatMin;
        private System.Windows.Forms.Label lblColorPreview;
        private Emgu.CV.UI.ImageBox ibPreviewSettings;
        private System.Windows.Forms.RadioButton rbColorRange;
        private System.Windows.Forms.RadioButton rbHSV;
        private System.Windows.Forms.RadioButton rbBGR;
        private System.Windows.Forms.GroupBox gbFilterSettings;
        private System.Windows.Forms.RadioButton rbHSVSettings;
        private System.Windows.Forms.RadioButton rbColorRangeSettings;
        private System.Windows.Forms.GroupBox gbThresholds;
        private System.Windows.Forms.TrackBar tbMaxThresh;
        private System.Windows.Forms.TrackBar tbMinThresh;
        private System.Windows.Forms.Label lblMaxThreshold;
        private System.Windows.Forms.Label lblMinThreshold;
        private System.Windows.Forms.RadioButton rbCanny;
    }
}

