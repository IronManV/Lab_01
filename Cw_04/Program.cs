using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(101);

            Console.WriteLine(number + "\n");

            Console.WriteLine(Math.Sqrt(number));

            Console.ReadKey();
        }
    }
}
