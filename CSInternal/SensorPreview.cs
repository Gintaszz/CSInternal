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
            Name = sensor.Name;
            Reading = sensor.CurrentReading;
            InitializeComponent();
        }
        public void UpdateReading(Sensor sensor)
        {
            if (Name == sensor.Name)
            {
                Reading = sensor.CurrentReading;
            }
        }

    }
}
