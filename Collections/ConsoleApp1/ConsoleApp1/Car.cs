using System;
using System.Xml.Serialization;

namespace Collections
{
    public class Car : Vehicle
    {
        public double Weight { get; set; }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\tWeight: " + Weight);
        }
    }
}
