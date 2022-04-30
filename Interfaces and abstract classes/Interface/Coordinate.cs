using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public struct Coordinate
    {
        public Coordinate(int initialRange, int endRange)
        {
            Random random = new();
            x = random.Next(0, 100);
            y = random.Next(0, 100);
            z = random.Next(0, 100);
        }

        public int x;
        public int y;
        public int z;
    }
}
