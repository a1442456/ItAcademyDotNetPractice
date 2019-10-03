using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_6_task
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask1();
            RunTask2();
            RunTask3();
            RunTask4();

            Console.ReadLine();
        }

        static void RunTask1()
        {
            Console.WriteLine("Task1");
            int[] myArray = new int[10]; //Can't create without lenght :(
            try
            {

                foreach (int item in myArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static void RunTask2()
        {
            Console.WriteLine("Task2");
            int num = 32;
            char sign = 'A';
            string text = "Hello";

            object[] myArray = new object[3] { num, sign, text };
            foreach (object item in myArray)
            {
                Console.WriteLine(item.ToString());
            }

            
        }

        static void RunTask3()
        {
            Console.WriteLine("Task3");
            int[] myArray = new int[13];
            Random rnd = new Random();

            Console.WriteLine("Autofilling array...");
            for (int index = 0; index < myArray.Length; index++)
            {
                myArray[index] = rnd.Next(1, 999);
            }


            Console.WriteLine("Printing array...");
            foreach (int item in myArray)
            {
                Console.Write(string.Format("{0} ", item));
            }

            Console.WriteLine(string.Format("\nMin value is:{0}", myArray.Min()));
        }

        static void RunTask4()
        {
            short _short = 2;
            object objShort = (object)_short;//Boxing
            //sbyte newShort = (sbyte)objShort; Cant convert from short to sbyte cz short is larger than sbyte type

            Console.WriteLine(string.Format("Type:{0} Value:{1}", _short.GetType(), _short.ToString()));
            Console.WriteLine(string.Format("Type:{0} Value:{1}", objShort.GetType(), objShort.ToString()));
            //Console.WriteLine(string.Format("Type:{0} Value:{1}", newShort.GetType(), newShort.ToString()));
        }
    }
}
