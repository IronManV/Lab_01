using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for(int i=0; i <= 100; i++)
            {
                double number = rand.NextDouble() * 5;
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
