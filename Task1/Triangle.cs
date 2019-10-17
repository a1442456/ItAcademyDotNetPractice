using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Triangle : ISquarable
    {
        private double _baseline;
        private double _height;

        public Triangle(double baseline, double height)
        {
            _baseline = baseline;
            _height = height;
        }

        public double Baseline
        {
            get { return _baseline; }
            set { _baseline = value; }
        }

        

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }



        public double GetSquare()
        {
            return (_baseline * _height) / 2;
        }
    }
}
