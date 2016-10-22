namespace SerialPortCommunication
{
    partial class SerialPortTestfrm
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
            this.portsCmbx = new System.Windows.Forms.ComboBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.baudrateLbl = new System.Windows.Forms.Label();
            this.baudrateCmbx = new System.Windows.Forms.ComboBox();
            this.startBttn = new System.Windows.Forms.Button();
            this.stopBttn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settingsPg = new System.Windows.Forms.TabPage();
            this.saveGrBx = new System.Windows.Forms.GroupBox();
            this.saveBttn = new System.Windows.Forms.Button();
            this.loadFileBttn = new System.Windows.Forms.Button();
            this.savePathBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.loadTxtBx = new System.Windows.Forms.TextBox();
            this.savePathTxtBx = new System.Windows.Forms.TextBox();
            this.thresholdGrBx = new System.Windows.Forms.GroupBox();
            this.maxThreshBar = new System.Windows.Forms.TrackBar();
            this.minThreshBar = new System.Windows.Forms.TrackBar();
            this.maxThreshLbl = new System.Windows.Forms.Label();
            this.minThreshLbl = new System.Windows.Forms.Label();
            this.previewLbl = new System.Windows.Forms.Label();
            this.previewImgBx = new Emgu.CV.UI.ImageBox();
            this.maxColorsGrBx = new System.Windows.Forms.GroupBox();
            this.satMaxBar = new System.Windows.Forms.TrackBar();
            this.hueMaxBar = new System.Windows.Forms.TrackBar();
            this.valMaxBar = new System.Windows.Forms.TrackBar();
            this.valMaxLbl = new System.Windows.Forms.Label();
            this.hueMaxLbl = new System.Windows.Forms.Label();
            this.satMaxLbl = new System.Windows.Forms.Label();
            this.minColorsGrBx = new System.Windows.Forms.GroupBox();
            this.satMinBar = new System.Windows.Forms.TrackBar();
            this.hueMinBar = new System.Windows.Forms.TrackBar();
            this.valMinBar = new System.Windows.Forms.TrackBar();
            this.valMinLbl = new System.Windows.Forms.Label();
            this.hueMinLbl = new System.Windows.Forms.Label();
            this.satMinLbl = new System.Windows.Forms.Label();
            this.erDilGrBx = new System.Windows.Forms.GroupBox();
            this.erodeNmBx = new System.Windows.Forms.NumericUpDown();
            this.dilateNmBx = new System.Windows.Forms.NumericUpDown();
            this.dilateChkBx = new System.Windows.Forms.CheckBox();
            this.erodeChkBx = new System.Windows.Forms.CheckBox();
            this.filterGrBx = new System.Windows.Forms.GroupBox();
            this.colorRangeRadio = new System.Windows.Forms.RadioButton();
            this.bgrRadio = new System.Windows.Forms.RadioButton();
            this.grayRadio = new System.Windows.Forms.RadioButton();
            this.hsvRadio = new System.Windows.Forms.RadioButton();
            this.cannyRadio = new System.Windows.Forms.RadioButton();
            this.viewPg = new System.Windows.Forms.TabPage();
            this.ShapeLbl = new System.Windows.Forms.Label();
            this.filterLbl = new System.Windows.Forms.Label();
            this.grayLbl = new System.Windows.Forms.Label();
            this.cannyLbl = new System.Windows.Forms.Label();
            this.hsvLbl = new System.Windows.Forms.Label();
            this.originalLbl = new System.Windows.Forms.Label();
            this.grayImgBx = new Emgu.CV.UI.ImageBox();
            this.shapeImgBx = new Emgu.CV.UI.ImageBox();
            this.filterImgBx = new Emgu.CV.UI.ImageBox();
            this.cannyImgBx = new Emgu.CV.UI.ImageBox();
            this.hsvImgBx = new Emgu.CV.UI.ImageBox();
            this.originalImgBx = new Emgu.CV.UI.ImageBox();
            this.tabControl1.SuspendLayout();
            this.settingsPg.SuspendLayout();
            this.saveGrBx.SuspendLayout();
            this.thresholdGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxThreshBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minThreshBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImgBx)).BeginInit();
            this.maxColorsGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxBar)).BeginInit();
            this.minColorsGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMinBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinBar)).BeginInit();
            this.erDilGrBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNmBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilateNmBx)).BeginInit();
            this.filterGrBx.SuspendLayout();
            this.viewPg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImgBx)).BeginInit();
            this.SuspendLayout();
            // 
            // portsCmbx
            // 
            this.portsCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsCmbx.FormattingEnabled = true;
            this.portsCmbx.Location = new System.Drawing.Point(49, 22);
            this.portsCmbx.Name = "portsCmbx";
            this.portsCmbx.Size = new System.Drawing.Size(121, 21);
            this.portsCmbx.TabIndex = 0;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(8, 25);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(35, 13);
            this.portLbl.TabIndex = 1;
            this.portLbl.Text = "Poort:";
            // 
            // baudrateLbl
            // 
            this.baudrateLbl.AutoSize = true;
            this.baudrateLbl.Location = new System.Drawing.Point(239, 22);
            this.baudrateLbl.Name = "baudrateLbl";
            this.baudrateLbl.Size = new System.Drawing.Size(53, 13);
            this.baudrateLbl.TabIndex = 2;
            this.baudrateLbl.Text = "Baudrate:";
            // 
            // baudrateCmbx
            // 
            this.baudrateCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudrateCmbx.FormattingEnabled = true;
            this.baudrateCmbx.Items.AddRange(new object[] {
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
            this.baudrateCmbx.Location = new System.Drawing.Point(298, 22);
            this.baudrateCmbx.Name = "baudrateCmbx";
            this.baudrateCmbx.Size = new System.Drawing.Size(121, 21);
            this.baudrateCmbx.TabIndex = 0;
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(1190, 659);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(75, 23);
            this.startBttn.TabIndex = 3;
            this.startBttn.Text = "Start";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.startBttn_Click);
            // 
            // stopBttn
            // 
            this.stopBttn.Location = new System.Drawing.Point(1271, 659);
            this.stopBttn.Name = "stopBttn";
            this.stopBttn.Size = new System.Drawing.Size(75, 23);
            this.stopBttn.TabIndex = 4;
            this.stopBttn.Text = "Stop";
            this.stopBttn.UseVisualStyleBackColor = true;
            this.stopBttn.Click += new System.EventHandler(this.stopBttn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.settingsPg);
            this.tabControl1.Controls.Add(this.viewPg);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1338, 641);
            this.tabControl1.TabIndex = 5;
            // 
            // settingsPg
            // 
            this.settingsPg.BackColor = System.Drawing.Color.Transparent;
            this.settingsPg.Controls.Add(this.saveGrBx);
            this.settingsPg.Controls.Add(this.thresholdGrBx);
            this.settingsPg.Controls.Add(this.previewLbl);
            this.settingsPg.Controls.Add(this.previewImgBx);
            this.settingsPg.Controls.Add(this.baudrateCmbx);
            this.settingsPg.Controls.Add(this.portLbl);
            this.settingsPg.Controls.Add(this.portsCmbx);
            this.settingsPg.Controls.Add(this.baudrateLbl);
            this.settingsPg.Controls.Add(this.maxColorsGrBx);
            this.settingsPg.Controls.Add(this.minColorsGrBx);
            this.settingsPg.Controls.Add(this.erDilGrBx);
            this.settingsPg.Controls.Add(this.filterGrBx);
            this.settingsPg.Location = new System.Drawing.Point(4, 25);
            this.settingsPg.Name = "settingsPg";
            this.settingsPg.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPg.Size = new System.Drawing.Size(1330, 612);
            this.settingsPg.TabIndex = 0;
            this.settingsPg.Text = "Settings";
            // 
            // saveGrBx
            // 
            this.saveGrBx.Controls.Add(this.saveBttn);
            this.saveGrBx.Controls.Add(this.loadFileBttn);
            this.saveGrBx.Controls.Add(this.savePathBttn);
            this.saveGrBx.Controls.Add(this.label2);
            this.saveGrBx.Controls.Add(this.pathLbl);
            this.saveGrBx.Controls.Add(this.loadTxtBx);
            this.saveGrBx.Controls.Add(this.savePathTxtBx);
            this.saveGrBx.Location = new System.Drawing.Point(367, 282);
            this.saveGrBx.Name = "saveGrBx";
            this.saveGrBx.Size = new System.Drawing.Size(432, 324);
            this.saveGrBx.TabIndex = 13;
            this.saveGrBx.TabStop = false;
            this.saveGrBx.Text = "Save/Load";
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(351, 290);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(75, 23);
            this.saveBttn.TabIndex = 5;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // loadFileBttn
            // 
            this.loadFileBttn.Location = new System.Drawing.Point(393, 108);
            this.loadFileBttn.Name = "loadFileBttn";
            this.loadFileBttn.Size = new System.Drawing.Size(33, 20);
            this.loadFileBttn.TabIndex = 2;
            this.loadFileBttn.Text = "...";
            this.loadFileBttn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadFileBttn.UseVisualStyleBackColor = true;
            this.loadFileBttn.Click += new System.EventHandler(this.loadFileBttn_Click);
            // 
            // savePathBttn
            // 
            this.savePathBttn.Location = new System.Drawing.Point(393, 44);
            this.savePathBttn.Name = "savePathBttn";
            this.savePathBttn.Size = new System.Drawing.Size(33, 20);
            this.savePathBttn.TabIndex = 2;
            this.savePathBttn.Text = "...";
            this.savePathBttn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.savePathBttn.UseVisualStyleBackColor = true;
            this.savePathBttn.Click += new System.EventHandler(this.savePathBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load from file:";
            // 
            // pathLbl
            // 
            this.pathLbl.AutoSize = true;
            this.pathLbl.Location = new System.Drawing.Point(7, 28);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(59, 13);
            this.pathLbl.TabIndex = 1;
            this.pathLbl.Text = "Save path:";
            // 
            // loadTxtBx
            // 
            this.loadTxtBx.Location = new System.Drawing.Point(9, 108);
            this.loadTxtBx.Name = "loadTxtBx";
            this.loadTxtBx.Size = new System.Drawing.Size(378, 20);
            this.loadTxtBx.TabIndex = 0;
            // 
            // savePathTxtBx
            // 
            this.savePathTxtBx.Location = new System.Drawing.Point(9, 44);
            this.savePathTxtBx.Name = "savePathTxtBx";
            this.savePathTxtBx.Size = new System.Drawing.Size(378, 20);
            this.savePathTxtBx.TabIndex = 0;
            // 
            // thresholdGrBx
            // 
            this.thresholdGrBx.Controls.Add(this.maxThreshBar);
            this.thresholdGrBx.Controls.Add(this.minThreshBar);
            this.thresholdGrBx.Controls.Add(this.maxThreshLbl);
            this.thresholdGrBx.Controls.Add(this.minThreshLbl);
            this.thresholdGrBx.Location = new System.Drawing.Point(367, 85);
            this.thresholdGrBx.Name = "thresholdGrBx";
            this.thresholdGrBx.Size = new System.Drawing.Size(432, 164);
            this.thresholdGrBx.TabIndex = 12;
            this.thresholdGrBx.TabStop = false;
            this.thresholdGrBx.Text = "Thresholds";
            this.thresholdGrBx.Visible = false;
            // 
            // maxThreshBar
            // 
            this.maxThreshBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxThreshBar.Location = new System.Drawing.Point(68, 91);
            this.maxThreshBar.Maximum = 255;
            this.maxThreshBar.Minimum = 1;
            this.maxThreshBar.Name = "maxThreshBar";
            this.maxThreshBar.Size = new System.Drawing.Size(358, 45);
            this.maxThreshBar.TabIndex = 1;
            this.maxThreshBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.maxThreshBar.Value = 255;
            this.maxThreshBar.Scroll += new System.EventHandler(this.minThreshBar_Scroll);
            // 
            // minThreshBar
            // 
            this.minThreshBar.Location = new System.Drawing.Point(68, 31);
            this.minThreshBar.Maximum = 255;
            this.minThreshBar.Minimum = 1;
            this.minThreshBar.Name = "minThreshBar";
            this.minThreshBar.Size = new System.Drawing.Size(358, 45);
            this.minThreshBar.TabIndex = 1;
            this.minThreshBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.minThreshBar.Value = 1;
            this.minThreshBar.Scroll += new System.EventHandler(this.minThreshBar_Scroll);
            // 
            // maxThreshLbl
            // 
            this.maxThreshLbl.AutoSize = true;
            this.maxThreshLbl.Location = new System.Drawing.Point(6, 91);
            this.maxThreshLbl.Name = "maxThreshLbl";
            this.maxThreshLbl.Size = new System.Drawing.Size(59, 26);
            this.maxThreshLbl.TabIndex = 0;
            this.maxThreshLbl.Text = "Max value:\r\n255";
            // 
            // minThreshLbl
            // 
            this.minThreshLbl.AutoSize = true;
            this.minThreshLbl.Location = new System.Drawing.Point(9, 31);
            this.minThreshLbl.Name = "minThreshLbl";
            this.minThreshLbl.Size = new System.Drawing.Size(56, 26);
            this.minThreshLbl.TabIndex = 0;
            this.minThreshLbl.Text = "Min value:\r\n1";
            // 
            // previewLbl
            // 
            this.previewLbl.AutoSize = true;
            this.previewLbl.Location = new System.Drawing.Point(805, 85);
            this.previewLbl.Name = "previewLbl";
            this.previewLbl.Size = new System.Drawing.Size(48, 13);
            this.previewLbl.TabIndex = 5;
            this.previewLbl.Text = "Preview:";
            // 
            // previewImgBx
            // 
            this.previewImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewImgBx.Location = new System.Drawing.Point(805, 114);
            this.previewImgBx.Name = "previewImgBx";
            this.previewImgBx.Size = new System.Drawing.Size(519, 492);
            this.previewImgBx.TabIndex = 2;
            this.previewImgBx.TabStop = false;
            // 
            // maxColorsGrBx
            // 
            this.maxColorsGrBx.BackColor = System.Drawing.Color.Transparent;
            this.maxColorsGrBx.Controls.Add(this.satMaxBar);
            this.maxColorsGrBx.Controls.Add(this.hueMaxBar);
            this.maxColorsGrBx.Controls.Add(this.valMaxBar);
            this.maxColorsGrBx.Controls.Add(this.valMaxLbl);
            this.maxColorsGrBx.Controls.Add(this.hueMaxLbl);
            this.maxColorsGrBx.Controls.Add(this.satMaxLbl);
            this.maxColorsGrBx.Location = new System.Drawing.Point(187, 282);
            this.maxColorsGrBx.Name = "maxColorsGrBx";
            this.maxColorsGrBx.Size = new System.Drawing.Size(173, 324);
            this.maxColorsGrBx.TabIndex = 6;
            this.maxColorsGrBx.TabStop = false;
            this.maxColorsGrBx.Text = "Max Colors";
            // 
            // satMaxBar
            // 
            this.satMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.satMaxBar.Location = new System.Drawing.Point(47, 17);
            this.satMaxBar.Maximum = 255;
            this.satMaxBar.Name = "satMaxBar";
            this.satMaxBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.satMaxBar.Size = new System.Drawing.Size(45, 275);
            this.satMaxBar.TabIndex = 3;
            this.satMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.satMaxBar.Value = 255;
            this.satMaxBar.Scroll += new System.EventHandler(this.satBar_Scroll);
            // 
            // hueMaxBar
            // 
            this.hueMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.hueMaxBar.Location = new System.Drawing.Point(9, 17);
            this.hueMaxBar.Maximum = 255;
            this.hueMaxBar.Name = "hueMaxBar";
            this.hueMaxBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.hueMaxBar.Size = new System.Drawing.Size(45, 275);
            this.hueMaxBar.TabIndex = 3;
            this.hueMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hueMaxBar.Value = 255;
            this.hueMaxBar.Scroll += new System.EventHandler(this.hueBar_Scroll);
            // 
            // valMaxBar
            // 
            this.valMaxBar.BackColor = System.Drawing.SystemColors.Control;
            this.valMaxBar.Location = new System.Drawing.Point(90, 17);
            this.valMaxBar.Maximum = 255;
            this.valMaxBar.Name = "valMaxBar";
            this.valMaxBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.valMaxBar.Size = new System.Drawing.Size(45, 275);
            this.valMaxBar.TabIndex = 3;
            this.valMaxBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valMaxBar.Value = 255;
            this.valMaxBar.Scroll += new System.EventHandler(this.valBar_Scroll);
            // 
            // valMaxLbl
            // 
            this.valMaxLbl.AutoSize = true;
            this.valMaxLbl.Location = new System.Drawing.Point(82, 295);
            this.valMaxLbl.Name = "valMaxLbl";
            this.valMaxLbl.Size = new System.Drawing.Size(29, 26);
            this.valMaxLbl.TabIndex = 4;
            this.valMaxLbl.Text = "Val:\r\n255°";
            // 
            // hueMaxLbl
            // 
            this.hueMaxLbl.AutoSize = true;
            this.hueMaxLbl.Location = new System.Drawing.Point(6, 295);
            this.hueMaxLbl.Name = "hueMaxLbl";
            this.hueMaxLbl.Size = new System.Drawing.Size(30, 26);
            this.hueMaxLbl.TabIndex = 4;
            this.hueMaxLbl.Text = "Hue:\r\n255°";
            // 
            // satMaxLbl
            // 
            this.satMaxLbl.AutoSize = true;
            this.satMaxLbl.Location = new System.Drawing.Point(44, 295);
            this.satMaxLbl.Name = "satMaxLbl";
            this.satMaxLbl.Size = new System.Drawing.Size(29, 26);
            this.satMaxLbl.TabIndex = 4;
            this.satMaxLbl.Text = "Sat:\r\n255°";
            // 
            // minColorsGrBx
            // 
            this.minColorsGrBx.BackColor = System.Drawing.Color.Transparent;
            this.minColorsGrBx.Controls.Add(this.satMinBar);
            this.minColorsGrBx.Controls.Add(this.hueMinBar);
            this.minColorsGrBx.Controls.Add(this.valMinBar);
            this.minColorsGrBx.Controls.Add(this.valMinLbl);
            this.minColorsGrBx.Controls.Add(this.hueMinLbl);
            this.minColorsGrBx.Controls.Add(this.satMinLbl);
            this.minColorsGrBx.Location = new System.Drawing.Point(6, 282);
            this.minColorsGrBx.Name = "minColorsGrBx";
            this.minColorsGrBx.Size = new System.Drawing.Size(173, 324);
            this.minColorsGrBx.TabIndex = 6;
            this.minColorsGrBx.TabStop = false;
            this.minColorsGrBx.Text = "Min Colors";
            // 
            // satMinBar
            // 
            this.satMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.satMinBar.Location = new System.Drawing.Point(47, 17);
            this.satMinBar.Maximum = 255;
            this.satMinBar.Name = "satMinBar";
            this.satMinBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.satMinBar.Size = new System.Drawing.Size(45, 275);
            this.satMinBar.TabIndex = 3;
            this.satMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.satMinBar.Scroll += new System.EventHandler(this.satBar_Scroll);
            // 
            // hueMinBar
            // 
            this.hueMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.hueMinBar.Location = new System.Drawing.Point(9, 17);
            this.hueMinBar.Maximum = 255;
            this.hueMinBar.Name = "hueMinBar";
            this.hueMinBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.hueMinBar.Size = new System.Drawing.Size(45, 275);
            this.hueMinBar.TabIndex = 3;
            this.hueMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hueMinBar.Scroll += new System.EventHandler(this.hueBar_Scroll);
            // 
            // valMinBar
            // 
            this.valMinBar.BackColor = System.Drawing.SystemColors.Control;
            this.valMinBar.Location = new System.Drawing.Point(90, 17);
            this.valMinBar.Maximum = 255;
            this.valMinBar.Name = "valMinBar";
            this.valMinBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.valMinBar.Size = new System.Drawing.Size(45, 275);
            this.valMinBar.TabIndex = 3;
            this.valMinBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valMinBar.Scroll += new System.EventHandler(this.valBar_Scroll);
            // 
            // valMinLbl
            // 
            this.valMinLbl.AutoSize = true;
            this.valMinLbl.Location = new System.Drawing.Point(82, 295);
            this.valMinLbl.Name = "valMinLbl";
            this.valMinLbl.Size = new System.Drawing.Size(25, 26);
            this.valMinLbl.TabIndex = 4;
            this.valMinLbl.Text = "Val:\r\n0°";
            // 
            // hueMinLbl
            // 
            this.hueMinLbl.AutoSize = true;
            this.hueMinLbl.Location = new System.Drawing.Point(6, 295);
            this.hueMinLbl.Name = "hueMinLbl";
            this.hueMinLbl.Size = new System.Drawing.Size(30, 26);
            this.hueMinLbl.TabIndex = 4;
            this.hueMinLbl.Text = "Hue:\r\n0°";
            // 
            // satMinLbl
            // 
            this.satMinLbl.AutoSize = true;
            this.satMinLbl.Location = new System.Drawing.Point(44, 295);
            this.satMinLbl.Name = "satMinLbl";
            this.satMinLbl.Size = new System.Drawing.Size(26, 26);
            this.satMinLbl.TabIndex = 4;
            this.satMinLbl.Text = "Sat:\r\n0°";
            // 
            // erDilGrBx
            // 
            this.erDilGrBx.Controls.Add(this.erodeNmBx);
            this.erDilGrBx.Controls.Add(this.dilateNmBx);
            this.erDilGrBx.Controls.Add(this.dilateChkBx);
            this.erDilGrBx.Controls.Add(this.erodeChkBx);
            this.erDilGrBx.Location = new System.Drawing.Point(6, 176);
            this.erDilGrBx.Name = "erDilGrBx";
            this.erDilGrBx.Size = new System.Drawing.Size(354, 73);
            this.erDilGrBx.TabIndex = 10;
            this.erDilGrBx.TabStop = false;
            this.erDilGrBx.Text = "Erode/Dilate";
            // 
            // erodeNmBx
            // 
            this.erodeNmBx.Enabled = false;
            this.erodeNmBx.Location = new System.Drawing.Point(292, 26);
            this.erodeNmBx.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.erodeNmBx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.erodeNmBx.Name = "erodeNmBx";
            this.erodeNmBx.Size = new System.Drawing.Size(56, 20);
            this.erodeNmBx.TabIndex = 9;
            this.erodeNmBx.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dilateNmBx
            // 
            this.dilateNmBx.Enabled = false;
            this.dilateNmBx.Location = new System.Drawing.Point(292, 49);
            this.dilateNmBx.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.dilateNmBx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dilateNmBx.Name = "dilateNmBx";
            this.dilateNmBx.Size = new System.Drawing.Size(56, 20);
            this.dilateNmBx.TabIndex = 9;
            this.dilateNmBx.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // dilateChkBx
            // 
            this.dilateChkBx.AutoSize = true;
            this.dilateChkBx.Location = new System.Drawing.Point(7, 50);
            this.dilateChkBx.Name = "dilateChkBx";
            this.dilateChkBx.Size = new System.Drawing.Size(53, 17);
            this.dilateChkBx.TabIndex = 8;
            this.dilateChkBx.Text = "Dilate";
            this.dilateChkBx.UseVisualStyleBackColor = true;
            this.dilateChkBx.CheckedChanged += new System.EventHandler(this.dilateChkBx_CheckedChanged);
            // 
            // erodeChkBx
            // 
            this.erodeChkBx.AutoSize = true;
            this.erodeChkBx.Location = new System.Drawing.Point(7, 26);
            this.erodeChkBx.Name = "erodeChkBx";
            this.erodeChkBx.Size = new System.Drawing.Size(54, 17);
            this.erodeChkBx.TabIndex = 8;
            this.erodeChkBx.Text = "Erode";
            this.erodeChkBx.UseVisualStyleBackColor = true;
            this.erodeChkBx.CheckedChanged += new System.EventHandler(this.erodeChkBx_CheckedChanged);
            // 
            // filterGrBx
            // 
            this.filterGrBx.Controls.Add(this.colorRangeRadio);
            this.filterGrBx.Controls.Add(this.bgrRadio);
            this.filterGrBx.Controls.Add(this.grayRadio);
            this.filterGrBx.Controls.Add(this.hsvRadio);
            this.filterGrBx.Controls.Add(this.cannyRadio);
            this.filterGrBx.Location = new System.Drawing.Point(6, 85);
            this.filterGrBx.Name = "filterGrBx";
            this.filterGrBx.Size = new System.Drawing.Size(354, 85);
            this.filterGrBx.TabIndex = 11;
            this.filterGrBx.TabStop = false;
            this.filterGrBx.Text = "Filters";
            // 
            // colorRangeRadio
            // 
            this.colorRangeRadio.AutoSize = true;
            this.colorRangeRadio.Location = new System.Drawing.Point(9, 52);
            this.colorRangeRadio.Name = "colorRangeRadio";
            this.colorRangeRadio.Size = new System.Drawing.Size(79, 17);
            this.colorRangeRadio.TabIndex = 7;
            this.colorRangeRadio.Text = "Color range";
            this.colorRangeRadio.UseVisualStyleBackColor = true;
            // 
            // bgrRadio
            // 
            this.bgrRadio.AutoSize = true;
            this.bgrRadio.Checked = true;
            this.bgrRadio.Location = new System.Drawing.Point(9, 29);
            this.bgrRadio.Name = "bgrRadio";
            this.bgrRadio.Size = new System.Drawing.Size(41, 17);
            this.bgrRadio.TabIndex = 7;
            this.bgrRadio.TabStop = true;
            this.bgrRadio.Text = "Bgr";
            this.bgrRadio.UseVisualStyleBackColor = true;
            // 
            // grayRadio
            // 
            this.grayRadio.AutoSize = true;
            this.grayRadio.Location = new System.Drawing.Point(162, 29);
            this.grayRadio.Name = "grayRadio";
            this.grayRadio.Size = new System.Drawing.Size(47, 17);
            this.grayRadio.TabIndex = 7;
            this.grayRadio.Text = "Gray";
            this.grayRadio.UseVisualStyleBackColor = true;
            // 
            // hsvRadio
            // 
            this.hsvRadio.AutoSize = true;
            this.hsvRadio.Location = new System.Drawing.Point(91, 29);
            this.hsvRadio.Name = "hsvRadio";
            this.hsvRadio.Size = new System.Drawing.Size(44, 17);
            this.hsvRadio.TabIndex = 7;
            this.hsvRadio.Text = "Hsv";
            this.hsvRadio.UseVisualStyleBackColor = true;
            // 
            // cannyRadio
            // 
            this.cannyRadio.AutoSize = true;
            this.cannyRadio.Location = new System.Drawing.Point(91, 52);
            this.cannyRadio.Name = "cannyRadio";
            this.cannyRadio.Size = new System.Drawing.Size(55, 17);
            this.cannyRadio.TabIndex = 7;
            this.cannyRadio.Text = "Canny";
            this.cannyRadio.UseVisualStyleBackColor = true;
            this.cannyRadio.CheckedChanged += new System.EventHandler(this.cannyRadio_CheckedChanged);
            // 
            // viewPg
            // 
            this.viewPg.BackColor = System.Drawing.Color.Transparent;
            this.viewPg.Controls.Add(this.ShapeLbl);
            this.viewPg.Controls.Add(this.filterLbl);
            this.viewPg.Controls.Add(this.grayLbl);
            this.viewPg.Controls.Add(this.cannyLbl);
            this.viewPg.Controls.Add(this.hsvLbl);
            this.viewPg.Controls.Add(this.originalLbl);
            this.viewPg.Controls.Add(this.grayImgBx);
            this.viewPg.Controls.Add(this.shapeImgBx);
            this.viewPg.Controls.Add(this.filterImgBx);
            this.viewPg.Controls.Add(this.cannyImgBx);
            this.viewPg.Controls.Add(this.hsvImgBx);
            this.viewPg.Controls.Add(this.originalImgBx);
            this.viewPg.Location = new System.Drawing.Point(4, 25);
            this.viewPg.Name = "viewPg";
            this.viewPg.Padding = new System.Windows.Forms.Padding(3);
            this.viewPg.Size = new System.Drawing.Size(1330, 612);
            this.viewPg.TabIndex = 1;
            this.viewPg.Text = "View";
            // 
            // ShapeLbl
            // 
            this.ShapeLbl.AutoSize = true;
            this.ShapeLbl.Location = new System.Drawing.Point(832, 9);
            this.ShapeLbl.Name = "ShapeLbl";
            this.ShapeLbl.Size = new System.Drawing.Size(46, 13);
            this.ShapeLbl.TabIndex = 4;
            this.ShapeLbl.Text = "Shapes:";
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Location = new System.Drawing.Point(350, 9);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(32, 13);
            this.filterLbl.TabIndex = 4;
            this.filterLbl.Text = "Filter:";
            // 
            // grayLbl
            // 
            this.grayLbl.AutoSize = true;
            this.grayLbl.Location = new System.Drawing.Point(930, 287);
            this.grayLbl.Name = "grayLbl";
            this.grayLbl.Size = new System.Drawing.Size(32, 13);
            this.grayLbl.TabIndex = 4;
            this.grayLbl.Text = "Gray:";
            // 
            // cannyLbl
            // 
            this.cannyLbl.AutoSize = true;
            this.cannyLbl.Location = new System.Drawing.Point(566, 287);
            this.cannyLbl.Name = "cannyLbl";
            this.cannyLbl.Size = new System.Drawing.Size(40, 13);
            this.cannyLbl.TabIndex = 4;
            this.cannyLbl.Text = "Canny:";
            // 
            // hsvLbl
            // 
            this.hsvLbl.AutoSize = true;
            this.hsvLbl.Location = new System.Drawing.Point(3, 287);
            this.hsvLbl.Name = "hsvLbl";
            this.hsvLbl.Size = new System.Drawing.Size(29, 13);
            this.hsvLbl.TabIndex = 4;
            this.hsvLbl.Text = "Hsv:";
            // 
            // originalLbl
            // 
            this.originalLbl.AutoSize = true;
            this.originalLbl.Location = new System.Drawing.Point(3, 9);
            this.originalLbl.Name = "originalLbl";
            this.originalLbl.Size = new System.Drawing.Size(45, 13);
            this.originalLbl.TabIndex = 4;
            this.originalLbl.Text = "Original:";
            // 
            // grayImgBx
            // 
            this.grayImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayImgBx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.grayImgBx.Location = new System.Drawing.Point(933, 303);
            this.grayImgBx.Name = "grayImgBx";
            this.grayImgBx.Size = new System.Drawing.Size(391, 301);
            this.grayImgBx.TabIndex = 2;
            this.grayImgBx.TabStop = false;
            // 
            // shapeImgBx
            // 
            this.shapeImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapeImgBx.Location = new System.Drawing.Point(835, 25);
            this.shapeImgBx.Name = "shapeImgBx";
            this.shapeImgBx.Size = new System.Drawing.Size(489, 259);
            this.shapeImgBx.TabIndex = 3;
            this.shapeImgBx.TabStop = false;
            // 
            // filterImgBx
            // 
            this.filterImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterImgBx.Location = new System.Drawing.Point(353, 25);
            this.filterImgBx.Name = "filterImgBx";
            this.filterImgBx.Size = new System.Drawing.Size(476, 259);
            this.filterImgBx.TabIndex = 3;
            this.filterImgBx.TabStop = false;
            // 
            // cannyImgBx
            // 
            this.cannyImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cannyImgBx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.cannyImgBx.Location = new System.Drawing.Point(569, 303);
            this.cannyImgBx.Name = "cannyImgBx";
            this.cannyImgBx.Size = new System.Drawing.Size(358, 301);
            this.cannyImgBx.TabIndex = 2;
            this.cannyImgBx.TabStop = false;
            // 
            // hsvImgBx
            // 
            this.hsvImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hsvImgBx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.hsvImgBx.Location = new System.Drawing.Point(6, 303);
            this.hsvImgBx.Name = "hsvImgBx";
            this.hsvImgBx.Size = new System.Drawing.Size(557, 301);
            this.hsvImgBx.TabIndex = 2;
            this.hsvImgBx.TabStop = false;
            // 
            // originalImgBx
            // 
            this.originalImgBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImgBx.Cursor = System.Windows.Forms.Cursors.Cross;
            this.originalImgBx.Location = new System.Drawing.Point(6, 25);
            this.originalImgBx.Name = "originalImgBx";
            this.originalImgBx.Size = new System.Drawing.Size(341, 259);
            this.originalImgBx.TabIndex = 2;
            this.originalImgBx.TabStop = false;
            // 
            // SerialPortTestfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 694);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.stopBttn);
            this.Controls.Add(this.startBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SerialPortTestfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Communication";
            this.tabControl1.ResumeLayout(false);
            this.settingsPg.ResumeLayout(false);
            this.settingsPg.PerformLayout();
            this.saveGrBx.ResumeLayout(false);
            this.saveGrBx.PerformLayout();
            this.thresholdGrBx.ResumeLayout(false);
            this.thresholdGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxThreshBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minThreshBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewImgBx)).EndInit();
            this.maxColorsGrBx.ResumeLayout(false);
            this.maxColorsGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMaxBar)).EndInit();
            this.minColorsGrBx.ResumeLayout(false);
            this.minColorsGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satMinBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueMinBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valMinBar)).EndInit();
            this.erDilGrBx.ResumeLayout(false);
            this.erDilGrBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erodeNmBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilateNmBx)).EndInit();
            this.filterGrBx.ResumeLayout(false);
            this.filterGrBx.PerformLayout();
            this.viewPg.ResumeLayout(false);
            this.viewPg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grayImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsvImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImgBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox portsCmbx;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label baudrateLbl;
        private System.Windows.Forms.ComboBox baudrateCmbx;
        private System.Windows.Forms.Button startBttn;
        private System.Windows.Forms.Button stopBttn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settingsPg;
        private System.Windows.Forms.TabPage viewPg;
        private System.Windows.Forms.TrackBar hueMinBar;
        private System.Windows.Forms.TrackBar valMinBar;
        private System.Windows.Forms.TrackBar satMinBar;
        private System.Windows.Forms.Label valMinLbl;
        private System.Windows.Forms.Label satMinLbl;
        private System.Windows.Forms.Label hueMinLbl;
        private System.Windows.Forms.Label previewLbl;
        private Emgu.CV.UI.ImageBox previewImgBx;
        private Emgu.CV.UI.ImageBox filterImgBx;
        private Emgu.CV.UI.ImageBox originalImgBx;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label originalLbl;
        private System.Windows.Forms.GroupBox maxColorsGrBx;
        private System.Windows.Forms.TrackBar satMaxBar;
        private System.Windows.Forms.TrackBar hueMaxBar;
        private System.Windows.Forms.TrackBar valMaxBar;
        private System.Windows.Forms.Label valMaxLbl;
        private System.Windows.Forms.Label hueMaxLbl;
        private System.Windows.Forms.Label satMaxLbl;
        private System.Windows.Forms.GroupBox minColorsGrBx;
        private System.Windows.Forms.RadioButton colorRangeRadio;
        private System.Windows.Forms.RadioButton hsvRadio;
        private System.Windows.Forms.RadioButton bgrRadio;
        private System.Windows.Forms.Label hsvLbl;
        private Emgu.CV.UI.ImageBox hsvImgBx;
        private System.Windows.Forms.CheckBox dilateChkBx;
        private System.Windows.Forms.CheckBox erodeChkBx;
        private System.Windows.Forms.GroupBox erDilGrBx;
        private System.Windows.Forms.NumericUpDown erodeNmBx;
        private System.Windows.Forms.NumericUpDown dilateNmBx;
        private System.Windows.Forms.RadioButton grayRadio;
        private System.Windows.Forms.RadioButton cannyRadio;
        private System.Windows.Forms.Label cannyLbl;
        private Emgu.CV.UI.ImageBox cannyImgBx;
        private System.Windows.Forms.Label grayLbl;
        private Emgu.CV.UI.ImageBox grayImgBx;
        private System.Windows.Forms.Label ShapeLbl;
        private Emgu.CV.UI.ImageBox shapeImgBx;
        private System.Windows.Forms.GroupBox filterGrBx;
        private System.Windows.Forms.GroupBox thresholdGrBx;
        private System.Windows.Forms.TrackBar maxThreshBar;
        private System.Windows.Forms.TrackBar minThreshBar;
        private System.Windows.Forms.Label maxThreshLbl;
        private System.Windows.Forms.Label minThreshLbl;
        private System.Windows.Forms.GroupBox saveGrBx;
        private System.Windows.Forms.Button savePathBttn;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.TextBox savePathTxtBx;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.Button loadFileBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loadTxtBx;
    }
}

