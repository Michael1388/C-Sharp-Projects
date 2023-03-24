using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    //1. Create Main program -- Done
    //2. ask user what number they want to do math operations on -- Done
    //3. Add a new class in a separate .cs file -- Done 
    //4. create a class, in that class create three (3) methods. --Done
    //Each method will take one integer parameter in and return an integer.
    // They should do some math operation in the received parameter.
    //5. Call each method, passing in the user input to the method. --Done
    //6. Display the returned integer to the screen --Done
    //7. As always comment your code so that another developer could read and understand my code. --Done


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Provide a number to perform math on: ");     //Ask for user input
            int userinput = Convert.ToInt32(Console.ReadLine());            //convert string type to int type variable "userinput" and 

            Console.WriteLine(MathOperations.AddOne(userinput));        // return "sum" from "AddOne" Method of Class MathOperations taking in "userinput" variable and performing Method specified
            Console.WriteLine(MathOperations.SubOne(userinput));        // return "sum" from "SubOne" Method of Class MathOperations taking in "userinput" variable and performing Method specified
            Console.WriteLine(MathOperations.MultiOne(userinput));        // return "sum" from "MultiOne" Method of Class MathOperations taking in "userinput" variable and performing Method specified


            //Console.WriteLine("Amazing, program is complete!"); // NOT USED


            //NOT USED -- Personal notes for future, not part of program 
            //Console.WriteLine(MathOperations.Dance("waltz"));
            //Console.WriteLine(MathOperations.Dance("mamba"));
            //Console.WriteLine(MathOperations.Dance("123"));

            Console.ReadLine(); // keeps conssole window open until closed by user or return/enter is entered again

        }
    }
}
