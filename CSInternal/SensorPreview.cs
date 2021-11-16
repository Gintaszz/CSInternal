using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSInternal
{
    public partial class SensorPreview : UserControl
    {
        public double Reading { get; set; }
        public SensorPreview(Sensor sensor)
        {
            InitializeComponent();
            Name = sensor.Name;
            Reading = sensor.CurrentReading;
            lblSensor.Text = Name;
        }

        private ulong sticks = 0;
        private bool changedMax = false;
        public void UpdateReading(Sensor sensor)
        {
            if (Name == (sensor).Name)
            {
                Reading = sensor.CurrentReading;
            }
            if (chrtPreview.Series[0].Points.Count == Properties.Settings.Default.PreviewLength)
            {
                sticks +=(ulong)chrtPreview.Series[0].Points[(int)Properties.Settings.Default.PreviewLength - 1].XValue;
                chrtPreview.Series[0].Points.Clear();
                //MessageBox.Show(chrtPreview.ChartAreas[0].AxisX.Maximum.ToString());
                if (!changedMax)
                {
                    chrtPreview.ChartAreas[0].AxisX.Maximum = (double)sticks;
                    chrtPreview.ChartAreas[0].AxisX.Minimum = 0;
                    //MessageBox.Show("taisau");
                    changedMax = true;
                }
            }
            chrtPreview.Series[0].Points.AddXY((Form1.inst.GetSensor("Time") as Sensor).CurrentReading-sticks, Reading);
        }

    }
}
