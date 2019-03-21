using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] tab1 = new double[30];

            for (int ctr = 0; ctr < tab1.Length; ctr++)
            {
                tab1[ctr] = rand.Next(101);
                Console.WriteLine(tab1[ctr]);

            }
            int random_number = rand.Next(31);
            Console.WriteLine("Loswy index tablicy: \n" + tab1[random_number] +" Idnex: " + random_number);
            
            Console.ReadKey();
        }
    }
}
