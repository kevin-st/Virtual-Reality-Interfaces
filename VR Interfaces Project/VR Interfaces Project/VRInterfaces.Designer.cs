namespace VR_Interfaces_Project
{
    partial class frmVRInterfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVRInterfaces));
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.lblPoort = new System.Windows.Forms.Label();
            this.cbBaudrates = new System.Windows.Forms.ComboBox();
            this.lblBaudrate = new System.Windows.Forms.Label();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.gbCameraSettings = new System.Windows.Forms.GroupBox();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbPCWebcam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPrevInfo = new System.Windows.Forms.GroupBox();
            this.rtbPreviewInfo = new System.Windows.Forms.RichTextBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.ckbxShowLabels = new System.Windows.Forms.CheckBox();
            this.tbAcumulatorThresh = new System.Windows.Forms.TrackBar();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tbCannyThresh = new System.Windows.Forms.TrackBar();
            this.numArea = new System.Windows.Forms.NumericUpDown();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.numMinRadius = new System.Windows.Forms.NumericUpDown();
            this.numMinDist = new System.Windows.Forms.NumericUpDown();
            this.lblAccumulatorThresh = new System.Windows.Forms.Label();
            this.lblMinRadius = new System.Windows.Forms.Label();
            this.lblCannyThresh = new System.Windows.Forms.Label();
            this.lblMinDist = new System.Windows.Forms.Label();
            this.numDp = new System.Windows.Forms.NumericUpDown();
            this.lblDp = new System.Windows.Forms.Label();
            this.numThickness = new System.Windows.Forms.NumericUpDown();
            this.lblThickness = new System.Windows.Forms.Label();
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbFonts = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.gbThreshold = new System.Windows.Forms.GroupBox();
            this.tbMaxThresh = new System.Windows.Forms.TrackBar();
            this.tbMinThresh = new System.Windows.Forms.TrackBar();
            this.lblMaxThreshold = new System.Windows.Forms.Label();
            this.lblMinThreshold = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rbCanny = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbGrid = new System.Windows.Forms.RadioButton();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.rbBgr = new System.Windows.Forms.RadioButton();
            this.ibPreview = new Emgu.CV.UI.ImageBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.tpGame = new System.Windows.Forms.TabPage();
            this.gbGameInfo = new System.Windows.Forms.GroupBox();
            this.rtbGameInfo = new System.Windows.Forms.RichTextBox();
            this.pnlGameView = new System.Windows.Forms.Panel();
            this.lblGameView = new System.Windows.Forms.Label();
            this.lblCamView = new System.Windows.Forms.Label();
            this.ibCamView = new Emgu.CV.UI.ImageBox();
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.bttnStopGame = new System.Windows.Forms.Button();
            this.bttnSetGame = new System.Windows.Forms.Button();
            this.lblTiles = new System.Windows.Forms.Label();
            this.lblBy = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.bttnStart = new System.Windows.Forms.Button();
            this.bttnStop = new System.Windows.Forms.Button();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.bttnClear = new System.Windows.Forms.Button();
            this.ckbxRectangles = new System.Windows.Forms.CheckBox();
            this.ckbxCircles = new System.Windows.Forms.CheckBox();
            this.ckbxTriangles = new System.Windows.Forms.CheckBox();
            this.lblTrackFigures = new System.Windows.Forms.Label();
            this.tcTabs.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbCameraSettings.SuspendLayout();
            this.gbPrevInfo.SuspendLayout();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAcumulatorThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCannyThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).BeginInit();
            this.gbThreshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinThresh)).BeginInit();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreview)).BeginInit();
            this.tpGame.SuspendLayout();
            this.gbGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCamView)).BeginInit();
            this.gbGameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(47, 16);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 0;
            // 
            // lblPoort
            // 
            this.lblPoort.AutoSize = true;
            this.lblPoort.Location = new System.Drawing.Point(6, 16);
            this.lblPoort.Name = "lblPoort";
            this.lblPoort.Size = new System.Drawing.Size(35, 13);
            this.lblPoort.TabIndex = 1;
            this.lblPoort.Text = "Poort:";
            // 
            // cbBaudrates
            // 
            this.cbBaudrates.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.cbBaudrates.Location = new System.Drawing.Point(290, 16);
            this.cbBaudrates.Name = "cbBaudrates";
            this.cbBaudrates.Size = new System.Drawing.Size(121, 21);
            this.cbBaudrates.TabIndex = 0;
            // 
            // lblBaudrate
            // 
            this.lblBaudrate.AutoSize = true;
            this.lblBaudrate.Location = new System.Drawing.Point(231, 16);
            this.lblBaudrate.Name = "lblBaudrate";
            this.lblBaudrate.Size = new System.Drawing.Size(53, 13);
            this.lblBaudrate.TabIndex = 1;
            this.lblBaudrate.Text = "Baudrate:";
            // 
            // tcTabs
            // 
            this.tcTabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcTabs.Controls.Add(this.tpSettings);
            this.tcTabs.Controls.Add(this.tpGame);
            this.tcTabs.Location = new System.Drawing.Point(15, 12);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(1140, 521);
            this.tcTabs.TabIndex = 2;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.Transparent;
            this.tpSettings.Controls.Add(this.gbCameraSettings);
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.gbPrevInfo);
            this.tpSettings.Controls.Add(this.gbParameters);
            this.tpSettings.Controls.Add(this.gbThreshold);
            this.tpSettings.Controls.Add(this.gbFilter);
            this.tpSettings.Controls.Add(this.ibPreview);
            this.tpSettings.Controls.Add(this.lblPreview);
            this.tpSettings.Controls.Add(this.lblBaudrate);
            this.tpSettings.Controls.Add(this.lblPoort);
            this.tpSettings.Controls.Add(this.cbBaudrates);
            this.tpSettings.Controls.Add(this.cbPorts);
            this.tpSettings.Location = new System.Drawing.Point(4, 25);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(1132, 492);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            // 
            // gbCameraSettings
            // 
            this.gbCameraSettings.Controls.Add(this.rbAndroid);
            this.gbCameraSettings.Controls.Add(this.rbPCWebcam);
            this.gbCameraSettings.Location = new System.Drawing.Point(290, 378);
            this.gbCameraSettings.Name = "gbCameraSettings";
            this.gbCameraSettings.Size = new System.Drawing.Size(407, 108);
            this.gbCameraSettings.TabIndex = 7;
            this.gbCameraSettings.TabStop = false;
            this.gbCameraSettings.Text = "Camera Settings";
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(10, 57);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(61, 17);
            this.rbAndroid.TabIndex = 0;
            this.rbAndroid.Text = "Android";
            this.rbAndroid.UseVisualStyleBackColor = true;
            this.rbAndroid.CheckedChanged += new System.EventHandler(this.rbAndroid_CheckedChanged);
            // 
            // rbPCWebcam
            // 
            this.rbPCWebcam.AutoSize = true;
            this.rbPCWebcam.Checked = true;
            this.rbPCWebcam.Location = new System.Drawing.Point(10, 30);
            this.rbPCWebcam.Name = "rbPCWebcam";
            this.rbPCWebcam.Size = new System.Drawing.Size(85, 17);
            this.rbPCWebcam.TabIndex = 0;
            this.rbPCWebcam.TabStop = true;
            this.rbPCWebcam.Text = "PC Webcam";
            this.rbPCWebcam.UseVisualStyleBackColor = true;
            this.rbPCWebcam.CheckedChanged += new System.EventHandler(this.rbAndroid_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // gbPrevInfo
            // 
            this.gbPrevInfo.Controls.Add(this.rtbPreviewInfo);
            this.gbPrevInfo.Location = new System.Drawing.Point(291, 202);
            this.gbPrevInfo.Name = "gbPrevInfo";
            this.gbPrevInfo.Size = new System.Drawing.Size(406, 169);
            this.gbPrevInfo.TabIndex = 5;
            this.gbPrevInfo.TabStop = false;
            this.gbPrevInfo.Text = "Preview information";
            // 
            // rtbPreviewInfo
            // 
            this.rtbPreviewInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPreviewInfo.Location = new System.Drawing.Point(9, 19);
            this.rtbPreviewInfo.Name = "rtbPreviewInfo";
            this.rtbPreviewInfo.ReadOnly = true;
            this.rtbPreviewInfo.Size = new System.Drawing.Size(384, 144);
            this.rtbPreviewInfo.TabIndex = 0;
            this.rtbPreviewInfo.Text = "";
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.ckbxShowLabels);
            this.gbParameters.Controls.Add(this.tbAcumulatorThresh);
            this.gbParameters.Controls.Add(this.lblArea);
            this.gbParameters.Controls.Add(this.lblSize);
            this.gbParameters.Controls.Add(this.tbCannyThresh);
            this.gbParameters.Controls.Add(this.numArea);
            this.gbParameters.Controls.Add(this.numSize);
            this.gbParameters.Controls.Add(this.numMinRadius);
            this.gbParameters.Controls.Add(this.numMinDist);
            this.gbParameters.Controls.Add(this.lblAccumulatorThresh);
            this.gbParameters.Controls.Add(this.lblMinRadius);
            this.gbParameters.Controls.Add(this.lblCannyThresh);
            this.gbParameters.Controls.Add(this.lblMinDist);
            this.gbParameters.Controls.Add(this.numDp);
            this.gbParameters.Controls.Add(this.lblDp);
            this.gbParameters.Controls.Add(this.numThickness);
            this.gbParameters.Controls.Add(this.lblThickness);
            this.gbParameters.Controls.Add(this.cbColors);
            this.gbParameters.Controls.Add(this.lblColor);
            this.gbParameters.Controls.Add(this.cbFonts);
            this.gbParameters.Controls.Add(this.lblFont);
            this.gbParameters.Location = new System.Drawing.Point(9, 147);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(275, 339);
            this.gbParameters.TabIndex = 4;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // ckbxShowLabels
            // 
            this.ckbxShowLabels.AutoSize = true;
            this.ckbxShowLabels.Checked = true;
            this.ckbxShowLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxShowLabels.Location = new System.Drawing.Point(145, 184);
            this.ckbxShowLabels.Name = "ckbxShowLabels";
            this.ckbxShowLabels.Size = new System.Drawing.Size(87, 17);
            this.ckbxShowLabels.TabIndex = 5;
            this.ckbxShowLabels.Text = "Show Labels";
            this.ckbxShowLabels.UseVisualStyleBackColor = true;
            // 
            // tbAcumulatorThresh
            // 
            this.tbAcumulatorThresh.Location = new System.Drawing.Point(6, 288);
            this.tbAcumulatorThresh.Maximum = 255;
            this.tbAcumulatorThresh.Minimum = 1;
            this.tbAcumulatorThresh.Name = "tbAcumulatorThresh";
            this.tbAcumulatorThresh.Size = new System.Drawing.Size(246, 45);
            this.tbAcumulatorThresh.TabIndex = 1;
            this.tbAcumulatorThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ttHelp.SetToolTip(this.tbAcumulatorThresh, resources.GetString("tbAcumulatorThresh.ToolTip"));
            this.tbAcumulatorThresh.Value = 120;
            this.tbAcumulatorThresh.Scroll += new System.EventHandler(this.tbCannyThresh_Scroll);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(176, 72);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(176, 35);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // tbCannyThresh
            // 
            this.tbCannyThresh.Location = new System.Drawing.Point(6, 213);
            this.tbCannyThresh.Maximum = 255;
            this.tbCannyThresh.Minimum = 1;
            this.tbCannyThresh.Name = "tbCannyThresh";
            this.tbCannyThresh.Size = new System.Drawing.Size(246, 45);
            this.tbCannyThresh.TabIndex = 1;
            this.tbCannyThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCannyThresh.Value = 180;
            this.tbCannyThresh.Scroll += new System.EventHandler(this.tbCannyThresh_Scroll);
            // 
            // numArea
            // 
            this.numArea.Location = new System.Drawing.Point(212, 69);
            this.numArea.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numArea.Name = "numArea";
            this.numArea.Size = new System.Drawing.Size(40, 20);
            this.numArea.TabIndex = 3;
            this.numArea.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(212, 32);
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
            this.numSize.TabIndex = 3;
            this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numMinRadius
            // 
            this.numMinRadius.Location = new System.Drawing.Point(212, 146);
            this.numMinRadius.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numMinRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinRadius.Name = "numMinRadius";
            this.numMinRadius.Size = new System.Drawing.Size(40, 20);
            this.numMinRadius.TabIndex = 3;
            this.numMinRadius.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numMinDist
            // 
            this.numMinDist.Location = new System.Drawing.Point(69, 146);
            this.numMinDist.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMinDist.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinDist.Name = "numMinDist";
            this.numMinDist.Size = new System.Drawing.Size(40, 20);
            this.numMinDist.TabIndex = 3;
            this.ttHelp.SetToolTip(this.numMinDist, resources.GetString("numMinDist.ToolTip"));
            this.numMinDist.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblAccumulatorThresh
            // 
            this.lblAccumulatorThresh.AutoSize = true;
            this.lblAccumulatorThresh.Location = new System.Drawing.Point(6, 261);
            this.lblAccumulatorThresh.Name = "lblAccumulatorThresh";
            this.lblAccumulatorThresh.Size = new System.Drawing.Size(136, 13);
            this.lblAccumulatorThresh.TabIndex = 2;
            this.lblAccumulatorThresh.Text = "Accumulator threshold: 120";
            this.ttHelp.SetToolTip(this.lblAccumulatorThresh, resources.GetString("lblAccumulatorThresh.ToolTip"));
            // 
            // lblMinRadius
            // 
            this.lblMinRadius.AutoSize = true;
            this.lblMinRadius.Location = new System.Drawing.Point(142, 148);
            this.lblMinRadius.Name = "lblMinRadius";
            this.lblMinRadius.Size = new System.Drawing.Size(58, 13);
            this.lblMinRadius.TabIndex = 2;
            this.lblMinRadius.Text = "Min radius:";
            // 
            // lblCannyThresh
            // 
            this.lblCannyThresh.AutoSize = true;
            this.lblCannyThresh.Location = new System.Drawing.Point(6, 188);
            this.lblCannyThresh.Name = "lblCannyThresh";
            this.lblCannyThresh.Size = new System.Drawing.Size(107, 13);
            this.lblCannyThresh.TabIndex = 2;
            this.lblCannyThresh.Text = "Canny threshold: 180";
            // 
            // lblMinDist
            // 
            this.lblMinDist.AutoSize = true;
            this.lblMinDist.Location = new System.Drawing.Point(6, 148);
            this.lblMinDist.Name = "lblMinDist";
            this.lblMinDist.Size = new System.Drawing.Size(46, 13);
            this.lblMinDist.TabIndex = 2;
            this.lblMinDist.Text = "Min dist:";
            this.ttHelp.SetToolTip(this.lblMinDist, resources.GetString("lblMinDist.ToolTip"));
            // 
            // numDp
            // 
            this.numDp.Location = new System.Drawing.Point(212, 109);
            this.numDp.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDp.Name = "numDp";
            this.numDp.Size = new System.Drawing.Size(40, 20);
            this.numDp.TabIndex = 3;
            this.ttHelp.SetToolTip(this.numDp, resources.GetString("numDp.ToolTip"));
            this.numDp.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblDp
            // 
            this.lblDp.AutoSize = true;
            this.lblDp.Location = new System.Drawing.Point(176, 111);
            this.lblDp.Name = "lblDp";
            this.lblDp.Size = new System.Drawing.Size(24, 13);
            this.lblDp.TabIndex = 2;
            this.lblDp.Text = "Dp:";
            this.ttHelp.SetToolTip(this.lblDp, resources.GetString("lblDp.ToolTip"));
            // 
            // numThickness
            // 
            this.numThickness.Location = new System.Drawing.Point(69, 109);
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
            this.numThickness.TabIndex = 3;
            this.ttHelp.SetToolTip(this.numThickness, "The thickness of the lines which will be drawn.");
            this.numThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(6, 111);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(59, 13);
            this.lblThickness.TabIndex = 2;
            this.lblThickness.Text = "Thickness:";
            this.ttHelp.SetToolTip(this.lblThickness, "The thickness of the lines which will be drawn.");
            // 
            // cbColors
            // 
            this.cbColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(69, 69);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(90, 21);
            this.cbColors.TabIndex = 1;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(6, 72);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(34, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color:";
            // 
            // cbFonts
            // 
            this.cbFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFonts.FormattingEnabled = true;
            this.cbFonts.Location = new System.Drawing.Point(69, 32);
            this.cbFonts.Name = "cbFonts";
            this.cbFonts.Size = new System.Drawing.Size(90, 21);
            this.cbFonts.TabIndex = 1;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(6, 35);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(31, 13);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font:";
            // 
            // gbThreshold
            // 
            this.gbThreshold.Controls.Add(this.tbMaxThresh);
            this.gbThreshold.Controls.Add(this.tbMinThresh);
            this.gbThreshold.Controls.Add(this.lblMaxThreshold);
            this.gbThreshold.Controls.Add(this.lblMinThreshold);
            this.gbThreshold.Enabled = false;
            this.gbThreshold.Location = new System.Drawing.Point(290, 67);
            this.gbThreshold.Name = "gbThreshold";
            this.gbThreshold.Size = new System.Drawing.Size(407, 128);
            this.gbThreshold.TabIndex = 3;
            this.gbThreshold.TabStop = false;
            this.gbThreshold.Text = "Thresholds";
            // 
            // tbMaxThresh
            // 
            this.tbMaxThresh.Location = new System.Drawing.Point(69, 70);
            this.tbMaxThresh.Maximum = 255;
            this.tbMaxThresh.Minimum = 1;
            this.tbMaxThresh.Name = "tbMaxThresh";
            this.tbMaxThresh.Size = new System.Drawing.Size(325, 45);
            this.tbMaxThresh.TabIndex = 1;
            this.tbMaxThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMaxThresh.Value = 120;
            this.tbMaxThresh.Scroll += new System.EventHandler(this.tbCannyThresh_Scroll);
            // 
            // tbMinThresh
            // 
            this.tbMinThresh.Location = new System.Drawing.Point(69, 19);
            this.tbMinThresh.Maximum = 255;
            this.tbMinThresh.Minimum = 1;
            this.tbMinThresh.Name = "tbMinThresh";
            this.tbMinThresh.Size = new System.Drawing.Size(325, 45);
            this.tbMinThresh.TabIndex = 1;
            this.tbMinThresh.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMinThresh.Value = 180;
            this.tbMinThresh.Scroll += new System.EventHandler(this.tbCannyThresh_Scroll);
            // 
            // lblMaxThreshold
            // 
            this.lblMaxThreshold.AutoSize = true;
            this.lblMaxThreshold.Location = new System.Drawing.Point(7, 70);
            this.lblMaxThreshold.Name = "lblMaxThreshold";
            this.lblMaxThreshold.Size = new System.Drawing.Size(59, 26);
            this.lblMaxThreshold.TabIndex = 0;
            this.lblMaxThreshold.Text = "Max value:\r\n120";
            // 
            // lblMinThreshold
            // 
            this.lblMinThreshold.AutoSize = true;
            this.lblMinThreshold.Location = new System.Drawing.Point(7, 20);
            this.lblMinThreshold.Name = "lblMinThreshold";
            this.lblMinThreshold.Size = new System.Drawing.Size(56, 26);
            this.lblMinThreshold.TabIndex = 0;
            this.lblMinThreshold.Text = "Min value:\r\n180";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbCanny);
            this.gbFilter.Controls.Add(this.rbTriangle);
            this.gbFilter.Controls.Add(this.rbCircle);
            this.gbFilter.Controls.Add(this.rbGrid);
            this.gbFilter.Controls.Add(this.rbGray);
            this.gbFilter.Controls.Add(this.rbBgr);
            this.gbFilter.Location = new System.Drawing.Point(9, 67);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(275, 73);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filters";
            // 
            // rbCanny
            // 
            this.rbCanny.AutoSize = true;
            this.rbCanny.Location = new System.Drawing.Point(168, 20);
            this.rbCanny.Name = "rbCanny";
            this.rbCanny.Size = new System.Drawing.Size(55, 17);
            this.rbCanny.TabIndex = 0;
            this.rbCanny.TabStop = true;
            this.rbCanny.Text = "Canny";
            this.rbCanny.UseVisualStyleBackColor = true;
            this.rbCanny.CheckedChanged += new System.EventHandler(this.rbCanny_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(168, 43);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(68, 17);
            this.rbTriangle.TabIndex = 0;
            this.rbTriangle.Text = "Triangles";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbCanny_CheckedChanged);
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(88, 43);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(56, 17);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circles";
            this.rbCircle.UseVisualStyleBackColor = true;
            // 
            // rbGrid
            // 
            this.rbGrid.AutoSize = true;
            this.rbGrid.Location = new System.Drawing.Point(6, 43);
            this.rbGrid.Name = "rbGrid";
            this.rbGrid.Size = new System.Drawing.Size(44, 17);
            this.rbGrid.TabIndex = 0;
            this.rbGrid.TabStop = true;
            this.rbGrid.Text = "Grid";
            this.rbGrid.UseVisualStyleBackColor = true;
            this.rbGrid.CheckedChanged += new System.EventHandler(this.rbCanny_CheckedChanged);
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Location = new System.Drawing.Point(88, 20);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(47, 17);
            this.rbGray.TabIndex = 0;
            this.rbGray.TabStop = true;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            // 
            // rbBgr
            // 
            this.rbBgr.AutoSize = true;
            this.rbBgr.Checked = true;
            this.rbBgr.Location = new System.Drawing.Point(6, 20);
            this.rbBgr.Name = "rbBgr";
            this.rbBgr.Size = new System.Drawing.Size(41, 17);
            this.rbBgr.TabIndex = 0;
            this.rbBgr.TabStop = true;
            this.rbBgr.Text = "Bgr";
            this.rbBgr.UseVisualStyleBackColor = true;
            // 
            // ibPreview
            // 
            this.ibPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibPreview.Location = new System.Drawing.Point(703, 83);
            this.ibPreview.Name = "ibPreview";
            this.ibPreview.Size = new System.Drawing.Size(425, 403);
            this.ibPreview.TabIndex = 2;
            this.ibPreview.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(703, 67);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(48, 13);
            this.lblPreview.TabIndex = 2;
            this.lblPreview.Text = "Preview:";
            // 
            // tpGame
            // 
            this.tpGame.Controls.Add(this.gbGameInfo);
            this.tpGame.Controls.Add(this.pnlGameView);
            this.tpGame.Controls.Add(this.lblGameView);
            this.tpGame.Controls.Add(this.lblCamView);
            this.tpGame.Controls.Add(this.ibCamView);
            this.tpGame.Controls.Add(this.gbGameSettings);
            this.tpGame.Location = new System.Drawing.Point(4, 25);
            this.tpGame.Name = "tpGame";
            this.tpGame.Padding = new System.Windows.Forms.Padding(3);
            this.tpGame.Size = new System.Drawing.Size(1132, 492);
            this.tpGame.TabIndex = 1;
            this.tpGame.Text = "Game";
            this.tpGame.UseVisualStyleBackColor = true;
            // 
            // gbGameInfo
            // 
            this.gbGameInfo.Controls.Add(this.rtbGameInfo);
            this.gbGameInfo.Location = new System.Drawing.Point(848, 191);
            this.gbGameInfo.Name = "gbGameInfo";
            this.gbGameInfo.Size = new System.Drawing.Size(274, 274);
            this.gbGameInfo.TabIndex = 9;
            this.gbGameInfo.TabStop = false;
            this.gbGameInfo.Text = "Game Information";
            // 
            // rtbGameInfo
            // 
            this.rtbGameInfo.BackColor = System.Drawing.SystemColors.Control;
            this.rtbGameInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbGameInfo.Location = new System.Drawing.Point(3, 16);
            this.rtbGameInfo.Name = "rtbGameInfo";
            this.rtbGameInfo.Size = new System.Drawing.Size(268, 255);
            this.rtbGameInfo.TabIndex = 0;
            this.rtbGameInfo.Text = "";
            // 
            // pnlGameView
            // 
            this.pnlGameView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGameView.Location = new System.Drawing.Point(390, 45);
            this.pnlGameView.Name = "pnlGameView";
            this.pnlGameView.Size = new System.Drawing.Size(449, 420);
            this.pnlGameView.TabIndex = 4;
            // 
            // lblGameView
            // 
            this.lblGameView.AutoSize = true;
            this.lblGameView.Location = new System.Drawing.Point(387, 26);
            this.lblGameView.Name = "lblGameView";
            this.lblGameView.Size = new System.Drawing.Size(63, 13);
            this.lblGameView.TabIndex = 3;
            this.lblGameView.Text = "Game view:";
            // 
            // lblCamView
            // 
            this.lblCamView.AutoSize = true;
            this.lblCamView.Location = new System.Drawing.Point(7, 26);
            this.lblCamView.Name = "lblCamView";
            this.lblCamView.Size = new System.Drawing.Size(71, 13);
            this.lblCamView.TabIndex = 3;
            this.lblCamView.Text = "Camera view:";
            // 
            // ibCamView
            // 
            this.ibCamView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibCamView.Location = new System.Drawing.Point(6, 45);
            this.ibCamView.Name = "ibCamView";
            this.ibCamView.Size = new System.Drawing.Size(378, 420);
            this.ibCamView.TabIndex = 2;
            this.ibCamView.TabStop = false;
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.lblTrackFigures);
            this.gbGameSettings.Controls.Add(this.ckbxTriangles);
            this.gbGameSettings.Controls.Add(this.ckbxCircles);
            this.gbGameSettings.Controls.Add(this.ckbxRectangles);
            this.gbGameSettings.Controls.Add(this.bttnStopGame);
            this.gbGameSettings.Controls.Add(this.bttnSetGame);
            this.gbGameSettings.Controls.Add(this.lblTiles);
            this.gbGameSettings.Controls.Add(this.lblBy);
            this.gbGameSettings.Controls.Add(this.numWidth);
            this.gbGameSettings.Controls.Add(this.numHeight);
            this.gbGameSettings.Location = new System.Drawing.Point(848, 39);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(280, 146);
            this.gbGameSettings.TabIndex = 8;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Game Settings";
            // 
            // bttnStopGame
            // 
            this.bttnStopGame.BackColor = System.Drawing.Color.Transparent;
            this.bttnStopGame.Enabled = false;
            this.bttnStopGame.Location = new System.Drawing.Point(196, 111);
            this.bttnStopGame.Name = "bttnStopGame";
            this.bttnStopGame.Size = new System.Drawing.Size(75, 23);
            this.bttnStopGame.TabIndex = 8;
            this.bttnStopGame.Text = "Stop Game";
            this.bttnStopGame.UseVisualStyleBackColor = false;
            this.bttnStopGame.Click += new System.EventHandler(this.bttnStopGame_Click);
            // 
            // bttnSetGame
            // 
            this.bttnSetGame.BackColor = System.Drawing.Color.Transparent;
            this.bttnSetGame.Location = new System.Drawing.Point(116, 111);
            this.bttnSetGame.Name = "bttnSetGame";
            this.bttnSetGame.Size = new System.Drawing.Size(75, 23);
            this.bttnSetGame.TabIndex = 8;
            this.bttnSetGame.Text = "Set Game";
            this.bttnSetGame.UseVisualStyleBackColor = false;
            this.bttnSetGame.Click += new System.EventHandler(this.bttnSetGame_Click);
            // 
            // lblTiles
            // 
            this.lblTiles.AutoSize = true;
            this.lblTiles.Location = new System.Drawing.Point(11, 25);
            this.lblTiles.Name = "lblTiles";
            this.lblTiles.Size = new System.Drawing.Size(32, 13);
            this.lblTiles.TabIndex = 6;
            this.lblTiles.Text = "Tiles:";
            // 
            // lblBy
            // 
            this.lblBy.AutoSize = true;
            this.lblBy.Location = new System.Drawing.Point(92, 27);
            this.lblBy.Name = "lblBy";
            this.lblBy.Size = new System.Drawing.Size(18, 13);
            this.lblBy.TabIndex = 7;
            this.lblBy.Text = "by";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(49, 23);
            this.numWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(37, 20);
            this.numWidth.TabIndex = 5;
            this.numWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(116, 23);
            this.numHeight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(37, 20);
            this.numHeight.TabIndex = 5;
            this.numHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bttnStart
            // 
            this.bttnStart.Location = new System.Drawing.Point(991, 539);
            this.bttnStart.Name = "bttnStart";
            this.bttnStart.Size = new System.Drawing.Size(75, 23);
            this.bttnStart.TabIndex = 3;
            this.bttnStart.Text = "Start";
            this.bttnStart.UseVisualStyleBackColor = true;
            this.bttnStart.Click += new System.EventHandler(this.bttnStart_Click);
            // 
            // bttnStop
            // 
            this.bttnStop.Location = new System.Drawing.Point(1072, 539);
            this.bttnStop.Name = "bttnStop";
            this.bttnStop.Size = new System.Drawing.Size(75, 23);
            this.bttnStop.TabIndex = 3;
            this.bttnStop.Text = "Stop";
            this.bttnStop.UseVisualStyleBackColor = true;
            this.bttnStop.Click += new System.EventHandler(this.bttnStop_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(910, 539);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 3;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // ckbxRectangles
            // 
            this.ckbxRectangles.AutoSize = true;
            this.ckbxRectangles.Location = new System.Drawing.Point(14, 78);
            this.ckbxRectangles.Name = "ckbxRectangles";
            this.ckbxRectangles.Size = new System.Drawing.Size(80, 17);
            this.ckbxRectangles.TabIndex = 9;
            this.ckbxRectangles.Text = "Rectangles";
            this.ckbxRectangles.UseVisualStyleBackColor = true;
            // 
            // ckbxCircles
            // 
            this.ckbxCircles.AutoSize = true;
            this.ckbxCircles.Location = new System.Drawing.Point(116, 78);
            this.ckbxCircles.Name = "ckbxCircles";
            this.ckbxCircles.Size = new System.Drawing.Size(57, 17);
            this.ckbxCircles.TabIndex = 9;
            this.ckbxCircles.Text = "Circles";
            this.ckbxCircles.UseVisualStyleBackColor = true;
            // 
            // ckbxTriangles
            // 
            this.ckbxTriangles.AutoSize = true;
            this.ckbxTriangles.Location = new System.Drawing.Point(202, 78);
            this.ckbxTriangles.Name = "ckbxTriangles";
            this.ckbxTriangles.Size = new System.Drawing.Size(69, 17);
            this.ckbxTriangles.TabIndex = 9;
            this.ckbxTriangles.Text = "Triangles";
            this.ckbxTriangles.UseVisualStyleBackColor = true;
            // 
            // lblTrackFigures
            // 
            this.lblTrackFigures.AutoSize = true;
            this.lblTrackFigures.Location = new System.Drawing.Point(11, 57);
            this.lblTrackFigures.Name = "lblTrackFigures";
            this.lblTrackFigures.Size = new System.Drawing.Size(75, 13);
            this.lblTrackFigures.TabIndex = 0;
            this.lblTrackFigures.Text = "Track Figures:";
            // 
            // frmVRInterfaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 574);
            this.Controls.Add(this.bttnStop);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnStart);
            this.Controls.Add(this.tcTabs);
            this.Name = "frmVRInterfaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VR Interfaces";
            this.tcTabs.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.gbCameraSettings.ResumeLayout(false);
            this.gbCameraSettings.PerformLayout();
            this.gbPrevInfo.ResumeLayout(false);
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAcumulatorThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCannyThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThickness)).EndInit();
            this.gbThreshold.ResumeLayout(false);
            this.gbThreshold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaxThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinThresh)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibPreview)).EndInit();
            this.tpGame.ResumeLayout(false);
            this.tpGame.PerformLayout();
            this.gbGameInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibCamView)).EndInit();
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Label lblPoort;
        private System.Windows.Forms.ComboBox cbBaudrates;
        private System.Windows.Forms.Label lblBaudrate;
        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpGame;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.Button bttnStart;
        private System.Windows.Forms.Button bttnStop;
        private System.Windows.Forms.Label lblPreview;
        private Emgu.CV.UI.ImageBox ibPreview;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.RadioButton rbCanny;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbBgr;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbGrid;
        private System.Windows.Forms.GroupBox gbThreshold;
        private System.Windows.Forms.Label lblMinThreshold;
        private System.Windows.Forms.TrackBar tbMinThresh;
        private System.Windows.Forms.Label lblMaxThreshold;
        private System.Windows.Forms.TrackBar tbMaxThresh;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cbFonts;
        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.NumericUpDown numThickness;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.NumericUpDown numMinDist;
        private System.Windows.Forms.Label lblMinDist;
        private System.Windows.Forms.NumericUpDown numDp;
        private System.Windows.Forms.Label lblDp;
        private System.Windows.Forms.TrackBar tbAcumulatorThresh;
        private System.Windows.Forms.TrackBar tbCannyThresh;
        private System.Windows.Forms.Label lblCannyThresh;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.Label lblAccumulatorThresh;
        private System.Windows.Forms.NumericUpDown numMinRadius;
        private System.Windows.Forms.Label lblMinRadius;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.NumericUpDown numArea;
        private System.Windows.Forms.GroupBox gbPrevInfo;
        private System.Windows.Forms.RichTextBox rtbPreviewInfo;
        private System.Windows.Forms.Panel pnlGameView;
        private System.Windows.Forms.Label lblGameView;
        private System.Windows.Forms.Label lblCamView;
        private Emgu.CV.UI.ImageBox ibCamView;
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.Label lblTiles;
        private System.Windows.Forms.Label lblBy;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.Button bttnSetGame;
        private System.Windows.Forms.CheckBox ckbxShowLabels;
        private System.Windows.Forms.GroupBox gbGameInfo;
        private System.Windows.Forms.RichTextBox rtbGameInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCameraSettings;
        private System.Windows.Forms.RadioButton rbPCWebcam;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.Button bttnStopGame;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.CheckBox ckbxRectangles;
        private System.Windows.Forms.Label lblTrackFigures;
        private System.Windows.Forms.CheckBox ckbxTriangles;
        private System.Windows.Forms.CheckBox ckbxCircles;
    }
}

