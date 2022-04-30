using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public class Vehicle
    {
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }
    }
}
