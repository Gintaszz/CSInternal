using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSInternal
{
    class LocalDataStorage
    {
        static List<Dictionary<string, double>> buffer;
        public static bool Initialized { get; set; }
        public static void Initialize()
        {
            buffer = new List<Dictionary<string, double>>();
            Initialized = true;

        }
        public static void AddRow()
        {
            var sensors = new Dictionary<string, double>();
            Form1.inst.GetSensors().ForEach(s => sensors.Add(((Sensor)s).Name, ((Sensor)s).CurrentReading));
            buffer.Add(sensors);
            if (sensors == null) return;
            if (((int)sensors["Time"]) % 10000 == 0)
            {
                Thread t = new Thread(new ThreadStart(SaveBufferData));
                t.Start();
            }
        }
        public static async void SaveBufferData()
        {
            var collums = new List<string>();
            string txt = "";
            foreach (var item in buffer.Last().Keys)
            {
                txt += item + ",";
                collums.Add(item);
            }
            txt.Remove(txt.Length - 1);
            txt += Environment.NewLine;
            foreach (var row in buffer)
            {
                for (int i = 0; i < collums.Count; i++)
                {
                    txt += (row.ContainsKey(collums[i])) ? (row[collums[i]] + ((i!=collums.Count-1)?",":"")) : ((i != collums.Count - 1) ? "," : "");
                }
                txt += Environment.NewLine;
            }
            File.AppendAllText(Properties.Settings.Default.LocalDataStoragePath,txt);
        }

    }
}
