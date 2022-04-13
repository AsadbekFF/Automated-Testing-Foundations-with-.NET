using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Airplane : IFlyable
    {
        public Airplane()
        {
            CurrentLocation = Coordinate.GenerateCoordination();
        }

        private int speed;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 700)
                {
                    speed = 700;
                }
                else
                {
                    speed = value;
                }
            }
        }
        // The speed of airplane can't get over than 700 km/s.

        public Coordinate CurrentLocation { get; set; }
        public void FlyTo(Coordinate coordinate)
        {
            CurrentLocation = coordinate;
        }

        public double GetFlyTime(Coordinate coordinate)
        {
            int acceleration = speed;
            int time = 1;
            double length = Math.Sqrt(Math.Pow(coordinate.x - CurrentLocation.x, 2)
                + Math.Pow(coordinate.y - CurrentLocation.y, 2)
                + Math.Pow(coordinate.z - CurrentLocation.z, 2));
            while ((speed * time) - (acceleration) * time * time / 2 < length)
            {
                time++;
                speed += acceleration;
            }

            return time;
        }
    }
}
