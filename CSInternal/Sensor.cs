using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInternal
{
    class Sensor //add comments explaining what each class does, and be more precise with the names of the objects.
    {
        public Sensor() { }
        public Sensor(string name) { Name = name; }
        public Sensor(double value) { CurrentReading = value; } //explain why
        public Sensor(string name, double value) { Name = name; CurrentReading = value; } //explain why

        List<double> readings;//explain why list
        public string Name { get; set; }
        public bool Status { get; set; }
        public double CurrentReading
        {
            get
            {
                return (readings == null) ? double.NaN : readings.Last();
            }
            set
            {
                if (readings == null) readings = new List<double>();
                readings.Add(value);
            }
        }
        public List<double> GetAllReadings()
        {
            return readings;
        }
    }
}
