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
    public partial class Form1 : Form
    {
        List<Sensor> sensors;
        List<SensorChart> charts;
        //Singleton :(((((
        public static Form1 inst;
        ulong ticks;
        bool[] devices= new bool[] {false,false,false};
        public ulong Ticks { get=>ticks*(ulong)timerCharts.Interval; }
        public Form1()
        {
            InitializeComponent();
            inst = this;
            sensors = new List<Sensor>();
            charts = new List<SensorChart>();
            charts.AddRange(new SensorChart[]{ sensorChart1, sensorChart2,sensorChart3});
            ticks = 0;
            //bTicks = 0;
            SheetsIntegration.Initialize();
            //timerCharts.Start();
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a port where the experimental setup is connected","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!Communicator.IsInitialized)
            {
                Communicator.Initialize(comboBox1.SelectedItem.ToString(), this);
                Communicator.GetReadings(Communicator.ValueSource.Device1);
                Communicator.StartIMU();
            }
            if (timerCharts.Enabled) timerCharts.Stop();
            else timerCharts.Start();
            comboBox1.Enabled = !comboBox1.Enabled;
            button1.Text = (comboBox1.Enabled) ? "Start" : "Stop";
        }
        public List<object> GetSensors()
        {
            var rt = sensors.Select(s => (object)s).ToList();
            rt.Add(new Sensor("Time", ticks * (ulong)timerCharts.Interval));
            return rt;
        }
        public object GetSensor(string sensorName,ulong startTicks=0)
        {
            if (sensorName == "Time") return new Sensor(((double)((ticks*(ulong)timerCharts.Interval)-startTicks))/1000); //getCurrTime;
            return sensors.FirstOrDefault(s => s.Name == sensorName);
        }
        public void Receive(double value, object device)
        {
            var sensor = (Communicator.ValueSource)device;
            if (sensor == Communicator.ValueSource.Device1)
            {
                btnChange.Text = (devices[0]) ? "Close" : "Open";
                txtValve.Text = devices[0] ? "Opened" : "Closed";
                devices[0] = value == double.MaxValue;
                return;
            }
            else if (sensor == Communicator.ValueSource.Device2)
            {
                devices[1] = value == double.MaxValue;
                btnOut2.Text = (devices[1]) ? "Off" : "On";
                txtOut2.Text = devices[1] ? "On" : "Off";
                return;
            }
            if (sensor == Communicator.ValueSource.Device3)
            {
                btnOut3.Text = (devices[2]) ? "Off" : "On";
                txtOut3.Text = devices[2] ? "On" : "Off";
                devices[2] = value == double.MaxValue;
                return;
            }
            var se = sensors.FirstOrDefault(s => s.Name == sensor.ToString());
            if (se == null)
            {
                sensors.Add(new Sensor(sensor.ToString(), value));
                return;
                //se = sensors.First(s => s.Name == sensor.ToString());
            }
            se.CurrentReading = value;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            //receive sensor data
            if (Communicator.IsInitialized)
            {
                Communicator.GetReadings(Communicator.ValueSource.Runtime, 1);
                //Communicator.GetReadings(Communicator.ValueSource.Device1, 2);
                Communicator.GetReadings(Communicator.ValueSource.GyroX);
            }

            if (ticks % 100 == 0)
            {
                //SheetsIntegration.AddRow().ConfigureAwait(false);
                //SheetsIntegration.AddData("TimeStamp", ticks * (ulong)timer.Interval).ConfigureAwait(false);
                //SheetsIntegration.AddData("TimeR", ticks).ConfigureAwait(false);
            }
            foreach (var item in charts)
            {
                item.AddPoint();
            }
            lstSensors.Items.Clear();
            lstSensors.Items.AddRange(sensors.Select(s=>$"{s.Name}: {s.CurrentReading}").ToArray());
            
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new Communicator.SetDevice[] { Communicator.SetDevice.Out12V/*,Communicator.SetDevice.Out1*/ }, !devices[0]);
            devices[0] = !devices[0];
            ((Button)sender).Text = (devices[0]) ? "Close" : "Open";
            txtValve.Text = (!devices[0]) ? "Closed" : "Opened";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new Communicator.SetDevice[] { Communicator.SetDevice.Out2 }, !devices[1]);
            devices[1] = !devices[1];
            ((Button)sender).Text = (devices[1]) ? "Off" : "On";
            txtOut2.Text = devices[1] ? "On" : "Off";
        }

        private void btnOut3_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new Communicator.SetDevice[] { Communicator.SetDevice.Out3 }, !devices[2]);
            devices[2] = !devices[2];
            ((Button)sender).Text = (devices[2]) ? "Off" : "On";
            txtOut3.Text = devices[2] ? "On" : "Off";
        }
    }
}
