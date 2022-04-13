using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    class Chassis
    {
        public int NumOfWheels { get; set; }
        public int Number { get; set; }
        public double LoadCapacity { get; set; }
        public override string ToString()
        {
            return $"Chassis\n\tNumber of Wheels: {NumOfWheels}\n\tNumber: {Number}\n\tLoad capacity: {LoadCapacity}";
        }
    }
}
