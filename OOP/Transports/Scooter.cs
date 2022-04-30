using System;

namespace Transports
{
    public class Scooter : Vehicle
    {
        public bool ExtraSeat { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Bus\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "Is extra seat exist: " + ExtraSeat);
        }
    }
}
