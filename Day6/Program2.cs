using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program2
    {
        public static void Main()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a={0} b={1}", a, b);

            Swap(ref a, ref b);
            Console.WriteLine("a={0} b={1}", a, b);
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
