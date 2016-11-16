using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0214
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign a value to the salary variable.
            var salary = 2500.0;

            // Assign a value to the bonus variable
            var bonus = 1200.0;

            // Calculate the total pay by adding salary 
            // and bonus. Assign the result to pay.
            var pay = salary + bonus;

            // Display the pay
            Console.WriteLine("Your pay is " + pay);
            Console.ReadLine();
        }
    }
}
