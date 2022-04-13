using System;

namespace Interface
{
    public class Bird : IFlyable
    {
        public Bird()
        {
            CurrentLocation = Coordinate.GenerateCoordination();    
        }

        private readonly int Speed = new Random().Next(0, 20);
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

            if (length / Speed > 24)
            {
                return 24;
            }
            else
            {
                return length / Speed;
            }
            // Can't fly over than 24 hours.
        }
    }
}
