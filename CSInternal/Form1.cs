using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSInternal
{
    public partial class Form1 : Form
    {
        #region properties and variables
        List<Sensor> sensors;
        List<SensorChart> charts;
        public static Form1 inst; //singleton
        // the state of devices that are controlled
        bool[] devices = new bool[] { false, false, false };
        //the time since the data recording began
        ulong ticks;
        public ulong Ticks { get => ticks * (ulong)timerCharts.Interval; }
        #endregion
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            inst = this;
            sensors = new List<Sensor>();
            charts = new List<SensorChart>();
            charts.AddRange(new SensorChart[] { sensorChart1, sensorChart2, sensorChart3, sensorChart4 });
            ticks = 0;
            if (Properties.Settings.Default.SheetsStorage) SheetsIntegration.Initialize();
            if (Properties.Settings.Default.LocalDataStorage) LocalDataStorage.Initialize();
            lblRowCount.Text = SheetsIntegration.BufferSize.ToString();
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            btnValve.Enabled = !btnValve.Enabled;
            btnOut2.Enabled = !btnOut2.Enabled;
            btnOut3.Enabled = !btnOut3.Enabled;
        }
        #endregion
        #region Methods
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a port where the experimental setup is connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Communicator.IsInitialized)
            {
                Communicator.Initialize(comboBox1.SelectedItem.ToString());
                //SaveConfiguration();
                //Communicator.ApplySettings();
                //Communicator.StartIMU();
                Communicator.GetReadings(ValueSource.Device1);
            }
            if (timerCharts.Enabled) timerCharts.Stop();
            else timerCharts.Start();
            comboBox1.Enabled = !comboBox1.Enabled;
            btnValve.Enabled = !btnValve.Enabled;
            btnOut2.Enabled = !btnOut2.Enabled;
            btnOut3.Enabled = !btnOut3.Enabled;
            button1.Text = (comboBox1.Enabled) ? "Start" : "Stop";

        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new SetDevice[] { SetDevice.Out12V, SetDevice.Out1 }, !devices[0]);
            devices[0] = !devices[0];
            //((Button)sender).Text = (devices[0]) ? "Close" : "Open";
            ((Button)sender).BackColor = (devices[0]) ? Color.Green : Color.Red;
            //txtValve.Text = (!devices[0]) ? "Closed" : "Opened";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new SetDevice[] { SetDevice.Out2 }, !devices[1]);
            devices[1] = !devices[1];
            //((Button)sender).Text = (devices[1]) ? "Off" : "On";
            ((Button)sender).BackColor = (devices[1]) ? Color.Green : Color.Red;
            //txtOut2.Text = devices[1] ? "On" : "Off";
        }

        private void btnOut3_Click(object sender, EventArgs e)
        {
            Communicator.SetValue(new SetDevice[] { SetDevice.Out3 }, !devices[2]);
            devices[2] = !devices[2];
            //((Button)sender).Text = (devices[2]) ? "Off" : "On";
            ((Button)sender).BackColor = (devices[2]) ? Color.Green : Color.Red;
            //txtOut3.Text = devices[2] ? "On" : "Off";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SheetsStorage)
                if (SheetsIntegration.BufferSize > 0)
                {
                    Thread t = new Thread(new ThreadStart(SheetsIntegration.UploadBufferData));
                    t.Start();
                }
            if (Properties.Settings.Default.LocalDataStorage)
                if (SheetsIntegration.BufferSize > 0)
                {
                    Thread t = new Thread(new ThreadStart(LocalDataStorage.SaveBufferData));
                    t.Start();
                }

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var f = new SetupSettingsForm())
            {
                f.ShowDialog();
            }
        }
        #endregion


        public List<object> GetSensors()
        {
            var rt = sensors.Select(s => (object)s).ToList();
            rt.Add(new Sensor("Time", ticks * (ulong)timerCharts.Interval));
            return rt;
        }
        public object GetSensor(string sensorName, ulong startTicks = 0)
        {
            if (sensorName == "Time") //get current time;
                return new Sensor(((double)((ticks * (ulong)timerCharts.Interval) - startTicks)) / 1000);
            return sensors.FirstOrDefault(s => s.Name == sensorName);
        }
        public void Receive(object value)
        {
            Receive(((KeyValuePair<ValueSource, double>)value).Value, ((KeyValuePair<ValueSource, double>)value).Key);
        }
        public void Receive(double value, ValueSource sensor)
        {
            //var sensor = device;
            if (sensor == ValueSource.Device1)
            {
                devices[0] = value == double.MaxValue;
                Invoke(new Action(() => btnValve.BackColor = (devices[0]) ? Color.Green : Color.Red));
                //Invoke(new Action(() => txtValve.Text = (devices[0]) ? "Opened" : "Closed"));
                return;
            }
            else if (sensor == ValueSource.Device2)
            {
                devices[1] = value == double.MaxValue;
                Invoke(new Action(() => btnOut2.BackColor = (devices[1]) ? Color.Green : Color.Red));
                //Invoke(new Action(() => txtOut2.Text = devices[1] ? "On" : "Off"));
                return;
            }
            if (sensor == ValueSource.Device3)
            {
                devices[2] = value == double.MaxValue;
                Invoke(new Action(() => btnOut3.BackColor = (devices[2]) ? Color.Green : Color.Red));
                //Invoke(new Action(() => txtOut3.Text = devices[2] ? "On" : "Off"));
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

            if (Communicator.IsInitialized)
            {
                //receive sensor data
                Communicator.GetReadings(ValueSource.Runtime, 1);
                Communicator.GetReadings(ValueSource.GyroX);

                //store sensor data
                LocalDataStorage.AddRow();
                SheetsIntegration.AddRow();
                lblRowCount.Text = SheetsIntegration.BufferSize.ToString();
            }

            //Sensor charts are updated
            foreach (var item in charts)
            {
                item.AddPoint();
            }

            //sensor previews are updated.
            if (pnlSensors.Controls.Count > 0)
            {
                var t = sensors.SkipWhile(s => pnlSensors.Controls.Cast<SensorPreview>().Select(ct => ct.Name).Contains(s.Name)).ToList();
                if (t.Count > 0)
                {
                    var previews = t.Select(te => new SensorPreview(te)).ToArray();
                    int cnt = pnlSensors.Controls.Count;
                    for (int i = 0; i < previews.Length; i++)
                    {
                        previews[i].Location = new Point(0, previews[0].Height * (i + cnt));
                    }
                    pnlSensors.Controls.AddRange(previews);
                }
                foreach (Control item in pnlSensors.Controls)
                {
                    (item as SensorPreview).UpdateReading(sensors.FirstOrDefault(sen => sen.Name == item.Name));
                }
            }
            else
            {
                var previews = sensors.Select(te => new SensorPreview(te)).ToArray();
                int cnt = pnlSensors.Controls.Count;
                for (int i = 0; i < previews.Length; i++)
                {
                    previews[i].Location = new Point(0, previews[0].Height * (i + cnt));
                }
                pnlSensors.Controls.AddRange(previews);
            }
        }

        #endregion
    }
}
