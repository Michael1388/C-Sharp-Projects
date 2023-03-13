using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition
            //int num1 = 5;
            //int num2 = 7;
           // int total = num1 + num2;
            //Console.WriteLine("Addition: " + total);

            //Subtraction using same num1 and num 2 variables
           // int difference = num1 - num2;
          //  Console.WriteLine("Subtraction: " + difference);

            //Multiplication using same num1 and num 2 variables
           // int product = num1 * num2;
          //  Console.WriteLine("Multiplication " + product);

            //Division using new variables
            int num3 = 12;
            int num4 = 3;
            int quotient = num3 / num4;
            Console.WriteLine("Division: " + quotient);

            //Modulous 
            int num5 = 7;
            int num6 = 3;
            int remainder = num5 % num6;
            Console.WriteLine("Remainder: " + remainder);

            //Modulous to determine if number is odd or even
            int num8 = 7;
            int isoddeven = num8 % 2;
            Console.WriteLine("Odd or even: " + isoddeven);

            //Math Casting with Different Data Types
            double num10 = 7.03230923;
            float num11 = 5.9f;
            double total = num10 + num11;
            Console.WriteLine(total);

            double num12 = 7.03230923;
            float num13 = 5.9f;
            float totals = (float)num12 + num13;
            Console.WriteLine(totals);

            // CASTING MATH
            // There is no implicit conversion available from a
            // “float” or “double” to a “decimal.” These conversions
            // must be done “explicitly.” 

            decimal num14 = 7.03230923m;
            int num15 = 5;
            decimal totes = num14 + num15;
            Console.WriteLine(totes);

            // OR
            decimal num16 = 7.03230923m;
            sbyte num17 = 5;
            decimal tots = num16 + num17;
            Console.WriteLine(tots);

            //Math with STRINGS
            //While this looks like math,
            //it’s actually called “string concatenation.”

            string firstName = "Jesse ";
            string lastName = "Johnson";
            Console.WriteLine(firstName + lastName);

            //It can also do implicit conversion of data types:
            //In the example, the compiler implicitly converted
            //the “int” called “number” to a string data type.
            //Converting to string is probably the easiest and
            //most consistent conversion available to you in C#.
            //Addition is the only “math” operator available to strings.

            string name = "Jesse ";
            int numberz = 5;
            Console.WriteLine(name + numberz);

            string example = "Michael ";
            string post = "La Rocca ";
            int nums8 = 54;
            Console.WriteLine(example + post + nums8);

            Console.ReadLine();


        }
    }
}
