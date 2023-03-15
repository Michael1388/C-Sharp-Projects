using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceQuoteApplication222
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a shipping quote application

            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below."); // write intro statement to console

            Console.WriteLine("Please enter package weight: "); // write user input query to console
            int packageWeight = Convert.ToInt32(Console.ReadLine()); // convert input to integer and store in variable "weight"

            if (packageWeight > 50) // if weight over 50 end program with too heavy to ship statement to user.
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else // if weight not over 50 continue program
            {

                Console.WriteLine("Please enter package width: ");  // write user input query to console 
                int packageWidth = Convert.ToInt32(Console.ReadLine());    // convert input to integer and store in variable "width"

                Console.WriteLine("Please enter package height: "); // write user input query to console
                int packageHeight = Convert.ToInt32(Console.ReadLine());   // convert input to integer and store in variable "height"

                Console.WriteLine("Please enter package length: "); // write user input query to console
                int packageLength = Convert.ToInt32(Console.ReadLine());   // convert input to integer and store in variable "length"

                // declare variable "packageTotal" to multiply package dimensions and then divide package weight by 100 for total price to be stored into
                int packageTotal = packageWidth * packageHeight * packageLength * packageWeight / 100;  

                if (packageWidth + packageHeight + packageLength > 50) // if combine package dimensions are over 50 end program with too big to ship statement to user.
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else // print estimated shipping price to console with user message 
                {
                    Console.WriteLine("Your estimated total is: $" + packageTotal + ".00 Thank you!");
                }

            }
            Console.ReadLine(); // keeps console window open until closed by user or return (enter key) is pressed again

        }
    }
}
