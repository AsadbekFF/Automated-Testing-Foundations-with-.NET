using System;

namespace Transports
{
    public class Bus : Vehicle
    {
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
