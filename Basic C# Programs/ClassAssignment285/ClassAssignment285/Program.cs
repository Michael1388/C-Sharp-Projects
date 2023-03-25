using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment285
{
    class Program
    {
        // 1. Create a class. In that class, create a void method that outputs an integer. --Done
        // a. Have the method divide the data passed to it by 2.--Done

        // 2. In the Main() method, instantiate that class. --Done

        // 3. Have the user enter a number.--Done
        // a. Call the method on that number.--Done
        // b. Display the output to the screen. It should be the entered number, divided by two.--Done

        // 4. Create a method with output parameters. --DOne
        // 5. Overload a method.
        // 6. Declare a class to be static.
        // 7. Add comments to each line or block of your code to explain what it does exactly,
        // so that another developer could read and understand your code.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");  //write to console and ask user for a number
            int userInput = Convert.ToInt32(Console.ReadLine());    //store user input in var called userInput and convert to integer 

            Division division = new Division(); //instantiate new Class of Class "Division" as variable "division" 
            division.Divide2(userInput); //call the Divide2 method passing in the user input


            int runIt;
            division.outPut(out runIt);
            Console.WriteLine(runIt);

            string here;
            division.outPut(out here);
            Console.WriteLine(here);

            Console.ReadLine(); // keep console open to view program until closed by user or return/enter key

        }
    }
}
