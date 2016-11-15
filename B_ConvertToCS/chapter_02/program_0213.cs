using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0213
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's name, age, and income.
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("What is your age? ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("What is your income? ");
            var income = decimal.Parse(Console.ReadLine());

            // Display the data.
            Console.WriteLine("Here is the data you entered:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Income: " + income);
            Console.ReadLine();

        }
    }
}
