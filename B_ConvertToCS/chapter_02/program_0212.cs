using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0212
{
    class Program
    {
        static void Main(string[] args)
        {
          // Get the user's first name.
          Console.Write("Enter your first name: ");
          string firstName = Console.ReadLine();

          // Get the user's last name.
          Console.Write("Enter your last name: ");
          string lastName = Console.ReadLine();

          // Print a greeting to the user.
          Console.WriteLine("Hello " + firstName + " " + lastName);
          Console.ReadLine();
        }
    }
}
