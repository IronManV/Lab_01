using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1,6);

            switch (number)
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                case 5:
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("Liczby nie znalezion");
                    break;
            }
            Console.ReadKey();
        }
    }
}
