using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(10, 10);
            Cycle cycle = new Cycle(10);
            Square square = new Square(10);

            List<ISquarable> listShapes = new List<ISquarable>();
            listShapes.Add(triangle);
            listShapes.Add(cycle);
            listShapes.Add(square);

            foreach (ISquarable squarable in listShapes)
            {
                Console.WriteLine(squarable.ToString());
                Console.WriteLine(squarable.GetSquare().ToString());
            }

            Console.ReadLine();
        }
    }
}
