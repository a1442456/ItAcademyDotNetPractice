using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cycle : ISquarable
    {
        const double Pi = 3.14;

        private double _radius;

        public Cycle(double radius)
        {
            _radius = radius;
        }
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public double GetSquare()
        {
            return Pi * Math.Pow(_radius, 2);
        }
    }
}
