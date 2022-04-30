using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Bus : Vehicle
    {
        public int NumOfSeats { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tNumber of seats: " + NumOfSeats);
        }
    }
}
