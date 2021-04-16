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
    public partial class FormMain : Form
    {
        List<Sensor> sensors;
        List<SensorChart> charts;
        ulong ticks;
        public FormMain()
        {
            InitializeComponent();
            sensors = new List<Sensor>();
            charts = new List<SensorChart>();
            charts.AddRange(new SensorChart[]{ sensorChart1, sensorChart2,sensorChart3});
            ticks = 0;
            SheetsIntegration.Initialize();
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ouchie, that hurt.");
            sensors.Add(new Sensor($"sensor{ticks.ToString()}",ticks));
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = (((Button)sender).Text == "Open") ? "Close" : "Open";
            txtValve.Text = (((Button)sender).Text == "Open") ? "Closed" : "Opened";
        }
        public List<object> GetSensors()
        {
            var rt = sensors.Select(s => (object)s).ToList();
            rt.Add(new Sensor("Time", ticks * (ulong)timer.Interval));
            return rt;
        }
        private void trckTemperature_Scroll(object sender, EventArgs e)
        {
            txtTemperature.Text = $"{((TrackBar)sender).Value}.00 °C";
        }
        public object GetSensor(string sensorName)
        {
            if (sensorName == "Time") return new Sensor(ticks*(ulong)timer.Interval); //getCurrTime;
            return sensors.FirstOrDefault(s => s.Name == sensorName);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            //add relevant points
            /*var relevantCharts = charts.Where(ch => ch.SeriesHeaders== "Time/Time");
            foreach (var item in relevantCharts)
            {
                item.AddPoint(ticks * (ulong)timer.Interval, ticks * (ulong)timer.Interval);
            }*/
            //if(Form.ActiveForm==(Form1)Form)
            if (ticks % 100 == 0)
            {
                SheetsIntegration.AddRow().ConfigureAwait(false);
                //SheetsIntegration.AddData("TimeStamp", ticks * (ulong)timer.Interval).ConfigureAwait(false);
                //SheetsIntegration.AddData("TimeR", ticks).ConfigureAwait(false);
            }
            foreach (var item in charts)
            {
                item.AddPoint();
            }
        }
    }
}
