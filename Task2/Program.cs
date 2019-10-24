using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123456678";
            Console.WriteLine(str.MyNewMethod());
            Console.ReadLine();
        }
    }

    static class MyOwnString
    {
        public static string MyNewMethod(this String str)
        {
            str = str.Substring(0, 5);
            str += "...";
            return str;
        }
    }
}
