using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[50,10];
            Random rand = new Random();
            int num = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rand.Next(11);
                    num += array[i,j];
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
