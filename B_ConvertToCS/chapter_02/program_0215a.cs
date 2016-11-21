using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0215a
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal originalPrice;          // The item's original price
            decimal discountPercentage;     // The discount percentage
            decimal discountAmount;         // The amount of discount
            decimal salePrice;              // The item's sale price

            // Get the item's original price.
            Console.Write("Enter the item's original price: ");
            originalPrice = decimal.Parse(Console.ReadLine());

            // Get the discount percentage.
            Console.Write("Enter the discount value (ex. 20% = 0.2): ");
            discountPercentage = decimal.Parse(Console.ReadLine());

            // Calculate the amount of the discount.
            discountAmount = originalPrice * discountPercentage;

            // Calculate the sale price.
            salePrice = originalPrice - discountAmount;

            // Display the sale price.
            Console.WriteLine("The sale price is " + salePrice.ToString("c"));
            Console.ReadLine();
        }
    }
}
