using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Console classes Uses";
            Console.WriteLine("Devloper name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("Your name is: " + age);
            

            Console.ReadKey();
        }
    }
}
