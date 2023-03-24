using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment280
{


    //1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result. --Done

    //2. In the Main() method of the console app, instantiate the class.--Done

    //3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.--Done

    //4. Call the method in the class, passing in the one or two numbers entered.--Done

    //5. Try various combinations of numbers on the code, including having no second number.--Done

    //6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.--Done



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");  //write to console and ask user for a number
            int userInput = Convert.ToInt32(Console.ReadLine());    //store user input in var called userInput and convert to integer 

            try //if user enters the (optional) "not required" second number the try catch block will catch the missing number and run the optional parameter instead 
            {
                Console.WriteLine("Enter another number (optional): ");    //write to console and ask user for another number
                int userInput2 = Convert.ToInt32(Console.ReadLine());   //store user input in var called userInput2 and convert to integer

                Console.WriteLine(OptionalParameters.OpParam(userInput, userInput2));   //pass in userInput and userInput2 into Method OpParam of OptionalParameters Class and perform function specified
                Console.WriteLine(OptionalParameters.OpParam(userInput));       //pass in userInput into Method OpParam and perform function specified
                Console.WriteLine(OptionalParameters.OpParam(userInput2));      //pass in userInput2 into Method OpParam and perform function specified


                Console.ReadLine(); // keep console open to view program until closed by user or return/enter key
            }
            catch //if user enter the (optional) "not required" second number the try catch block will catch the missing number and run the optional parameter instead
            {
                Console.WriteLine(OptionalParameters.OpParam(userInput));       //pass in userInput into Method OpParam and perform function specified
                Console.ReadLine(); // keep console open to view program until closed by user or return/enter key
            }
        }
    }
}
