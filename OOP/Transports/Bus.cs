using System;

namespace Transports
{
    public class Bus
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }
        public int NumOfSeats { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("Bus\n\t"
                + Engine.ToString()
                + "\n\t" + Chassis.ToString()
                + "\n\t" + Transmission.ToString()
                + "Number of seats: " + NumOfSeats);
        }
    }
}
