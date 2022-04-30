using System;
using System.Xml.Serialization;

namespace Collections
{
    public class Chassis
    {
        public int NumOfWheels { get; set; }
        public int Number { get; set; }
        public double LoadCapacity { get; set; }
        public override string ToString()
        {
            return $"Chassis" +
                $"\n\t\tNumber of Wheels: {NumOfWheels}" +
                $"\n\t\tNumber: {Number}" +
                $"\n\t\tLoad capacity: {LoadCapacity}\n";
        }
    }
}