using System;
using System.Collections.Generic;
using System.Text;
using static CSInternal.Communicator;

namespace CSInternal
{
    class Response
    {
        public enum AccessType
        {
            Write,
            Read
        }
        public Response() { }
        public Response(byte[] bytes)
        {
           // ((Form1)System.Windows.Forms.Form.ActiveForm).TxtIn(Convert.ToString(bytes[5], 16));
            data = bytes;
        }
        
        byte[] data;
        public AccessType Access { get { return (data[3] == 0b00000000) ? AccessType.Write : AccessType.Read; } }
        public byte MemoryAddress { get { return data[5]; } }
        public byte[] GetReading()
        {
            var temp = new byte[data[6]];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = data[7 + i];
            }
            return temp;
        }
        public byte[] GetReading(byte memoryAddress, byte length)
        {
            //Address data[5]
            //length data[6]
            // System.Windows.Forms.MessageBox.Show(data.Length.ToString());
            if (memoryAddress >= data[5] && memoryAddress + length <= data[5] + data[6]) //check wheather the value for the memory address is contained among the data
            {
                var temp = new byte[length];
                var startIndex = memoryAddress - data[5] + 7;//instead of +7 was +5
                for (int i = 0; i < length; i++)
                {
                    temp[i] = data[startIndex + i];
                }
                return temp;
            }
            else return new byte[length];

        }
        public byte[] GetReading(ValueSource device)
        {
            switch (device)
            {
                case ValueSource.IMUTemp:
                    return GetReading(0x20, 2);
                case ValueSource.GyroX:
                    return GetReading(0x22, 2);
                case ValueSource.GyroY:
                    return GetReading(0x24, 2);
                case ValueSource.GyroZ:
                    return GetReading(0x26, 2);
                case ValueSource.AccelerometerX:
                    return GetReading(0x28, 2);
                case ValueSource.AccelerometerY:
                    return GetReading(0x2A, 2);
                case ValueSource.AccelerometerZ:
                    return GetReading(0x2C, 2);
                case ValueSource.Device1:
                case ValueSource.Device2:
                case ValueSource.Device3:
                    return GetReading(0x80, 1);
                case ValueSource.T1:
                    return GetReading(0x90, 2);
                case ValueSource.InternalT1:
                    return GetReading(0x92, 2);
                case ValueSource.T2:
                    return GetReading(0x94, 2);
                case ValueSource.InternalT2:
                    return GetReading(0x96, 2);
                case ValueSource.T3:
                    return GetReading(0x98, 2);
                case ValueSource.InternalT3:
                    return GetReading(0x9A, 2);
                case ValueSource.Preassure:
                    return GetReading(0x9C, 2);
                case ValueSource.IntegratedPreassure:
                    return GetReading(0xA8, 2);
                case ValueSource.BatteryVoltage:
                    return GetReading(0x9E, 2);
                case ValueSource.IntegratedBatteryVoltage:
                    return GetReading(0xAA, 2);
                case ValueSource.Runtime:
                    return GetReading(0xA0, 4);
            }
            System.Windows.Forms.MessageBox.Show("An Error has occured.\n Please report it to the people responsible.", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            return null;
        }
    }
}
