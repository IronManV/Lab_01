﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 49;
            do
            {
                Console.WriteLine(num);
                num = num - 2;
            }
            while (num >= 1);

            Console.ReadKey();
        }
    }
}
