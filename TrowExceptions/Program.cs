using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrowExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            try
            {
                string userData = GetData();
                var userBirthday = GetDate(userData);
                Console.WriteLine($"You were born on {userBirthday.DayOfWeek}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Please try again");
            }


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
            catch(FormatException e)
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
