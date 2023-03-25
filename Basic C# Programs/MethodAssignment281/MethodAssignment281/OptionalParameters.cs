using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment281
{

    //1. Create a class. In that class, create a void method that takes two integers as parameters. --Done
    //a. Have the method do a math operation on the first integer and display the second integer to the screen. --Done

    //2. In the Main() method of the console app, instantiate the class. --Done

    //3. Call the method in the class, passing in two numbers. --Done

    //4. Call the method in the class, specifying the parameters by name. --Done

    //5. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done


    class OptionalParameters
    {
        public void OpParam(int some, int other)  // New public void Method OpParam with two integer type parameters
        {
            int sum = some + 10; // does math operation on first integer
            Console.WriteLine(other);     // returns second int "other" to the screen

        }
    }
}
