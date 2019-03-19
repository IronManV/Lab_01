using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num = rand.Next(11)+1;
            int random;

            for(int i = 2; i <= 5; i++)
            {
                random = (int)Math.Pow(num, i);
                if(random < 10000)
                {
                    Console.WriteLine(i + " Potega liczby: " + num + " " + random);
                }
                

            }
            Console.ReadKey();
        }
    }
}
