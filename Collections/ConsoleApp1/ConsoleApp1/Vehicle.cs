using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collections
{
    [XmlInclude(typeof(Car), Type = typeof(Car))]
    [XmlInclude(typeof(Bus), Type = typeof(Bus))]
    [XmlInclude(typeof(Scooter), Type = typeof(Scooter))]
    [XmlInclude(typeof(Truck), Type = typeof(Truck))]
    [Serializable]
    public class Vehicle
    {
        [XmlElement]
        public Engine Engine { get; set; }
        [XmlElement]
        public Chassis Chassis { get; set; }
        [XmlElement]
        public Transmission Transmission { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{this.GetType().Name}"
                    + "\n\t" + Engine.ToString()
                    + "\n\t" + Chassis.ToString()
                    + "\n\t" + Transmission.ToString()
                    );
        }
    }
}
