using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TryCatch390
{   
    class Program
    {

        //1. Ask the user for their age. --Done

        //2. Display the year the user was born. -- Done

        //3. Exceptions must be handled using “try/catch.”

        //4. Display appropriate error messages if the user enters zero or negative numbers. -- Done

        //5. Display a general message if an exception was caused by anything else. --Done

        //6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

        //7. Upload your code to GitHub.


        static void Main(string[] args)
        {
            const string welcome = "Michael's Place";   //Constant Variable

            Console.WriteLine("What is your name?"); // ask for user input

            var username = Console.ReadLine(); // store input in var username using keyword "var"
            //3. Error handling 
            try
            {
                Console.WriteLine("\n\nEnter a numeric value for age of 1 or greater:"); //1. ask user for age
                int userage = Convert.ToInt32(Console.ReadLine());
                if (userage < 1) // 4. if 0 or negative
                    throw new FormatException();
                var today = DateTime.Today; // Save today's date.

                var age = today.Year - userage; // Calculate the age.

                Console.WriteLine("Hi " + username + ", Welcome to {0}!", welcome + " You were born in " + age); // 2. Display year user was born


            }
            catch (FormatException ms) // 4. catch format exception
            {
                Console.WriteLine(ms.Message + " Please enter a number of 1 or greater."); //4. message if 0 or negative
                Console.ReadLine();
                //return;

            }
            catch (Exception)
            {
                Console.WriteLine("Nah try again"); // 5 general exception message
            }
 
            
            
            
            
            
            Console.ReadLine(); // keeps console window open
        }
    }
}
