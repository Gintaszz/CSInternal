using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSInternal
{
    public partial class SensorChart : UserControl
    {
        public string SeriesHeaders { get { return series.Name; } }
        Series series; //think about how the graphs could be exported
        public SensorChart()
        {
            InitializeComponent();
            series = new Series();
            series.ChartType = SeriesChartType.Point;
            series.Name = "/";
            chart1.Series.Add(series);
        }

        private void cmdY_Click(object sender, EventArgs e)
        {
            var sensors = ((FormMain)Form.ActiveForm).GetSensors();
            //sensors.Add((object)(new Sensor("Time")));
            ((ComboBox)sender).Items.Clear();
            ((ComboBox)sender).Items.AddRange(sensors.Select(s => ((Sensor)s).Name).ToArray());
        }

        private void cmdX_Click(object sender, EventArgs e)
        {
            var sensors = ((FormMain)Form.ActiveForm).GetSensors();
            //sensors.Add((object)(new Sensor("Time")));
            ((ComboBox)sender).Items.Clear();
            ((ComboBox)sender).Items.AddRange(sensors.Select(s => ((Sensor)s).Name).ToArray());
        }

        private void SensorChart_SizeChanged(object sender, EventArgs e)
        {
            lblX.Location = new Point(pnlBtns.Width / 3 - cmdX.Width / 2 - lblX.Width, lblX.Location.Y);
            cmdX.Location = new Point(pnlBtns.Width / 3 - cmdX.Width / 2, cmdX.Location.Y);

            lblY.Location = new Point(pnlBtns.Width - cmdY.Width - cmdY.Width / 2 - lblY.Width, lblY.Location.Y);
            cmdY.Location = new Point(pnlBtns.Width - cmdY.Width - cmdY.Width / 2, cmdY.Location.Y);
        }

        private void cmdX_SelectedIndexChanged(object sender, EventArgs e)
        {
            //change chart;
            series.Points.Clear();
            series.Name = ((ComboBox)sender).SelectedItem.ToString() + "/" + series.Name.Split('/')[1];
        }
        private void cmdY_SelectedIndexChanged(object sender, EventArgs e)
        {
            series.Points.Clear();
            series.Name = series.Name.Split('/')[0]+'/'+ ((ComboBox)sender).SelectedItem.ToString();
        }
        public void AddPoint(double x, double y)
        {
            series.Points.AddXY(x, y);
        }
        public void AddPoint()
        {
            if (SeriesHeaders.Split('/').Any(s => s == "")) return;
            if (Form.ActiveForm==null|| Form.ActiveForm.Name!="FormMain") return;
            var point = new DataPoint(((Sensor)((FormMain)Form.ActiveForm).GetSensor(SeriesHeaders.Split('/')[0])).CurrentReading, ((Sensor)((FormMain)Form.ActiveForm).GetSensor(SeriesHeaders.Split('/')[1])).CurrentReading);

            if (!series.Points.Contains(point))
                series.Points.Add(point);
            //series.Points.AddXY(((Sensor)((Form1)Form.ActiveForm).GetSensor(SeriesHeaders.Split('/')[0])).CurrentReading, ((Sensor)((Form1)Form.ActiveForm).GetSensor(SeriesHeaders.Split('/')[1])).CurrentReading);
            //var sensor = ((Form1)Form.ActiveForm).GetSensors();
            return;
        }
    }
}
