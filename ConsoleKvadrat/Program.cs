using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            Console.WriteLine("decision quadratic equation (aX^2 + bX + c = 0)");
            Console.WriteLine("Insert argument (a)");
            string a = Console.ReadLine();
            Console.WriteLine("Insert argument (b)");
            string b = Console.ReadLine();
            Console.WriteLine("Insert argument (c)");
            string c = Console.ReadLine();

            Console.WriteLine("quadratic equatio = ( " + a + "X^2 +" + b + "X + " + c + " = 0 )"   );
            Console.ReadLine();

        }
    }
}
