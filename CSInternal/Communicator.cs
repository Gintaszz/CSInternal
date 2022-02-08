using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;
using yats.Ports;
using CSInternal;
using System.Threading;

namespace CSInternal
{
    #region Enums
    public enum ImuGyroRange
    {
        _245dps,
        _500dps,
        _1000dps,
        _2000dps,
        _125dps,
    }
    public enum ImuAccelRange
    {
        _2g,
        _4g=2,
        _8g=3,
        _16g=1,
    }
    public enum ImuAccelRefreshRate
    {
        _PowerDown,
        _13HZ,
        _26HZ,
        _52HZ,
        _104HZ,
        _208HZ,
        _416HZ,
        _833HZ,
        _1660HZ,
        _3330HZ,
        _6660HZ,
    }
    public enum ImuGyroRefreshRate
    {
        _PowerDown,
        _13HZ,
        _26HZ,
        _52HZ,
        _104HZ,
        _208HZ,
        _416HZ,
        _833HZ,
        _1660HZ,
        _3330HZ,
    }
    public enum AntialiasingFilterBandwidth
    {
        _50HZ=3,
        _100HZ=2,
        _200HZ=1,
        _400HZ=0,
    }
    
    public enum ValueSource
    {
        //registrai
        IMUTemp,
        GyroX,
        GyroY,
        GyroZ,
        AccelerometerX,
        AccelerometerY,
        AccelerometerZ,
        Device1,
        Device2,
        Device3,
        T1,
        InternalT1,
        T2,
        InternalT2,
        T3,
        InternalT3,
        Preassure,
        IntegratedPreassure,
        BatteryVoltage,
        IntegratedBatteryVoltage,
        Runtime,
    }
    public enum SetDevice
    {
        Out12V,
        Out1,
        Out2,
        Out3
    }
    #endregion
    class Communicator
    {
        static bool isCheating = false;
        static bool isSetting = false;
        static EventHandler setDataEvent;

        static List<Response> responses;
        public static bool IsInitialized { get => sp != null; }
        public static int RCount { get => responses.Count; }

        //static Form1 form;
        public static Response LastResponse
        {
            get
            {
                if (responses.Count > 0) return responses.Last(r => r.Access == Response.AccessType.Read);
                else return null;
            }
        }
        static uint writeResponseCount = 0;
        static MonoSerialPort sp;
        static int executionPass = 0;
        static List<byte> receiveBuffer;
        public static EventHandler getDataEvent;  //event that will be called once the data is received
        public static void Initialize(string port, Form1 form)
        {
            responses = new List<Response>();
            receiveBuffer = new List<byte>();
            //Communicator.form = form;

            sp = new MonoSerialPort(port, 9600, 0, 8);
            //sp = new MonoSerialPort(port, 115200, 0, 8);
            sp.Handshake = 0;
            sp.DataReceived += Sp_DataReceived;
            sp.ReadBufferSize = 50;
            sp.Open();
            sp.WriteTimeout = 10000;
            sp.ReadTimeout = 1000;
            ApplySettings();
        }

        public static void ApplySettings()
        {
            List<byte> msg = new List<byte>("A5 5A 00 00 16 10 03".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            //ctrl1
            var temp = 0;
            temp |= (Properties.Settings.Default.AccelRefreshrate << 4);
            temp |= (Properties.Settings.Default.AccelRange << 2);
            temp |= (Properties.Settings.Default.AntiAliasingFilterBandwidth);
            msg.Add(Convert.ToByte(temp));
            //ctrl2
            temp = 0;
            temp |= (Properties.Settings.Default.GyroRefreshRate << 4);
            temp |= (Properties.Settings.Default.GyroRange == 4) ? 0b00000010 : (Properties.Settings.Default.GyroRange << 2);
            msg.Add(Convert.ToByte(temp));
            //ctrl3
            //pracheckinti defaultus
            msg.Add(0b00000100);
            /*
            //ctrl4
            temp = 0;
            temp |= (Convert.ToByte(!Properties.Settings.Default.SetAntiAliasingFilterAutomatically) << 7);
            //bit corresponds to sleepmode which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 6);
            //bit corresponds to interupts thing which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 5);
            //next bit corresponds to temperature as the 4th FIFO which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 4);
            //next bit corresponds to some FIFO thing which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 3);
            //next bit corresponds to disable I2C output which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 2);
            //next bit corresponds to auxilary SPI which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0 << 1);
            //next bit corresponds to FIFO threshold which at default is 0. this will not be accesible to user
            //temp |= (Convert.ToByte(0);
            msg.Add(Convert.ToByte(temp));

            //ctrl5
            //rounding and self test things
            msg.Add(0b00000000);

            //ctrl6
            //High performance and not modes for Accel.
            msg.Add(0);

            //ctrl7
            //High performance and not modes for Gyro. High pass filter cutt off frequency
            msg.Add(0);

            //ctrl8
            //Linear acceleration sensor control register 8
            */
            //+crc
            msg.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, msg.ToArray(), (uint)msg.Count)));
            //try send
            /*try
            {
                //sp.Write(msg.ToArray(), 0, msg.Count);
                EventHandler t = null;
                t = (a, b) => { sp.Write(msg.ToArray(), 0, msg.Count); getDataEvent -= t; };
                getDataEvent += t;
            }
            catch (Exception)
            {
                return;
            }*/
            sp.Write(msg.ToArray(), 0, msg.Count);
        }
        #region Methods
       
        #region Serial port data reception handlers
        private static void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (((MonoSerialPort)sender).BytesToRead == 0) return;

            var length = ((MonoSerialPort)sender).BytesToRead;
            byte[] buff = new byte[length];

            ((MonoSerialPort)sender).Read(buff, 0, length);
            receiveBuffer.AddRange(buff);
            if (receiveBuffer.Count < 5) return;
            var msg = receiveBuffer.GetRange(0, receiveBuffer.Count - 4).ToArray();

            var crc = new byte[4] { receiveBuffer[receiveBuffer.Count - 4], receiveBuffer[receiveBuffer.Count - 3], receiveBuffer[receiveBuffer.Count - 2], receiveBuffer[receiveBuffer.Count - 1] };
            var msgcrc = BitConverter.GetBytes(crc32_calc_buff(0, msg, (uint)msg.Length));

            if (((msgcrc[0] == crc[0] && msgcrc[1] == crc[1] && msgcrc[2] == crc[2] && msgcrc[3] == crc[3])))
            {
                ((MonoSerialPort)sender).DiscardInBuffer();
                responses.Add(new Response(receiveBuffer.ToArray()));
                receiveBuffer.Clear();

                if (responses.Last() != null && responses.Last().Access == Response.AccessType.Read)
                {
                    executionPass = ((responses.Count - 1 - (int)writeResponseCount) % 3);
                    getDataEvent?.Invoke(executionPass, EventArgs.Empty);

                    //form.TxtIn(executionPass);
                }
                else if (responses.Last().Access == Response.AccessType.Write) writeResponseCount++;
            }
        }
        private static void CheatDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (((MonoSerialPort)sender).BytesToRead == 0) return;

            var length = ((MonoSerialPort)sender).BytesToRead;
            byte[] buff = new byte[length];

            ((MonoSerialPort)sender).Read(buff, 0, length);
            receiveBuffer.AddRange(buff);
            if (receiveBuffer.Count < 5) return;
            var msg = receiveBuffer.GetRange(0, receiveBuffer.Count - 4).ToArray();

            var crc = new byte[4] { receiveBuffer[receiveBuffer.Count - 4], receiveBuffer[receiveBuffer.Count - 3], receiveBuffer[receiveBuffer.Count - 2], receiveBuffer[receiveBuffer.Count - 1] };
            var msgcrc = BitConverter.GetBytes(crc32_calc_buff(0, msg, (uint)msg.Length));

            if (((msgcrc[0] == crc[0] && msgcrc[1] == crc[1] && msgcrc[2] == crc[2] && msgcrc[3] == crc[3])))
            {
                ((MonoSerialPort)sender).DiscardInBuffer();
                responses.Add(new Response(receiveBuffer.ToArray()));
                receiveBuffer.Clear();

                if (responses.Last() != null && responses.Last().Access == Response.AccessType.Read)
                {
                    switch (LastResponse.MemoryAddress)
                    {
                        case 0x20:
                            ReturnTheValue(ValueSource.GyroX);
                            ReturnTheValue(ValueSource.GyroY);
                            ReturnTheValue(ValueSource.GyroZ);
                            ReturnTheValue(ValueSource.AccelerometerX);
                            ReturnTheValue(ValueSource.AccelerometerY);
                            ReturnTheValue(ValueSource.AccelerometerZ);
                            break;
                        case 0x90:
                            ReturnTheValue(ValueSource.IntegratedBatteryVoltage);
                            ReturnTheValue(ValueSource.BatteryVoltage);
                            ReturnTheValue(ValueSource.Preassure);
                            ReturnTheValue(ValueSource.IntegratedPreassure);
                            ReturnTheValue(ValueSource.Runtime);
                            ReturnTheValue(ValueSource.T1);
                            ReturnTheValue(ValueSource.InternalT1);
                            ReturnTheValue(ValueSource.T2);
                            ReturnTheValue(ValueSource.InternalT2);
                            ReturnTheValue(ValueSource.T3);
                            ReturnTheValue(ValueSource.InternalT3);
                            break;
                        case 0x80:
                            ReturnTheValue(ValueSource.Device1);
                            ReturnTheValue(ValueSource.Device2);
                            ReturnTheValue(ValueSource.Device3);
                            break;
                        default:
                            break;
                    }
                    //executionPass = ((responses.Count - 1 - (int)writeResponseCount) % 3);
                    executionPass++;
                    if (!isSetting) {
                        if (executionPass == 2) executionPass = 0;
                        getDataEvent?.Invoke(executionPass, EventArgs.Empty);
                    }
                    else
                    {
                        setDataEvent?.Invoke(null, EventArgs.Empty);
                    }
                }
                else if (responses.Last().Access == Response.AccessType.Write)
                {
                    writeResponseCount++;
                    isSetting = isSetting ? false : false;
                    setDataEvent =null;
                    getDataEvent?.Invoke(executionPass, EventArgs.Empty);
                }
            }
        }
        private static void ReturnTheValue(ValueSource sensor)
        {
            double value;
            var gyroRanges = new short[]{ 245, 500, 1000, 2000, 125 };
            var accelRanges = new short[]{ 2, 16, 4, 8};
            var info = LastResponse.GetReading(sensor);
            switch (sensor)
            {
                case ValueSource.IMUTemp:
                    value = (BitConverter.ToInt16(info, 0));
                    break;
                case ValueSource.GyroX:
                case ValueSource.GyroY:
                case ValueSource.GyroZ:
                    value = (((double)(BitConverter.ToInt16(info, 0) * gyroRanges[Properties.Settings.Default.GyroRange])) / short.MaxValue);
                    break;
                case ValueSource.AccelerometerX:
                case ValueSource.AccelerometerY:
                case ValueSource.AccelerometerZ:
                    value = (((double)(BitConverter.ToInt16(info, 0) * accelRanges[Properties.Settings.Default.AccelRange])) / short.MaxValue);
                    break;
                case ValueSource.Device1:
                    value = ((info[0] | 0b11111101) == 0b11111111) ? double.MaxValue : double.MinValue;
                    break;
                case ValueSource.Device2:
                    value = ((info[0] | 0b11111011) == 0b11111111) ? double.MaxValue : double.MinValue;
                    break;
                case ValueSource.Device3:
                    value = ((info[0] | 0b11110111) == 0b11111111) ? double.MaxValue : double.MinValue;
                    break;
                case ValueSource.T1:
                    value = (Convert14ToShort(info) * 0.25);
                    break;
                case ValueSource.InternalT1:
                    value = (Convert12ToShort(info) * 0.0625);
                    break;
                case ValueSource.T2:
                    value = (Convert14ToShort(info) * 0.25);
                    break;
                case ValueSource.InternalT2:
                    value = (Convert12ToShort(info) * 0.0625);
                    break;
                case ValueSource.T3:
                    value = (Convert14ToShort(info) * 0.25);
                    break;
                case ValueSource.InternalT3:
                    value = (Convert12ToShort(info) * 0.0625);
                    break;
                case ValueSource.Preassure:
                    value = ((BitConverter.ToUInt16(info, 0)) * 2.412);
                    break;
                case ValueSource.IntegratedPreassure:
                    value = (BitConverter.ToUInt16(info, 0) * 2.412);
                    break;
                case ValueSource.BatteryVoltage:
                    value = (BitConverter.ToUInt16(info, 0) * 1.206);
                    break;
                case ValueSource.IntegratedBatteryVoltage:
                    value = (BitConverter.ToUInt16(info, 0) * 1.206);
                    break;
                case ValueSource.Runtime:
                    value = (BitConverter.ToUInt32(info, 0) * 0.01);
                    break;
                default:
                    value = double.NaN;
                    break;
            }
            //form.Receive(value, sensor);
            Form1.inst.Receive(value, sensor);
            //Thread t = new Thread(new ParameterizedThreadStart(Form1.inst.Receive));
            //t.Start(new KeyValuePair<ValueSource,double>(sensor,value));
            //return t;
        }
        #endregion
        #region Get methods
        /// <summary>
        /// Sends request for retrieval of only one sensors data. Not recommended since the data reception handlers may not process the response correctly, thus calling the function may bear no fruit.
        /// </summary>
        /// <param name="sensor">Sensor of which the data is to be received</param>
        /// <returns>The most recent available reading of the specified sensor.</returns>
        public static object GetValue(ValueSource sensor)
        {
            List<byte> msg = new List<byte>("A5 5A 00 80 61".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            //+ address
            switch (sensor)
            {
                case ValueSource.Device1:
                case ValueSource.Device2:
                case ValueSource.Device3:
                    msg.Add((byte)0x80);
                    break;
                case ValueSource.T1:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT1:
                    msg.Add((byte)0x92);
                    break;
                case ValueSource.T2:
                    msg.Add((byte)0x94);
                    break;
                case ValueSource.InternalT2:
                    msg.Add((byte)0x96);
                    break;
                case ValueSource.T3:
                    msg.Add((byte)0x98);
                    break;
                case ValueSource.InternalT3:
                    msg.Add((byte)0x9A);
                    break;
                case ValueSource.Preassure:
                    msg.Add((byte)0x9C);
                    break;
                case ValueSource.IntegratedPreassure:
                    msg.Add((byte)0xA8);
                    break;
                case ValueSource.BatteryVoltage:
                    msg.Add((byte)0x9E);
                    break;
                case ValueSource.IntegratedBatteryVoltage:
                    msg.Add((byte)0xAA);
                    break;
                case ValueSource.Runtime:
                    msg.Add((byte)0xA0);
                    break;
                default:
                    break;
            }
            //+ data cnt
            msg.Add(0x01);
            //+ data
            switch (sensor)
            {
                case ValueSource.Device1:
                case ValueSource.Device2:
                case ValueSource.Device3:
                    msg.Add((byte)0x01);
                    break;
                case ValueSource.T1:
                case ValueSource.InternalT1:
                case ValueSource.T2:
                case ValueSource.InternalT2:
                case ValueSource.T3:
                case ValueSource.InternalT3:
                case ValueSource.Preassure:
                case ValueSource.IntegratedPreassure:
                case ValueSource.BatteryVoltage:
                case ValueSource.IntegratedBatteryVoltage:
                    msg.Add(0x02);
                    break;
                case ValueSource.Runtime:
                    msg.Add((byte)0x04);
                    break;
                default:
                    break;
            }

            //+ crc
            msg.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, msg.ToArray(), (uint)msg.Count)));

            //send request
            try
            {
                sp.Write(msg.ToArray(), 0, msg.Count);
                //sp.SendMessage(msg.ToArray());
            }
            catch (Exception)
            {
                return false;
            }
            return LastResponse.GetReading(sensor);
        }

        /// <summary>
        /// Reads one of three areas of memory containing the readings and invokes Receive(reading, sender) method in Form1. since a broad area of memory is read calling the method GetUsingLast() is recommended to retrieve other readings that were received. 
        /// </summary>
        /// <param name="sensor">The sensor with which the Receive(reading, device) method in Form1 will be invoked.</param>
        /// <param name="executionIndex">Used for reading the data in quick succession.</param>
        public static void GetOptimizedReading(ValueSource sensor, int executionIndex = 0)
        {
            List<byte> msg = new List<byte>("A5 5A 00 80 61".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            //+ address
            switch (sensor)
            {
                case ValueSource.IMUTemp:
                case ValueSource.GyroX:
                case ValueSource.GyroY:
                case ValueSource.GyroZ:
                case ValueSource.AccelerometerX:
                case ValueSource.AccelerometerY:
                case ValueSource.AccelerometerZ:
                    msg.Add(0x20);
                    break;
                case ValueSource.Device1:
                case ValueSource.Device2:
                case ValueSource.Device3:
                    msg.Add((byte)0x80);
                    break;
                case ValueSource.T1:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT1:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.T2:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT2:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.T3:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT3:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.Preassure:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.IntegratedPreassure:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.BatteryVoltage:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.IntegratedBatteryVoltage:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.Runtime:
                    msg.Add((byte)0x90);
                    break;
                default:
                    break;
            }
            //+ data cnt
            msg.Add(0x01);
            //+ data
            msg.Add(0x20);
            //+ crc
            msg.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, msg.ToArray(), (uint)msg.Count)));

            if (isCheating)
            {
                sp.DataReceived -= CheatDataReceived;
                sp.DataReceived += Sp_DataReceived;
                isCheating = false;
            }


            //send request
            try
            {
                if (executionIndex == 0)
                {
                    sp.Write(msg.ToArray(), 0, msg.Count);
                }
                else if (executionIndex != 0)
                {
                    EventHandler temp = null;
                    temp = (a, b) => { if ((int)a == executionIndex - 1) { sp.Write(msg.ToArray(), 0, msg.Count); getDataEvent -= temp; } };
                    getDataEvent += temp;
                }
            }
            catch (Exception)
            {
                return;
            }
            EventHandler t = null;
            t = (a, b) => { if ((int)a == executionIndex) { ReturnTheValue(sensor); getDataEvent -= t; } };
            getDataEvent += t;
        }

        /// <summary>
        /// Reads one of three areas of memory containing the readings and invokes Receive(reading, sender) method in Form1 with all the devices present in the block of memory read.
        /// </summary>
        /// <param name="sensor">The sensor indicating which area of memory to read.</param>
        /// <param name="executionIndex">Used for reading the data in quick succession.</param>
        public static void GetReadings(ValueSource sensor, int executionIndex = 0)
        {
            List<byte> msg = new List<byte>("A5 5A 00 80 61".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            //+ address
            switch (sensor)
            {
                case ValueSource.IMUTemp:
                case ValueSource.GyroX:
                case ValueSource.GyroY:
                case ValueSource.GyroZ:
                case ValueSource.AccelerometerX:
                case ValueSource.AccelerometerY:
                case ValueSource.AccelerometerZ:
                    msg.Add(0x20);
                    break;
                case ValueSource.Device1:
                case ValueSource.Device2:
                case ValueSource.Device3:
                    msg.Add((byte)0x80);
                    break;
                case ValueSource.T1:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT1:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.T2:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT2:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.T3:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.InternalT3:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.Preassure:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.IntegratedPreassure:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.BatteryVoltage:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.IntegratedBatteryVoltage:
                    msg.Add((byte)0x90);
                    break;
                case ValueSource.Runtime:
                    msg.Add((byte)0x90);
                    break;
                default:
                    break;
            }
            //+ data cnt
            msg.Add(0x01);
            //+ data
            msg.Add(0x20);
            //+ crc
            msg.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, msg.ToArray(), (uint)msg.Count)));

            if (!isCheating)
            {
                sp.DataReceived -= Sp_DataReceived;
                sp.DataReceived += CheatDataReceived;
                isCheating = true;
            }

            //send request
            try
            {
                if (executionIndex == 0)
                {
                    sp.Write(msg.ToArray(), 0, msg.Count);
                }
                else if (executionIndex != 0)
                {
                    EventHandler temp = null;
                    temp = (a, b) => { if ((int)a == executionIndex - 1) { sp.Write(msg.ToArray(), 0, msg.Count); getDataEvent -= temp; } };
                    getDataEvent += temp;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        /// <summary>
        /// Invokes Receive(reading, sender) method in Form1 with the specified sensor and the reading extracted from the last response. (if the last response does not contain the sensor's data null is returned)
        /// </summary>
        /// <param name="returnSensor">The sensor with which the Receive(reading, device) method in Form1 will be invoked.</param>
        /// <param name="executionIndex">Used for reading the data in quick succession.</param>
        public static void GetUsingLastReading(ValueSource returnSensor, int executionIndex = 0)
        {
            EventHandler t = null;
            t = (a, b) => { if ((int)a == executionIndex) { ReturnTheValue(returnSensor); getDataEvent -= t; } };
            getDataEvent += t;
        }
        #endregion
        #region Set methods
        public static bool SetValue(SetDevice[] devices, bool value)
        {
            List<byte> msg = new List<byte>("A5 5A 00 00 16".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            msg.Add(value ? Convert.ToByte(0x82) : Convert.ToByte(0x81));
            msg.Add(1);
            byte temp = 0;
            foreach (var item in devices)
            {
                switch (item)
                {
                    case SetDevice.Out12V:
                        temp |= 0b00000001;
                        break;
                    case SetDevice.Out1:
                        temp |= 0b00000010;
                        break;
                    case SetDevice.Out2:
                        temp |= 0b00000100;
                        break;
                    case SetDevice.Out3:
                        temp |= 0b00001000;
                        break;
                    default:
                        break;
                }
            }
            msg.Add(temp);

            msg.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, msg.ToArray(), (uint)msg.Count)));
            //send request old way
            /*try
            {
                //sp.Write(msg.ToArray(), 0, msg.Count);
                EventHandler t = null;
                t = (a, b) => { sp.Write(msg.ToArray(), 0, msg.Count); getDataEvent -= t; };
                getDataEvent += t;
            }
            catch (Exception)
            {
                return false;
            }*/
            //send Request new way
            try
            {
                //sp.Write(msg.ToArray(), 0, msg.Count);
                EventHandler t = null;
                t = (a, b) => { sp.Write(msg.ToArray(), 0, msg.Count); };
                setDataEvent += t;
                isSetting = true;
            }
            catch (Exception)
            {
                return false;
            }
            //"A5 5A 00 00 16 82 01 04 8D B2 9F 89"
            return true;
        }
        public static void StartIMU()
        {
            List<byte> info = new List<byte>("A5 5A 00 00 16 10 02 10 10".Split(' ').Select(s => byte.Parse(s, style: System.Globalization.NumberStyles.HexNumber)));
            info.AddRange(BitConverter.GetBytes(crc32_calc_buff(0, info.ToArray(), (uint)info.Count)));
            sp.Write(info.ToArray(), 0, info.Count);
        }
        #endregion
        #region Converters for temperature
        private static short Convert14ToShort(byte[] info)
        {
            if ((info[0] | 0b11111110) == 0b11111111)
            {
                //MessageBox.Show("An error has occured.\nPlease check whether temperature sensors are ok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return short.MinValue;
            }

            var temp = (BitConverter.ToInt16(info, 0));
            temp >>= 2;
            return temp;
        }
        private static short Convert12ToShort(byte[] info)
        {
            if ((info[0] | 0b11111110) == 0b11111111)
            {
                //MessageBox.Show("An error has occured.\nPlease check whether all temperature sensors have contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return short.MinValue;
            }
            if ((info[0] | 0b11111101) == 0b11111111)
            {
                //MessageBox.Show("An error has occured.\nPlease check whether any of temperature sensors have short circuit at gnd.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return short.MinValue;
            }
            if ((info[0] | 0b11111011) == 0b11111111)
            {
                //MessageBox.Show("An error has occured.\nPlease check whether any of temperature sensors have short circuit at 3V3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return short.MinValue;
            }
            return ((short)(BitConverter.ToInt16(info, 0) >> 4));
        }
        #endregion

        //algorithm provided by the client
        #region CheckSum
        static uint[] checksumTable = {
  0x00000000, 0x77073096, 0xEE0E612C, 0x990951BA, 0x076DC419, 0x706AF48F, 0xE963A535, 0x9E6495A3,
  0x0EDB8832, 0x79DCB8A4, 0xE0D5E91E, 0x97D2D988, 0x09B64C2B, 0x7EB17CBD, 0xE7B82D07, 0x90BF1D91,
  0x1DB71064, 0x6AB020F2, 0xF3B97148, 0x84BE41DE, 0x1ADAD47D, 0x6DDDE4EB, 0xF4D4B551, 0x83D385C7,
  0x136C9856, 0x646BA8C0, 0xFD62F97A, 0x8A65C9EC, 0x14015C4F, 0x63066CD9, 0xFA0F3D63, 0x8D080DF5,
  0x3B6E20C8, 0x4C69105E, 0xD56041E4, 0xA2677172, 0x3C03E4D1, 0x4B04D447, 0xD20D85FD, 0xA50AB56B,
  0x35B5A8FA, 0x42B2986C, 0xDBBBC9D6, 0xACBCF940, 0x32D86CE3, 0x45DF5C75, 0xDCD60DCF, 0xABD13D59,
  0x26D930AC, 0x51DE003A, 0xC8D75180, 0xBFD06116, 0x21B4F4B5, 0x56B3C423, 0xCFBA9599, 0xB8BDA50F,
  0x2802B89E, 0x5F058808, 0xC60CD9B2, 0xB10BE924, 0x2F6F7C87, 0x58684C11, 0xC1611DAB, 0xB6662D3D,
  0x76DC4190, 0x01DB7106, 0x98D220BC, 0xEFD5102A, 0x71B18589, 0x06B6B51F, 0x9FBFE4A5, 0xE8B8D433,
  0x7807C9A2, 0x0F00F934, 0x9609A88E, 0xE10E9818, 0x7F6A0DBB, 0x086D3D2D, 0x91646C97, 0xE6635C01,
  0x6B6B51F4, 0x1C6C6162, 0x856530D8, 0xF262004E, 0x6C0695ED, 0x1B01A57B, 0x8208F4C1, 0xF50FC457,
  0x65B0D9C6, 0x12B7E950, 0x8BBEB8EA, 0xFCB9887C, 0x62DD1DDF, 0x15DA2D49, 0x8CD37CF3, 0xFBD44C65,
  0x4DB26158, 0x3AB551CE, 0xA3BC0074, 0xD4BB30E2, 0x4ADFA541, 0x3DD895D7, 0xA4D1C46D, 0xD3D6F4FB,
  0x4369E96A, 0x346ED9FC, 0xAD678846, 0xDA60B8D0, 0x44042D73, 0x33031DE5, 0xAA0A4C5F, 0xDD0D7CC9,
  0x5005713C, 0x270241AA, 0xBE0B1010, 0xC90C2086, 0x5768B525, 0x206F85B3, 0xB966D409, 0xCE61E49F,
  0x5EDEF90E, 0x29D9C998, 0xB0D09822, 0xC7D7A8B4, 0x59B33D17, 0x2EB40D81, 0xB7BD5C3B, 0xC0BA6CAD,
  0xEDB88320, 0x9ABFB3B6, 0x03B6E20C, 0x74B1D29A, 0xEAD54739, 0x9DD277AF, 0x04DB2615, 0x73DC1683,
  0xE3630B12, 0x94643B84, 0x0D6D6A3E, 0x7A6A5AA8, 0xE40ECF0B, 0x9309FF9D, 0x0A00AE27, 0x7D079EB1,
  0xF00F9344, 0x8708A3D2, 0x1E01F268, 0x6906C2FE, 0xF762575D, 0x806567CB, 0x196C3671, 0x6E6B06E7,
  0xFED41B76, 0x89D32BE0, 0x10DA7A5A, 0x67DD4ACC, 0xF9B9DF6F, 0x8EBEEFF9, 0x17B7BE43, 0x60B08ED5,
  0xD6D6A3E8, 0xA1D1937E, 0x38D8C2C4, 0x4FDFF252, 0xD1BB67F1, 0xA6BC5767, 0x3FB506DD, 0x48B2364B,
  0xD80D2BDA, 0xAF0A1B4C, 0x36034AF6, 0x41047A60, 0xDF60EFC3, 0xA867DF55, 0x316E8EEF, 0x4669BE79,
  0xCB61B38C, 0xBC66831A, 0x256FD2A0, 0x5268E236, 0xCC0C7795, 0xBB0B4703, 0x220216B9, 0x5505262F,
  0xC5BA3BBE, 0xB2BD0B28, 0x2BB45A92, 0x5CB36A04, 0xC2D7FFA7, 0xB5D0CF31, 0x2CD99E8B, 0x5BDEAE1D,
  0x9B64C2B0, 0xEC63F226, 0x756AA39C, 0x026D930A, 0x9C0906A9, 0xEB0E363F, 0x72076785, 0x05005713,
  0x95BF4A82, 0xE2B87A14, 0x7BB12BAE, 0x0CB61B38, 0x92D28E9B, 0xE5D5BE0D, 0x7CDCEFB7, 0x0BDBDF21,
  0x86D3D2D4, 0xF1D4E242, 0x68DDB3F8, 0x1FDA836E, 0x81BE16CD, 0xF6B9265B, 0x6FB077E1, 0x18B74777,
  0x88085AE6, 0xFF0F6A70, 0x66063BCA, 0x11010B5C, 0x8F659EFF, 0xF862AE69, 0x616BFFD3, 0x166CCF45,
  0xA00AE278, 0xD70DD2EE, 0x4E048354, 0x3903B3C2, 0xA7672661, 0xD06016F7, 0x4969474D, 0x3E6E77DB,
  0xAED16A4A, 0xD9D65ADC, 0x40DF0B66, 0x37D83BF0, 0xA9BCAE53, 0xDEBB9EC5, 0x47B2CF7F, 0x30B5FFE9,
  0xBDBDF21C, 0xCABAC28A, 0x53B39330, 0x24B4A3A6, 0xBAD03605, 0xCDD70693, 0x54DE5729, 0x23D967BF,
  0xB3667A2E, 0xC4614AB8, 0x5D681B02, 0x2A6F2B94, 0xB40BBE37, 0xC30C8EA1, 0x5A05DF1B, 0x2D02EF8D
};
        private static uint crc32_calc_buff(uint crc, byte[] buff, uint len)
        {
            /* XOR'inama pradine reiksme. */
            crc ^= 0xFFFFFFFF;
            int i = 0;
            /* Skaiciuojama viso buferio CRC32 reiksme. */
            while (len-- > 0)
            {
                crc = ((crc >> 8) ^ checksumTable[((byte)crc ^ buff[i])]);
                i++;
            }
            /* XOR'inama galutine reiksme. */
            return (crc ^ ((uint)0xFFFFFFFF));
        }
        #endregion
        #endregion
    }
}
