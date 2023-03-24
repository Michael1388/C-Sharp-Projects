using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment

//1. Create Main program -- Done
//2. ask user what number they want to do math operations on -- Done
//3. Add a new class in a separate .cs file -- Done 

//4. create a class, in that class create three (3) methods. -- Done
//Each method will take one integer parameter in and return an integer.
// They should do some math operation in the received parameter.

//5. Call each method, passing in the user input to the method. --Done
//6. Display the returned integer to the screen --Done
//7. As always comment your code so that another developer could read and understand my code. --Done



{
    class MathOperations // create Class "MathOperations"
    {
        public static int AddOne(int userNum)   // Create int method "AddOne", assign parameter int "userNum" 
        {
            int sum = userNum + 1;  // create variable int type "sum" taking parameter userNum and adding 1
            return sum;      //return variable "sum" 
        }

        public static int SubOne(int userNum)   // Create int method SubOne, assign parameter int "userNum" 
        {
            int sum = userNum - 1;  // variable int type "sum" taking parameter userNum and subtracting 1
            return sum;     // return variable "sum"
        }

        public static int MultiOne(int userNum)  // Create int method MultiOne, assign parameter int "userNum" 
        {
            int sum = userNum * 1;  // variable int type "sum" taking parameter userNum and adding 1
            return sum;     //return variable "sum"
        }

        //Personal notes not part of the program but kept for future reference
        //public static String Dance(String danceType)
        //{
        //    String builtString = "I am going to preform a dance of " + danceType;
        //    return builtString;
        //}


    }
}
