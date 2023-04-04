using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor385
{
    class Program
    {
        //1. Create a const variable. --Done

        //2. Create a variable using the keyword “var.” --Done

        //3. Chain two constructors together. --User Class --Done 

        //4. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.--Done


        static void Main(string[] args)
        {
           
            const string welcome = "Michael's Place";   //1. Constant Variable
   
            Console.WriteLine("What is your name?");

            var username = Console.ReadLine(); // 2. var using keyword "var"

            Console.WriteLine("\n\nHow old are you? Enter a numeric value for age:");
            int userage = Convert.ToInt32(Console.ReadLine());

            User user = new User(username, userage); 

            Console.WriteLine("Hi " + username + ", Welcome to {0}, we're happy to see you!", welcome); // usage of the constant variable "welcome" and "var" "username"

            Console.ReadLine(); // keeps console window open
        }
    }

}

