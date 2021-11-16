
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
            this.pnlOut = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSettings = new FontAwesome.Sharp.IconToolStripButton();
            this.btnUpload = new FontAwesome.Sharp.IconToolStripButton();
            this.lblRowCount = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timerCharts = new System.Windows.Forms.Timer(this.components);
            this.pnlSensors = new System.Windows.Forms.Panel();
            this.btnValve = new System.Windows.Forms.Button();
            this.btnOut2 = new System.Windows.Forms.Button();
            this.btnOut3 = new System.Windows.Forms.Button();
            this.sensorChart1 = new CSInternal.SensorChart();
            this.sensorChart2 = new CSInternal.SensorChart();
            this.sensorChart3 = new CSInternal.SensorChart();
            this.sensorChart4 = new CSInternal.SensorChart();
            this.panel1.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlSensors);
            this.panel1.Controls.Add(this.pnlOut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 573);
            this.panel1.TabIndex = 0;
            // 
            // pnlOut
            // 
            this.pnlOut.AutoScroll = true;
            this.pnlOut.Controls.Add(this.btnOut3);
            this.pnlOut.Controls.Add(this.btnOut2);
            this.pnlOut.Controls.Add(this.btnValve);
            this.pnlOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOut.Location = new System.Drawing.Point(0, 125);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(313, 40);
            this.pnlOut.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 125);
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
            this.toolStrip1.Size = new System.Drawing.Size(313, 31);
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
            this.btnSettings.Size = new System.Drawing.Size(29, 28);
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
            this.btnUpload.Size = new System.Drawing.Size(29, 28);
            this.btnUpload.Text = "Upload locally stored experiment data";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblRowCount
            // 
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(25, 28);
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
            this.tableLayoutPanel2.Controls.Add(this.sensorChart1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sensorChart4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(313, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 573);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // timerCharts
            // 
            this.timerCharts.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnlSensors
            // 
            this.pnlSensors.AutoScroll = true;
            this.pnlSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSensors.Location = new System.Drawing.Point(0, 165);
            this.pnlSensors.Name = "pnlSensors";
            this.pnlSensors.Size = new System.Drawing.Size(313, 408);
            this.pnlSensors.TabIndex = 3;
            // 
            // btnValve
            // 
            this.btnValve.BackColor = System.Drawing.Color.Red;
            this.btnValve.Location = new System.Drawing.Point(4, 7);
            this.btnValve.Name = "btnValve";
            this.btnValve.Size = new System.Drawing.Size(75, 27);
            this.btnValve.TabIndex = 0;
            this.btnValve.Text = "Valve";
            this.btnValve.UseVisualStyleBackColor = false;
            this.btnValve.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnOut2
            // 
            this.btnOut2.BackColor = System.Drawing.Color.Red;
            this.btnOut2.Location = new System.Drawing.Point(85, 7);
            this.btnOut2.Name = "btnOut2";
            this.btnOut2.Size = new System.Drawing.Size(75, 27);
            this.btnOut2.TabIndex = 1;
            this.btnOut2.Text = "Out2";
            this.btnOut2.UseVisualStyleBackColor = false;
            this.btnOut2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOut3
            // 
            this.btnOut3.BackColor = System.Drawing.Color.Red;
            this.btnOut3.Location = new System.Drawing.Point(166, 7);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(75, 27);
            this.btnOut3.TabIndex = 2;
            this.btnOut3.Text = "Out3";
            this.btnOut3.UseVisualStyleBackColor = false;
            this.btnOut3.Click += new System.EventHandler(this.btnOut3_Click);
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
            // sensorChart4
            // 
            this.sensorChart4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sensorChart4.Location = new System.Drawing.Point(3, 289);
            this.sensorChart4.Name = "sensorChart4";
            this.sensorChart4.Size = new System.Drawing.Size(360, 281);
            this.sensorChart4.TabIndex = 7;
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
            this.pnlOut.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private SensorChart sensorChart1;
        private SensorChart sensorChart2;
        private SensorChart sensorChart3;
        private System.Windows.Forms.Timer timerCharts;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconToolStripButton btnSettings;
        private FontAwesome.Sharp.IconToolStripButton btnUpload;
        private System.Windows.Forms.ToolStripLabel lblRowCount;
        private System.Windows.Forms.Panel pnlSensors;
        private System.Windows.Forms.Button btnOut3;
        private System.Windows.Forms.Button btnOut2;
        private System.Windows.Forms.Button btnValve;
        private SensorChart sensorChart4;
    }
}

