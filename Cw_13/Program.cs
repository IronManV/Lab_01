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
            int num = rand.Next(2,6);
            int randomNumber;

            for(int i = 0; ; i++)
            {
                randomNumber = (int)Math.Pow(num, i);
                if(randomNumber < 10000)
                {
                    Console.WriteLine(i + " Potega liczby: " + num + " = " + randomNumber);
                    
                }
                else
                {
                    break;
                }

                
            }
            Console.ReadKey();
        }
    }
}
