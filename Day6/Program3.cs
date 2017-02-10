using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        public static void Main()
        {
            int[] a = new int[] { 1, 2 };
            a = new int[5];
            ExpandArray(ref a, 5);

            a[2] = 100;
            a[3] = 200;
            a[4] = 300;
            RTBR.PrintArray(a);

            ExpandArray(ref a, 10);
            RTBR.PrintArray(a);
        }

        public static void ExpandArray(ref int[] x, int newsize)
        {
            int[] y = new int[newsize];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i];
            }
            x = y;
        }
    }
}
