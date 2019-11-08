using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name three colors");
            string userInput = Console.ReadLine();

            string[] colors = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> colorList = colors.ToList();

            foreach (string color in colorList)
            {

                Console.WriteLine(color);
            }

            Console.WriteLine("Add/Remove a color");
            string userChoice = Console.ReadLine();

            if(userChoice.ToLower() == "add")
            {
                Console.WriteLine("Enter a color:");
                string userAnswer = Console.ReadLine();
                colorList.Add(userAnswer);
            }

            else if(userChoice.ToLower() == "remove")
            {
                Console.WriteLine("remove a color:");
                string userAnswerToRemove = Console.ReadLine();
                colorList.Remove(userAnswerToRemove);
            }

            else
            {
                Console.WriteLine("Unk command");
            }

            Console.ReadLine();
        }
    }
}
