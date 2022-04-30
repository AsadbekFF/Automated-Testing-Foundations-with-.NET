using System;

namespace Transports
{
    public class Truck : Vehicle
    {
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
