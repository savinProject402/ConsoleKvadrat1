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
            double number_A, number_B, number_C;
            Console.WriteLine("decision quadratic equation (aX^2 + bX + c = 0)");
            Console.WriteLine("Insert argument (a)");
            number_A = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert argument (b)");
            number_B = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert argument (c)");
            number_C = double.Parse(Console.ReadLine());

            Console.WriteLine("quadratic equatio = ( " + number_A + "X^2 +" + number_B + "X + " + number_C + " = 0 )"   );

            double Discriminant = number_B * number_B - 4 * number_A * number_C;
            if (Discriminant < 0)
            {
                Console.WriteLine("Discriminant less than zero. No roots");
                Console.ReadLine();
            }
            if (Discriminant == 0)
            {
                double x = Math.Round(-number_B / (2 * number_A), 2);
                Console.WriteLine("Discriminant is zero.The root (X) = " + x + "");
                Console.ReadLine();
            }
            if (Discriminant > 0)
            {
                double x1 = Math.Round((-number_B - Math.Sqrt(Discriminant)) / (2 * number_A), 2);
                double x2 = Math.Round((-number_B + Math.Sqrt(Discriminant)) / (2 * number_A), 2);
                Console.WriteLine("The Discriminant is " + Discriminant + ". The first root is" + x1 + ". The second root is" + x2 + "");

                Console.ReadLine();
            }


        }
    }
}
