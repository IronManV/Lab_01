using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe:");
            string number1 = Console.ReadLine();

            Console.WriteLine("Podaj druga liczbe:");
            string number2 = Console.ReadLine();

            int num1;
            int num2;
            Int32.TryParse(number1, out num1);
            Int32.TryParse(number2, out num2);

            int wynik = num1 + num2;

            Console.WriteLine("Suma dodawania:\n" + wynik);

            Console.ReadKey();

        }
    }
}
