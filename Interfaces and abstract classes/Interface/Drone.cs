using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Drone : IFlyable
    {
        private readonly int Speed = 100;
        public Drone()
        {
            CurrentLocation = Coordinate.GenerateCoordination();
        }

        public Coordinate CurrentLocation { get; set; }

        public void FlyTo(Coordinate coordinate)
        {
            CurrentLocation = coordinate;
        }

        public double GetFlyTime(Coordinate coordinate)
        {
            double length = Math.Sqrt(Math.Pow(coordinate.x - CurrentLocation.x, 2)
                + Math.Pow(coordinate.y - CurrentLocation.y, 2)
                + Math.Pow(coordinate.z - CurrentLocation.z, 2));

            if (length > 1000)
            {
                return 1000 / Speed
                    + 1000 / (Speed * 10);
            }
            else
            {
                return length
                    / Speed
                    + length
                    / (Speed * 10);
            }
            // Can't fly over than 1000 km.
        }
    }
}
