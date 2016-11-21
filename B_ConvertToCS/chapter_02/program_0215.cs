using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0215
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program gets an item's original price and
            // calculates its sale price, with a 20% discount.

            decimal PERCENTAGE = 0.2;

            // Get the item's original price.
            Console.Write("Enter the item's original price: ");
            var originalPrice = decimal.Parse(Console.ReadLine());

            // Calculate the amount of the discount.
            var discount = originalPrice;

            // Calculate the sale price.
            var salePrice = originalPrice - discount;

            // Display the sale price.
            Console.WriteLine("The sale price is " + salePrice);
            Console.ReadLine();

        }
    }
}
