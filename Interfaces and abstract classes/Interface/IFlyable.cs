using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFlyable
    {
        public void FlyTo(Coordinate coordinate);

        public double GetFlyTime(Coordinate coordinate);
    }
}
