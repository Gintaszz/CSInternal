
namespace CSInternal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReading = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new FontAwesome.Sharp.IconToolStripButton();
            this.btnUpload = new FontAwesome.Sharp.IconToolStripButton();
            this.lblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCtrl = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOut3 = new System.Windows.Forms.Button();
            this.txtOut3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOut2 = new System.Windows.Forms.Button();
            this.txtOut2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpValve = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtValve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sensorChart1 = new CSInternal.SensorChart();
            this.sensorChart2 = new CSInternal.SensorChart();
            this.sensorChart3 = new CSInternal.SensorChart();
            this.timerCharts = new System.Windows.Forms.Timer(this.components);
            this.lstSensors = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCtrl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpValve.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 573);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lstSensors);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 415);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblReading);
            this.panel3.Controls.Add(this.lblSensor);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 27);
            this.panel3.TabIndex = 1;
            // 
            // lblReading
            // 
            this.lblReading.AutoSize = true;
            this.lblReading.Location = new System.Drawing.Point(200, 3);
            this.lblReading.Name = "lblReading";
            this.lblReading.Size = new System.Drawing.Size(107, 17);
            this.lblReading.TabIndex = 5;
            this.lblReading.Text = "Current reading";
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(-1, 3);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(53, 17);
            this.lblSensor.TabIndex = 3;
            this.lblSensor.Text = "Sensor";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(91, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 131);
            this.panel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.btnUpload,
            this.lblRowCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(313, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSettings
            // 
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.IconColor = System.Drawing.Color.Black;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(29, 24);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUpload.IconColor = System.Drawing.Color.Black;
            this.btnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(29, 24);
            this.btnUpload.Text = "Upload locally stored experiment data";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(25, 24);
            this.lblRowCount.Text = "20";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlCtrl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(313, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 573);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pnlCtrl
            // 
            this.pnlCtrl.Controls.Add(this.groupBox2);
            this.pnlCtrl.Controls.Add(this.groupBox1);
            this.pnlCtrl.Controls.Add(this.grpValve);
            this.pnlCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrl.Location = new System.Drawing.Point(3, 289);
            this.pnlCtrl.Name = "pnlCtrl";
            this.pnlCtrl.Size = new System.Drawing.Size(360, 281);
            this.pnlCtrl.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOut3);
            this.groupBox2.Controls.Add(this.txtOut3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Out3";
            // 
            // btnOut3
            // 
            this.btnOut3.Location = new System.Drawing.Point(215, 31);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(75, 25);
            this.btnOut3.TabIndex = 2;
            this.btnOut3.Text = "On";
            this.btnOut3.UseVisualStyleBackColor = true;
            this.btnOut3.Click += new System.EventHandler(this.btnOut3_Click);
            // 
            // txtOut3
            // 
            this.txtOut3.Enabled = false;
            this.txtOut3.Location = new System.Drawing.Point(109, 31);
            this.txtOut3.Name = "txtOut3";
            this.txtOut3.Size = new System.Drawing.Size(100, 22);
            this.txtOut3.TabIndex = 1;
            this.txtOut3.Text = "Off";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Currently:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOut2);
            this.groupBox1.Controls.Add(this.txtOut2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Out2";
            // 
            // btnOut2
            // 
            this.btnOut2.Location = new System.Drawing.Point(215, 31);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(75, 25);
            this.btnOut2.TabIndex = 2;
            this.btnOut2.Text = "On";
            this.btnOut2.UseVisualStyleBackColor = true;
            this.btnOut2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtOut2
            // 
            this.txtOut2.Enabled = false;
            this.txtOut2.Location = new System.Drawing.Point(109, 31);
            this.txtOut2.Name = "txtOut2";
            this.txtOut2.Size = new System.Drawing.Size(100, 22);
            this.txtOut2.TabIndex = 1;
            this.txtOut2.Text = "Off";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currently:";
            // 
            // grpValve
            // 
            this.grpValve.Controls.Add(this.btnChange);
            this.grpValve.Controls.Add(this.txtValve);
            this.grpValve.Controls.Add(this.label2);
            this.grpValve.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpValve.Location = new System.Drawing.Point(0, 0);
            this.grpValve.Name = "grpValve";
            this.grpValve.Size = new System.Drawing.Size(360, 66);
            this.grpValve.TabIndex = 1;
            this.grpValve.TabStop = false;
            this.grpValve.Text = "Valve";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(215, 31);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 25);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Open";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtValve
            // 
            this.txtValve.Enabled = false;
            this.txtValve.Location = new System.Drawing.Point(109, 31);
            this.txtValve.Name = "txtValve";
            this.txtValve.Size = new System.Drawing.Size(100, 22);
            this.txtValve.TabIndex = 1;
            this.txtValve.Text = "Closed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Currently:";
            // 
            // sensorChart1
            // 
            this.sensorChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart1.Location = new System.Drawing.Point(369, 289);
            this.sensorChart1.Name = "sensorChart1";
            this.sensorChart1.Size = new System.Drawing.Size(361, 281);
            this.sensorChart1.TabIndex = 4;
            // 
            // sensorChart2
            // 
            this.sensorChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart2.Location = new System.Drawing.Point(369, 3);
            this.sensorChart2.Name = "sensorChart2";
            this.sensorChart2.Size = new System.Drawing.Size(361, 280);
            this.sensorChart2.TabIndex = 5;
            // 
            // sensorChart3
            // 
            this.sensorChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart3.Location = new System.Drawing.Point(3, 3);
            this.sensorChart3.Name = "sensorChart3";
            this.sensorChart3.Size = new System.Drawing.Size(360, 280);
            this.sensorChart3.TabIndex = 6;
            // 
            // timerCharts
            // 
            this.timerCharts.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lstSensors
            // 
            this.lstSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSensors.FormattingEnabled = true;
            this.lstSensors.ItemHeight = 16;
            this.lstSensors.Location = new System.Drawing.Point(0, 0);
            this.lstSensors.Name = "lstSensors";
            this.lstSensors.Size = new System.Drawing.Size(313, 415);
            this.lstSensors.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCtrl.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpValve.ResumeLayout(false);
            this.grpValve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlCtrl;
        private System.Windows.Forms.GroupBox grpValve;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtValve;
        private System.Windows.Forms.Label label2;
        private SensorChart sensorChart1;
        private SensorChart sensorChart2;
        private SensorChart sensorChart3;
        private System.Windows.Forms.Timer timerCharts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOut3;
        private System.Windows.Forms.TextBox txtOut3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOut2;
        private System.Windows.Forms.TextBox txtOut2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnSettings;
        private FontAwesome.Sharp.IconToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripLabel lblRowCount;
        private System.Windows.Forms.ListBox lstSensors;
    }
}

