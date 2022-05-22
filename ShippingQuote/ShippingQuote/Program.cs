using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Ask user for weight
            Console.WriteLine("How much does your package weigh?");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Evaluate if package is under weight limit.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                // Ask for package dimensions
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                // Evaluate if package is under size limit
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    // Calculate quote price and convert to float
                    int quotePriceInt = ((width * height * length) * weight);
                    float quotePrice = (float)quotePriceInt / 100;

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quotePrice);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
