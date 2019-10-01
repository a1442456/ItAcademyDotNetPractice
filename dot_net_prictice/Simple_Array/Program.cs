using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[6];
            Random rnd = new Random();

            Console.WriteLine("Enter elements");
            for (int index = 0; index < myArray.Length; index++)
                myArray[index] = rnd.Next(1, 999);

            PrintArray(myArray);

            myArray[2] *= 10;

            PrintArray(myArray);

            Console.WriteLine("Lowest value");
            Console.WriteLine(myArray.Min().ToString());

            Console.ReadLine();
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Printing Array");
            foreach (int item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
