
namespace CSInternal
{
    partial class SetupSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupSettingsForm));
            this.grpIMU = new System.Windows.Forms.GroupBox();
            this.grpAntiAliasing = new System.Windows.Forms.GroupBox();
            this.chkAutoAntiAliasing = new System.Windows.Forms.CheckBox();
            this.cmbAntiAliasingBW = new System.Windows.Forms.ComboBox();
            this.lblAntiAliasingBW = new System.Windows.Forms.Label();
            this.cmbAccelODR = new System.Windows.Forms.ComboBox();
            this.cmbAccelRange = new System.Windows.Forms.ComboBox();
            this.cmbGyroODR = new System.Windows.Forms.ComboBox();
            this.cmbGyroRange = new System.Windows.Forms.ComboBox();
            this.grpAccelOffset = new System.Windows.Forms.GroupBox();
            this.numAccelOffsetZ = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numAccelOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numAccelOffsetY = new System.Windows.Forms.NumericUpDown();
            this.grpGyroOffset = new System.Windows.Forms.GroupBox();
            this.numGyroOffsetZ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numGyroOffsetY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numGyroOffsetX = new System.Windows.Forms.NumericUpDown();
            this.lblAccelODR = new System.Windows.Forms.Label();
            this.lblGyroODR = new System.Windows.Forms.Label();
            this.lblAccelOffset = new System.Windows.Forms.Label();
            this.lblGyroRange = new System.Windows.Forms.Label();
            this.grpApp = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLocalDataStorage = new System.Windows.Forms.CheckBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtLocalDataStorage = new System.Windows.Forms.TextBox();
            this.grpGoogle = new System.Windows.Forms.GroupBox();
            this.btnSheetsSetup = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.grpPreview = new System.Windows.Forms.GroupBox();
            this.lblPreviewLegth = new System.Windows.Forms.Label();
            this.numPreviewLength = new System.Windows.Forms.NumericUpDown();
            this.grpIMU.SuspendLayout();
            this.grpAntiAliasing.SuspendLayout();
            this.grpAccelOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetY)).BeginInit();
            this.grpGyroOffset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetX)).BeginInit();
            this.grpApp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpGoogle.SuspendLayout();
            this.grpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviewLength)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIMU
            // 
            this.grpIMU.Controls.Add(this.grpAntiAliasing);
            this.grpIMU.Controls.Add(this.cmbAccelODR);
            this.grpIMU.Controls.Add(this.cmbAccelRange);
            this.grpIMU.Controls.Add(this.cmbGyroODR);
            this.grpIMU.Controls.Add(this.cmbGyroRange);
            this.grpIMU.Controls.Add(this.grpAccelOffset);
            this.grpIMU.Controls.Add(this.grpGyroOffset);
            this.grpIMU.Controls.Add(this.lblAccelODR);
            this.grpIMU.Controls.Add(this.lblGyroODR);
            this.grpIMU.Controls.Add(this.lblAccelOffset);
            this.grpIMU.Controls.Add(this.lblGyroRange);
            this.grpIMU.Location = new System.Drawing.Point(12, 12);
            this.grpIMU.Name = "grpIMU";
            this.grpIMU.Size = new System.Drawing.Size(328, 497);
            this.grpIMU.TabIndex = 0;
            this.grpIMU.TabStop = false;
            this.grpIMU.Text = "IMU Settings";
            // 
            // grpAntiAliasing
            // 
            this.grpAntiAliasing.Controls.Add(this.chkAutoAntiAliasing);
            this.grpAntiAliasing.Controls.Add(this.cmbAntiAliasingBW);
            this.grpAntiAliasing.Controls.Add(this.lblAntiAliasingBW);
            this.grpAntiAliasing.Location = new System.Drawing.Point(16, 360);
            this.grpAntiAliasing.Name = "grpAntiAliasing";
            this.grpAntiAliasing.Size = new System.Drawing.Size(298, 107);
            this.grpAntiAliasing.TabIndex = 10;
            this.grpAntiAliasing.TabStop = false;
            this.grpAntiAliasing.Text = "Anti-aliasing";
            // 
            // chkAutoAntiAliasing
            // 
            this.chkAutoAntiAliasing.AutoSize = true;
            this.chkAutoAntiAliasing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoAntiAliasing.Checked = true;
            this.chkAutoAntiAliasing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoAntiAliasing.Location = new System.Drawing.Point(6, 57);
            this.chkAutoAntiAliasing.Name = "chkAutoAntiAliasing";
            this.chkAutoAntiAliasing.Size = new System.Drawing.Size(137, 21);
            this.chkAutoAntiAliasing.TabIndex = 8;
            this.chkAutoAntiAliasing.Text = "Set automatically";
            this.chkAutoAntiAliasing.UseVisualStyleBackColor = true;
            this.chkAutoAntiAliasing.CheckedChanged += new System.EventHandler(this.chkAutoAntiAliasing_CheckedChanged);
            // 
            // cmbAntiAliasingBW
            // 
            this.cmbAntiAliasingBW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAntiAliasingBW.Enabled = false;
            this.cmbAntiAliasingBW.FormattingEnabled = true;
            this.cmbAntiAliasingBW.Location = new System.Drawing.Point(203, 57);
            this.cmbAntiAliasingBW.Name = "cmbAntiAliasingBW";
            this.cmbAntiAliasingBW.Size = new System.Drawing.Size(75, 24);
            this.cmbAntiAliasingBW.TabIndex = 7;
            // 
            // lblAntiAliasingBW
            // 
            this.lblAntiAliasingBW.AutoSize = true;
            this.lblAntiAliasingBW.Location = new System.Drawing.Point(6, 27);
            this.lblAntiAliasingBW.Name = "lblAntiAliasingBW";
            this.lblAntiAliasingBW.Size = new System.Drawing.Size(188, 17);
            this.lblAntiAliasingBW.TabIndex = 6;
            this.lblAntiAliasingBW.Text = "Anti-aliasing filter bandwidth:";
            // 
            // cmbAccelODR
            // 
            this.cmbAccelODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccelODR.FormattingEnabled = true;
            this.cmbAccelODR.Location = new System.Drawing.Point(178, 234);
            this.cmbAccelODR.Name = "cmbAccelODR";
            this.cmbAccelODR.Size = new System.Drawing.Size(136, 24);
            this.cmbAccelODR.TabIndex = 9;
            // 
            // cmbAccelRange
            // 
            this.cmbAccelRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccelRange.FormattingEnabled = true;
            this.cmbAccelRange.Location = new System.Drawing.Point(178, 182);
            this.cmbAccelRange.Name = "cmbAccelRange";
            this.cmbAccelRange.Size = new System.Drawing.Size(136, 24);
            this.cmbAccelRange.TabIndex = 8;
            // 
            // cmbGyroODR
            // 
            this.cmbGyroODR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGyroODR.FormattingEnabled = true;
            this.cmbGyroODR.Location = new System.Drawing.Point(178, 77);
            this.cmbGyroODR.Name = "cmbGyroODR";
            this.cmbGyroODR.Size = new System.Drawing.Size(136, 24);
            this.cmbGyroODR.TabIndex = 7;
            // 
            // cmbGyroRange
            // 
            this.cmbGyroRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGyroRange.FormattingEnabled = true;
            this.cmbGyroRange.Location = new System.Drawing.Point(178, 25);
            this.cmbGyroRange.Name = "cmbGyroRange";
            this.cmbGyroRange.Size = new System.Drawing.Size(136, 24);
            this.cmbGyroRange.TabIndex = 6;
            // 
            // grpAccelOffset
            // 
            this.grpAccelOffset.Controls.Add(this.numAccelOffsetZ);
            this.grpAccelOffset.Controls.Add(this.label8);
            this.grpAccelOffset.Controls.Add(this.numAccelOffsetX);
            this.grpAccelOffset.Controls.Add(this.label7);
            this.grpAccelOffset.Controls.Add(this.label6);
            this.grpAccelOffset.Controls.Add(this.numAccelOffsetY);
            this.grpAccelOffset.Location = new System.Drawing.Point(9, 279);
            this.grpAccelOffset.Name = "grpAccelOffset";
            this.grpAccelOffset.Size = new System.Drawing.Size(305, 57);
            this.grpAccelOffset.TabIndex = 5;
            this.grpAccelOffset.TabStop = false;
            this.grpAccelOffset.Text = "Accelerometer zero offsets";
            // 
            // numAccelOffsetZ
            // 
            this.numAccelOffsetZ.DecimalPlaces = 7;
            this.numAccelOffsetZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAccelOffsetZ.Location = new System.Drawing.Point(239, 25);
            this.numAccelOffsetZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAccelOffsetZ.Name = "numAccelOffsetZ";
            this.numAccelOffsetZ.Size = new System.Drawing.Size(60, 22);
            this.numAccelOffsetZ.TabIndex = 11;
            this.numAccelOffsetZ.ValueChanged += new System.EventHandler(this.numAccelOffsetZ_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "x:";
            // 
            // numAccelOffsetX
            // 
            this.numAccelOffsetX.DecimalPlaces = 7;
            this.numAccelOffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAccelOffsetX.Location = new System.Drawing.Point(37, 25);
            this.numAccelOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAccelOffsetX.Name = "numAccelOffsetX";
            this.numAccelOffsetX.Size = new System.Drawing.Size(60, 22);
            this.numAccelOffsetX.TabIndex = 7;
            this.numAccelOffsetX.ValueChanged += new System.EventHandler(this.numAccelOffsetX_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "z:";
            // 
            // numAccelOffsetY
            // 
            this.numAccelOffsetY.DecimalPlaces = 7;
            this.numAccelOffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numAccelOffsetY.Location = new System.Drawing.Point(141, 25);
            this.numAccelOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numAccelOffsetY.Name = "numAccelOffsetY";
            this.numAccelOffsetY.Size = new System.Drawing.Size(60, 22);
            this.numAccelOffsetY.TabIndex = 9;
            this.numAccelOffsetY.ValueChanged += new System.EventHandler(this.numAccelOffsetY_ValueChanged);
            // 
            // grpGyroOffset
            // 
            this.grpGyroOffset.Controls.Add(this.numGyroOffsetZ);
            this.grpGyroOffset.Controls.Add(this.label5);
            this.grpGyroOffset.Controls.Add(this.numGyroOffsetY);
            this.grpGyroOffset.Controls.Add(this.label4);
            this.grpGyroOffset.Controls.Add(this.label3);
            this.grpGyroOffset.Controls.Add(this.numGyroOffsetX);
            this.grpGyroOffset.Location = new System.Drawing.Point(6, 120);
            this.grpGyroOffset.Name = "grpGyroOffset";
            this.grpGyroOffset.Size = new System.Drawing.Size(308, 57);
            this.grpGyroOffset.TabIndex = 4;
            this.grpGyroOffset.TabStop = false;
            this.grpGyroOffset.Text = "Gyroscope zero offsets";
            // 
            // numGyroOffsetZ
            // 
            this.numGyroOffsetZ.DecimalPlaces = 7;
            this.numGyroOffsetZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGyroOffsetZ.Location = new System.Drawing.Point(242, 21);
            this.numGyroOffsetZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGyroOffsetZ.Name = "numGyroOffsetZ";
            this.numGyroOffsetZ.Size = new System.Drawing.Size(60, 22);
            this.numGyroOffsetZ.TabIndex = 5;
            this.numGyroOffsetZ.ValueChanged += new System.EventHandler(this.numGyroOffsetZ_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "z:";
            // 
            // numGyroOffsetY
            // 
            this.numGyroOffsetY.DecimalPlaces = 7;
            this.numGyroOffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGyroOffsetY.Location = new System.Drawing.Point(144, 21);
            this.numGyroOffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGyroOffsetY.Name = "numGyroOffsetY";
            this.numGyroOffsetY.Size = new System.Drawing.Size(60, 22);
            this.numGyroOffsetY.TabIndex = 3;
            this.numGyroOffsetY.ValueChanged += new System.EventHandler(this.numGyroOffsetY_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "x:";
            // 
            // numGyroOffsetX
            // 
            this.numGyroOffsetX.DecimalPlaces = 7;
            this.numGyroOffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGyroOffsetX.Location = new System.Drawing.Point(40, 21);
            this.numGyroOffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGyroOffsetX.Name = "numGyroOffsetX";
            this.numGyroOffsetX.Size = new System.Drawing.Size(60, 22);
            this.numGyroOffsetX.TabIndex = 1;
            this.numGyroOffsetX.ValueChanged += new System.EventHandler(this.numGyroOffsetX_ValueChanged);
            // 
            // lblAccelODR
            // 
            this.lblAccelODR.AutoSize = true;
            this.lblAccelODR.Location = new System.Drawing.Point(6, 237);
            this.lblAccelODR.Name = "lblAccelODR";
            this.lblAccelODR.Size = new System.Drawing.Size(138, 17);
            this.lblAccelODR.TabIndex = 3;
            this.lblAccelODR.Text = "Accelerometer ODR:";
            // 
            // lblGyroODR
            // 
            this.lblGyroODR.AutoSize = true;
            this.lblGyroODR.Location = new System.Drawing.Point(6, 80);
            this.lblGyroODR.Name = "lblGyroODR";
            this.lblGyroODR.Size = new System.Drawing.Size(116, 17);
            this.lblGyroODR.TabIndex = 2;
            this.lblGyroODR.Text = "Gyroscope ODR:";
            // 
            // lblAccelOffset
            // 
            this.lblAccelOffset.AutoSize = true;
            this.lblAccelOffset.Location = new System.Drawing.Point(6, 185);
            this.lblAccelOffset.Name = "lblAccelOffset";
            this.lblAccelOffset.Size = new System.Drawing.Size(144, 17);
            this.lblAccelOffset.TabIndex = 1;
            this.lblAccelOffset.Text = "Accelerometer range:";
            // 
            // lblGyroRange
            // 
            this.lblGyroRange.AutoSize = true;
            this.lblGyroRange.Location = new System.Drawing.Point(6, 28);
            this.lblGyroRange.Name = "lblGyroRange";
            this.lblGyroRange.Size = new System.Drawing.Size(122, 17);
            this.lblGyroRange.TabIndex = 0;
            this.lblGyroRange.Text = "Gyroscope range:";
            // 
            // grpApp
            // 
            this.grpApp.Controls.Add(this.grpPreview);
            this.grpApp.Controls.Add(this.groupBox1);
            this.grpApp.Controls.Add(this.grpGoogle);
            this.grpApp.Location = new System.Drawing.Point(346, 25);
            this.grpApp.Name = "grpApp";
            this.grpApp.Size = new System.Drawing.Size(294, 278);
            this.grpApp.TabIndex = 2;
            this.grpApp.TabStop = false;
            this.grpApp.Text = "Application settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLocalDataStorage);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.txtLocalDataStorage);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local data storage";
            // 
            // chkLocalDataStorage
            // 
            this.chkLocalDataStorage.AutoSize = true;
            this.chkLocalDataStorage.Checked = true;
            this.chkLocalDataStorage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLocalDataStorage.Location = new System.Drawing.Point(6, 25);
            this.chkLocalDataStorage.Name = "chkLocalDataStorage";
            this.chkLocalDataStorage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkLocalDataStorage.Size = new System.Drawing.Size(148, 21);
            this.chkLocalDataStorage.TabIndex = 2;
            this.chkLocalDataStorage.Text = "Local data storage";
            this.chkLocalDataStorage.UseVisualStyleBackColor = true;
            this.chkLocalDataStorage.CheckedChanged += new System.EventHandler(this.chkLocalDataStorage_CheckedChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(6, 60);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 17);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Path:";
            // 
            // txtLocalDataStorage
            // 
            this.txtLocalDataStorage.Location = new System.Drawing.Point(62, 59);
            this.txtLocalDataStorage.Name = "txtLocalDataStorage";
            this.txtLocalDataStorage.Size = new System.Drawing.Size(205, 22);
            this.txtLocalDataStorage.TabIndex = 0;
            this.txtLocalDataStorage.Click += new System.EventHandler(this.txtLocalDataStorage_Click);
            // 
            // grpGoogle
            // 
            this.grpGoogle.Controls.Add(this.btnSheetsSetup);
            this.grpGoogle.Controls.Add(this.checkBox1);
            this.grpGoogle.Location = new System.Drawing.Point(6, 123);
            this.grpGoogle.Name = "grpGoogle";
            this.grpGoogle.Size = new System.Drawing.Size(273, 66);
            this.grpGoogle.TabIndex = 3;
            this.grpGoogle.TabStop = false;
            this.grpGoogle.Text = "Google integration";
            // 
            // btnSheetsSetup
            // 
            this.btnSheetsSetup.Location = new System.Drawing.Point(9, 65);
            this.btnSheetsSetup.Name = "btnSheetsSetup";
            this.btnSheetsSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSheetsSetup.TabIndex = 7;
            this.btnSheetsSetup.Text = "Set Up";
            this.btnSheetsSetup.UseVisualStyleBackColor = true;
            this.btnSheetsSetup.Click += new System.EventHandler(this.btnSheetsSetup_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(220, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Data storage in google sheets";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(346, 465);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(311, 43);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // grpPreview
            // 
            this.grpPreview.Controls.Add(this.numPreviewLength);
            this.grpPreview.Controls.Add(this.lblPreviewLegth);
            this.grpPreview.Location = new System.Drawing.Point(6, 195);
            this.grpPreview.Name = "grpPreview";
            this.grpPreview.Size = new System.Drawing.Size(273, 65);
            this.grpPreview.TabIndex = 5;
            this.grpPreview.TabStop = false;
            this.grpPreview.Text = "Data visualisation";
            // 
            // lblPreviewLegth
            // 
            this.lblPreviewLegth.AutoSize = true;
            this.lblPreviewLegth.Location = new System.Drawing.Point(6, 33);
            this.lblPreviewLegth.Name = "lblPreviewLegth";
            this.lblPreviewLegth.Size = new System.Drawing.Size(224, 17);
            this.lblPreviewLegth.TabIndex = 0;
            this.lblPreviewLegth.Text = "Data points in side panel graphs:  ";
            // 
            // numPreviewLength
            // 
            this.numPreviewLength.Location = new System.Drawing.Point(228, 33);
            this.numPreviewLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPreviewLength.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPreviewLength.Name = "numPreviewLength";
            this.numPreviewLength.Size = new System.Drawing.Size(45, 22);
            this.numPreviewLength.TabIndex = 1;
            this.numPreviewLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPreviewLength.ValueChanged += new System.EventHandler(this.numPreviewLength_ValueChanged);
            // 
            // SetupSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 520);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.grpApp);
            this.Controls.Add(this.grpIMU);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetupSettingsForm";
            this.Text = "SetupSettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupSettingsForm_FormClosing);
            this.grpIMU.ResumeLayout(false);
            this.grpIMU.PerformLayout();
            this.grpAntiAliasing.ResumeLayout(false);
            this.grpAntiAliasing.PerformLayout();
            this.grpAccelOffset.ResumeLayout(false);
            this.grpAccelOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccelOffsetY)).EndInit();
            this.grpGyroOffset.ResumeLayout(false);
            this.grpGyroOffset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGyroOffsetX)).EndInit();
            this.grpApp.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpGoogle.ResumeLayout(false);
            this.grpGoogle.PerformLayout();
            this.grpPreview.ResumeLayout(false);
            this.grpPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPreviewLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIMU;
        private System.Windows.Forms.GroupBox grpAccelOffset;
        private System.Windows.Forms.GroupBox grpGyroOffset;
        private System.Windows.Forms.NumericUpDown numGyroOffsetY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGyroOffsetX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccelODR;
        private System.Windows.Forms.Label lblGyroODR;
        private System.Windows.Forms.Label lblAccelOffset;
        private System.Windows.Forms.Label lblGyroRange;
        private System.Windows.Forms.GroupBox grpApp;
        private System.Windows.Forms.GroupBox grpGoogle;
        private System.Windows.Forms.ComboBox cmbGyroODR;
        private System.Windows.Forms.ComboBox cmbGyroRange;
        private System.Windows.Forms.NumericUpDown numAccelOffsetZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAccelOffsetX;
        private System.Windows.Forms.NumericUpDown numAccelOffsetY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numGyroOffsetZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccelODR;
        private System.Windows.Forms.ComboBox cmbAccelRange;
        private System.Windows.Forms.GroupBox grpAntiAliasing;
        private System.Windows.Forms.Label lblAntiAliasingBW;
        private System.Windows.Forms.ComboBox cmbAntiAliasingBW;
        private System.Windows.Forms.CheckBox chkAutoAntiAliasing;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.CheckBox chkLocalDataStorage;
        private System.Windows.Forms.TextBox txtLocalDataStorage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSheetsSetup;
        private System.Windows.Forms.GroupBox grpPreview;
        private System.Windows.Forms.NumericUpDown numPreviewLength;
        private System.Windows.Forms.Label lblPreviewLegth;
    }
}