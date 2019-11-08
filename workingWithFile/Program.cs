using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // using System.IO; teisele reale lisatud

            string path = @"C:\demo\demo.txt";

            //read file content
            List<string> lines = File.ReadAllLines(path).ToList();

            foreach( string line in lines)
            {
                Console.WriteLine(line);
            }

            //lisame
            Console.WriteLine("Lets add and item");
            string userItem = Console.ReadLine();

            lines.Add(userItem);

            File.WriteAllLines(path, lines);

            List<string> lines1 = File.ReadAllLines(path).ToList();

            foreach (string line in lines1)
            {
                Console.WriteLine($"{line} is on the list");
            }

            Console.ReadLine();
        }
    }
}
