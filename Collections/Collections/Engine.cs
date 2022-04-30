using System;
using System.Xml.Serialization;

namespace Collections
{
    public class Engine
    {
        public double Power { get; set; }
        public double Capacity { get; set; }
        public string Type { get; set; }
        public int SerialNumber { get; set; }
        public override string ToString()
        {
            return $"Engine" +
                $"\n\t\tPower: {Power}" +
                $"\n\t\tVolume: {Capacity}" +
                $"\n\t\tType: {Type}" +
                $"\n\t\tSerial Number: {SerialNumber}\n";
        }
    }
}