using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public int z;

        public static Coordinate GenerateCoordination()
        {
            Random random = new Random();
            return new Coordinate
            {
                x = random.Next(0, 100),
                y = random.Next(0, 100),
                z = random.Next(0, 100)
            };
        }
    }
}
