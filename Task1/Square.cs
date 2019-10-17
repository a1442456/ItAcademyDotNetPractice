using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Square : ISquarable
    {
        private double _side;

        public Square(double side)
        {
            _side = side;
        }

        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public double GetSquare()
        {
            return _side * _side;
        }
    }
}
