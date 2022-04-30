using System;

namespace Collections
{
    public class Truck : Vehicle
    {
        public int WheelSize { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tWheel size: " + WheelSize);
        }
    }
}
