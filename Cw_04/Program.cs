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
            int a = rand.Next(101);
            int b = rand.Next(101);
            int c = rand.Next(101);
            double delta;

            delta = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if(delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Miejsca zerowe: " + x1 + " " + x2);
            }
            else if(delta < 0 )
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Miejsce zerowe: " + x1);
            }
            else
            {
                Console.WriteLine("funkcja nie posiada miejsc zerowych");
            }


            Console.ReadKey();
        }
    }
}
