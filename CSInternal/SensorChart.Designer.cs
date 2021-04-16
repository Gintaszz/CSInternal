
namespace CSInternal
{
    partial class SensorChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblX = new System.Windows.Forms.Label();
            this.cmdX = new System.Windows.Forms.ComboBox();
            this.cmdY = new System.Windows.Forms.ComboBox();
            this.lblY = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBtns = new System.Windows.Forms.Panel();
            this.pnlChart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlBtns.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(7, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 17);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "x";
            // 
            // cmdX
            // 
            this.cmdX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdX.FormattingEnabled = true;
            this.cmdX.Location = new System.Drawing.Point(27, 6);
            this.cmdX.Name = "cmdX";
            this.cmdX.Size = new System.Drawing.Size(97, 24);
            this.cmdX.TabIndex = 4;
            this.cmdX.SelectedIndexChanged += new System.EventHandler(this.cmdX_SelectedIndexChanged);
            this.cmdX.Click += new System.EventHandler(this.cmdX_Click);
            // 
            // cmdY
            // 
            this.cmdY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdY.FormattingEnabled = true;
            this.cmdY.Location = new System.Drawing.Point(173, 6);
            this.cmdY.Name = "cmdY";
            this.cmdY.Size = new System.Drawing.Size(97, 24);
            this.cmdY.TabIndex = 6;
            this.cmdY.SelectedIndexChanged += new System.EventHandler(this.cmdY_SelectedIndexChanged);
            this.cmdY.Click += new System.EventHandler(this.cmdY_Click);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(152, 9);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 17);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "y";
            // 
            // chart1
            // 
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 83.29788F;
            chartArea1.InnerPlotPosition.Width = 90F;
            chartArea1.InnerPlotPosition.X = 10F;
            chartArea1.InnerPlotPosition.Y = 4.46808F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 5F;
            legend1.Position.Width = 45.4039F;
            legend1.Position.X = 25F;
            legend1.Position.Y = 92F;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(307, 236);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pnlBtns
            // 
            this.pnlBtns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBtns.Controls.Add(this.lblX);
            this.pnlBtns.Controls.Add(this.cmdX);
            this.pnlBtns.Controls.Add(this.cmdY);
            this.pnlBtns.Controls.Add(this.lblY);
            this.pnlBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBtns.Location = new System.Drawing.Point(0, 238);
            this.pnlBtns.Name = "pnlBtns";
            this.pnlBtns.Size = new System.Drawing.Size(309, 40);
            this.pnlBtns.TabIndex = 8;
            // 
            // pnlChart
            // 
            this.pnlChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChart.Controls.Add(this.chart1);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(0, 0);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(309, 238);
            this.pnlChart.TabIndex = 9;
            // 
            // SensorChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlBtns);
            this.Name = "SensorChart";
            this.Size = new System.Drawing.Size(309, 278);
            this.SizeChanged += new System.EventHandler(this.SensorChart_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlBtns.ResumeLayout(false);
            this.pnlBtns.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.ComboBox cmdX;
        private System.Windows.Forms.ComboBox cmdY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlBtns;
        private System.Windows.Forms.Panel pnlChart;
    }
}
