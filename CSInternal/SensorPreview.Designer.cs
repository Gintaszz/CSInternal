
namespace CSInternal
{
    partial class SensorPreview
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtPreview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.lblSensor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPreview)).BeginInit();
            this.pnlAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtPreview
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.chrtPreview.ChartAreas.Add(chartArea1);
            this.chrtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtPreview.Legends.Add(legend1);
            this.chrtPreview.Location = new System.Drawing.Point(0, 0);
            this.chrtPreview.Name = "chrtPreview";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=False";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtPreview.Series.Add(series1);
            this.chrtPreview.Size = new System.Drawing.Size(260, 50);
            this.chrtPreview.TabIndex = 0;
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.lblSensor);
            this.pnlAll.Controls.Add(this.chrtPreview);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAll.Location = new System.Drawing.Point(0, 0);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(260, 50);
            this.pnlAll.TabIndex = 2;
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(8, 8);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(46, 17);
            this.lblSensor.TabIndex = 1;
            this.lblSensor.Text = "label1";
            // 
            // SensorPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAll);
            this.Name = "SensorPreview";
            this.Size = new System.Drawing.Size(260, 50);
            ((System.ComponentModel.ISupportInitialize)(this.chrtPreview)).EndInit();
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPreview;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Label lblSensor;
    }
}
