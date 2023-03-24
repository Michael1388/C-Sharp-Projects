using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssign279
{

    // 1.Create a class. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer. --Done

    // 2.In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen. --Done

    // 3.Add a second method to the class with the same name (overload) that will take in a decimal, create a different math operation for it, then return the answer as an integer. --Done 

    // 4.In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen. --Done 

    // 5.Add a third method 3 to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer. --Done 

    // 6.In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen. --Done 

    // 7.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done 

    class MathOperations // create Class "MathOperations"
    {
        public static int AddIt(int userNum)   // Create method "AddIt", assign parameter int "userNum" 
        {
            int sum = userNum + 10;  // create variable int type "sum" taking parameter userNum and adding 10
            return sum;      //return variable "sum" 
        }

        public static int AddIt(decimal userNum)   // Create 2nd method AddIt, assign parameter decimal type "userNum" 
        {
            decimal sum = userNum + 3.5m;   // create variable decimal type "sum" taking parameter userNum and adding 3.5m

            return Convert.ToInt32(sum);     // return variable "sum" converted to integer for return
        }

        public static int AddIt(string userNum) // Create 3rd method of AddIt, assign parameter string type "userNum" 
        {
            int sum = Convert.ToInt32(userNum) + 5; // create variable of int type "sum" converting taken parameter userNum and adding 5
            return sum;     //return int variable "sum" 
        }


    }
}
