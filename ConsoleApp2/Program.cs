using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var start = new DateTime(1981, 11, 01);
            var end = DateTime.Now;
            var age = end - start;
            Console.WriteLine(age.TotalSeconds);

            Console.ReadLine();

        }
    }
}
