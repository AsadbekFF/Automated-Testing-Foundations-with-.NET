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
            Random random = new();
            return new Coordinate
            {
                x = random.Next(),
                y = random.Next(),
                z = random.Next()
            };

            // Generating non-negative Coordinate
        }
    }
}
