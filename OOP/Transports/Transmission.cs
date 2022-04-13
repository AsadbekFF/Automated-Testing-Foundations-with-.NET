using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports
{
    public class Transmission
    {
        public string Type { get; set; }
        public int NumOfGears { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"Transmission" +
                $"\n\t\tType: {Type}" +
                $"\n\t\tNumber of gears: {NumOfGears}" +
                $"\n\t\tManufacturer: {Manufacturer}";
        }
    }
}
