using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday");
            string userInput = Console.ReadLine();
            var userBirthday = GetDate(userInput);

            var dateNow = DateTime.Now;
            var age = dateNow - userBirthday;
            Console.WriteLine(age);

            Console.ReadLine();
        }

        public static DateTime GetDate(string dateOfBirthString)
        {
            string[] userBday = dateOfBirthString.Split('/');

            try
            {
                var dateObject = new DateTime(int.Parse(userBday[0]), int.Parse(userBday[1]), int.Parse(userBday[2]));
                return dateObject;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Use correct date format yyyy/mm/dd");
                throw;
            }
        }

        public static string GetData()
        {
            string userInput;
            Console.WriteLine("Enter your date of birth yyyy/mm/dd: ");
            return userInput = Console.ReadLine();
        }
    }
}
