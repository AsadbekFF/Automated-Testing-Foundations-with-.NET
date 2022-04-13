using System;

namespace Transports
{
    public class Truck
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
        public int WheelSize { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Bus\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "Wheel size: " + WheelSize);
        }
    }
}
