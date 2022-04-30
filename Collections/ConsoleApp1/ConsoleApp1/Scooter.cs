using System;

namespace Collections
{
    public class Scooter : Vehicle
    {
        public bool ExtraSeat { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tIs extra seat exist: " + ExtraSeat);
        }
    }
}
