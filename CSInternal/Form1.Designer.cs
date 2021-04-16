
namespace CSInternal
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstSensors = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblReading = new System.Windows.Forms.Label();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fiileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCtrl = new System.Windows.Forms.Panel();
            this.grpValve = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtValve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTemperature = new System.Windows.Forms.GroupBox();
            this.trckTemperature = new System.Windows.Forms.TrackBar();
            this.txtTemperature = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sensorChart1 = new CSInternal.SensorChart();
            this.sensorChart2 = new CSInternal.SensorChart();
            this.sensorChart3 = new CSInternal.SensorChart();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCtrl.SuspendLayout();
            this.grpValve.SuspendLayout();
            this.grpTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 545);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lstSensors);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 387);
            this.panel4.TabIndex = 2;
            // 
            // lstSensors
            // 
            this.lstSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSensors.FormattingEnabled = true;
            this.lstSensors.ItemHeight = 16;
            this.lstSensors.Location = new System.Drawing.Point(0, 0);
            this.lstSensors.Name = "lstSensors";
            this.lstSensors.Size = new System.Drawing.Size(313, 387);
            this.lstSensors.TabIndex = 0;
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 131);
            this.panel2.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.etcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fiileToolStripMenuItem
            // 
            this.fiileToolStripMenuItem.Name = "fiileToolStripMenuItem";
            this.fiileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fiileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // etcToolStripMenuItem
            // 
            this.etcToolStripMenuItem.Name = "etcToolStripMenuItem";
            this.etcToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.etcToolStripMenuItem.Text = "Etc";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(313, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 545);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pnlCtrl
            // 
            this.pnlCtrl.Controls.Add(this.grpValve);
            this.pnlCtrl.Controls.Add(this.grpTemperature);
            this.pnlCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtrl.Location = new System.Drawing.Point(3, 275);
            this.pnlCtrl.Name = "pnlCtrl";
            this.pnlCtrl.Size = new System.Drawing.Size(360, 267);
            this.pnlCtrl.TabIndex = 2;
            // 
            // grpValve
            // 
            this.grpValve.Controls.Add(this.btnChange);
            this.grpValve.Controls.Add(this.txtValve);
            this.grpValve.Controls.Add(this.label2);
            this.grpValve.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpValve.Location = new System.Drawing.Point(0, 123);
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
            // grpTemperature
            // 
            this.grpTemperature.Controls.Add(this.trckTemperature);
            this.grpTemperature.Controls.Add(this.txtTemperature);
            this.grpTemperature.Controls.Add(this.label1);
            this.grpTemperature.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTemperature.Location = new System.Drawing.Point(0, 0);
            this.grpTemperature.Name = "grpTemperature";
            this.grpTemperature.Size = new System.Drawing.Size(360, 123);
            this.grpTemperature.TabIndex = 0;
            this.grpTemperature.TabStop = false;
            this.grpTemperature.Text = "Temperature";
            // 
            // trckTemperature
            // 
            this.trckTemperature.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trckTemperature.Location = new System.Drawing.Point(3, 64);
            this.trckTemperature.Maximum = 50;
            this.trckTemperature.Minimum = 15;
            this.trckTemperature.Name = "trckTemperature";
            this.trckTemperature.Size = new System.Drawing.Size(354, 56);
            this.trckTemperature.TabIndex = 2;
            this.trckTemperature.Value = 15;
            this.trckTemperature.Scroll += new System.EventHandler(this.trckTemperature_Scroll);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Enabled = false;
            this.txtTemperature.Location = new System.Drawing.Point(109, 22);
            this.txtTemperature.Mask = "00.00 °C";
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 22);
            this.txtTemperature.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current:";
            // 
            // sensorChart1
            // 
            this.sensorChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart1.Location = new System.Drawing.Point(369, 275);
            this.sensorChart1.Name = "sensorChart1";
            this.sensorChart1.Size = new System.Drawing.Size(361, 267);
            this.sensorChart1.TabIndex = 4;
            // 
            // sensorChart2
            // 
            this.sensorChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart2.Location = new System.Drawing.Point(369, 3);
            this.sensorChart2.Name = "sensorChart2";
            this.sensorChart2.Size = new System.Drawing.Size(361, 266);
            this.sensorChart2.TabIndex = 5;
            // 
            // sensorChart3
            // 
            this.sensorChart3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart3.Location = new System.Drawing.Point(3, 3);
            this.sensorChart3.Name = "sensorChart3";
            this.sensorChart3.Size = new System.Drawing.Size(360, 266);
            this.sensorChart3.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCtrl.ResumeLayout(false);
            this.grpValve.ResumeLayout(false);
            this.grpValve.PerformLayout();
            this.grpTemperature.ResumeLayout(false);
            this.grpTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblReading;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lstSensors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem fiileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etcToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlCtrl;
        private System.Windows.Forms.GroupBox grpValve;
        private System.Windows.Forms.GroupBox grpTemperature;
        private System.Windows.Forms.MaskedTextBox txtTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtValve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trckTemperature;
        private SensorChart sensorChart1;
        private SensorChart sensorChart2;
        private SensorChart sensorChart3;
        private System.Windows.Forms.Timer timer;
    }
}

