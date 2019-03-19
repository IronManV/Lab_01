using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int supp = 0;
            int number = 0;

            do
            {
                number = rand.Next(1001);
                if(number %3 == 0)
                {
                    Console.WriteLine(number);
                    supp++;
                }
            }
            while (supp != 50);
            Console.WriteLine("Supp:" + supp + "\n");

            int supp2 = 0;
            int number2 = 0;

            while(supp2 != 50)
            {
                number2 = rand.Next(1001);
                if (number2 % 3 == 0)
                {
                    Console.WriteLine(number2);
                    supp2++;
                }
            }
            Console.WriteLine("Supp2:" + supp2 + "\n");

            for(int i=0; i < 50;)
            {
                int number3 = rand.Next(1001);

                if (number3 %3 == 0)
                {
                    i++;
                    Console.WriteLine(number3);
                }
            }
            Console.ReadKey();
        }
    }
}
