using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct332
{

    //1. Create a struct called Number and give it the property “Amount” and have it be of data type decimal.--Done

    //2. In the Main() method, create an object of data type Number and assign an amount to it. --Done

    //3. Print this amount to the console. --Done

    // Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done

    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //instantioan of Number Struct
            number.Amount = 1.7m; // create object of Number type of property Amount (and call Amount) , "m" represents decimal 

            Console.WriteLine(number.Amount); //write result to console 

            Console.ReadLine(); // keeps console window open

        }
    }
}
