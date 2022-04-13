﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    class Bus
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }
        public int NumOfSeats { get; set; }
    }
}
