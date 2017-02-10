using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program1
    {
        //static variable
        static int x;

        public static void Main()
        {
            x = 5;
            PrintX();

//            int x = 5;
//            PrintX(x);
        }

        public static void PrintX()
        {
            Console.WriteLine(x);
        }
    }
}
