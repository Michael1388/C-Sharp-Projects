using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssign279
{
    // 1.Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer. --Done

    // 2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer.Display the result to the screen. --Done 

    // 3.Add a second method 2 to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer. --Done 

    // 4.In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen. --Done 

    // 5.Add a third method 3 to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer. --Done 

    // 6.In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen. --Done 

    // 7.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done 

    class Program
    {
        
        static void Main(string[] args)
        {
           
          
            Console.WriteLine(MathOperations.AddIt(3));      // return "sum" from "AddIt" Method of Class MathOperations taking in integer "3" and performing Method specified
            Console.WriteLine(MathOperations.AddIt(1.5m));  // return "sum" from "AddIt" Method of Class MathOperations taking in decimal "1.5m" and performing Method specified
            Console.WriteLine(MathOperations.AddIt("5"));   // return "sum" from "AddIt" Method of Class MathOperations taking in "5" string and performing Method specified



            Console.ReadLine(); // keeps conssole window open until closed by user or return/enter is entered again

        }
    }
}


