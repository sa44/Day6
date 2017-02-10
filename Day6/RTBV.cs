using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class RTBV
    {
        public static void Main()
        {
            int[] a = new int[] { 100, 200 };

            Console.Write("Before method call, a = ");
            PrintArray(a);

            multiply(a, 2);

            Console.Write("After method call, a = ");
            PrintArray(a);

            expand(a);

            Console.Write("After expand, a = ");
            PrintArray(a);
        }

        public static void multiply(int[] x, int multiplier)
        {
            x[0] = x[0] * multiplier;
            x[1] = x[1] * multiplier;
            Console.Write("x=");
            PrintArray(x);
        }

        public static void expand(int[] x)
        {
            int[] y = new int[3];
            y[0] = x[0];
            y[1] = x[1];
            y[2] = 999;

            x = y;
            Console.Write("x after expand = ");
            PrintArray(x);
        }

        public static void PrintArray(int[] a)
        {
            Console.Write("{");
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0) Console.Write(",");
                Console.Write("{0}", a[i]);
            }
            Console.WriteLine("}");
        }
    }
}
