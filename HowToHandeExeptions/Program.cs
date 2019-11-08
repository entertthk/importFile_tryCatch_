using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowToHandeExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            double number3;

            try
            {
                Console.WriteLine("Enter number 1: ");
                number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                number2 = int.Parse(Console.ReadLine());

                number3 = number1 / number2;
                Console.WriteLine(number3);
            }

            /*catch (Exception error) ---kuvab mis errorti annab
            {
                Console.WriteLine(error);
            }
            */

            catch (DivideByZeroException e) 
            { 
                Console.WriteLine("You mustnt divide by zero");
            }

            catch (FormatException e)
            {
                Console.WriteLine("You used invalid format");
            }

            Console.ReadLine();
        }
    }
}
