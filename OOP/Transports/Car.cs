using System;

namespace Transports
{
    public class Car : Vehicle
    {
        public double Weight { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Bus\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "Weight: " + Weight);
        }
    }
}
