using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dot_net_prictice
{
    class Program
    {
        const string GREETING1 = "Good morning, guys";
        const string GREETING2 = "Good day, guys";
        const string GREETING3 = "Good evening, guys ";
        const string GREETING4 = "Good night, guys";
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            if (currentDate.Hour >= 9 && currentDate.Hour < 12)
            {
                Console.WriteLine(GREETING1);
            }
            else if (currentDate.Hour >= 12 && currentDate.Hour < 15)
            {
                Console.WriteLine(GREETING2);
            }
            else if (currentDate.Hour >= 15 && currentDate.Hour < 22)
            {
                Console.WriteLine(GREETING3);
            }
            else
            {
                Console.WriteLine(GREETING4);
            }
            Console.ReadLine();
        }
    }
}
