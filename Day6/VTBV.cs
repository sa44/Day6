﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class VTBV
    {
        public static void Main()
        {
            int a = 100;
            Console.WriteLine("Before method call, a = {0}", a);
            multiply(a, 2);
            Console.WriteLine("After method call, a = {0}", a);
        }

        public static void multiply(int x, int multiplier)
        {
            x = x * multiplier;
            Console.WriteLine("x={0}", x);
        }
    }
}
