using System;

namespace Transports
{
    public class Scooter
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }
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
