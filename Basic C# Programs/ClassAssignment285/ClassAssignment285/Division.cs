using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment285
{
    // 1. Create a class. In that class, create a void method that outputs an integer. --Done
    // a. Have the method divide the data passed to it by 2. --Done

    // 2. In the Main() method, instantiate that class.--Done

    // 3. Have the user enter a number.--Done
    // a. Call the method on that number.--Done
    // b. Display the output to the screen. It should be the entered number, divided by two.--Done

    // 4. Create a method with output parameters. -- Done
    // 5. Overload a method. --Done
    // 6. Declare a class to be static.
    // 7. Add comments to each line or block of your code to explain what it does exactly,
    // so that another developer could read and understand your code.

    class Division

    {
        public void Divide2(int one)  // New public void Method Divide2 with 1 integer type parameter named "one
        {

            int sum = one / 2;  // create variable int type "sum" and the info passed into "one" and divide by 2 
    
           Console.WriteLine(sum);     // returns "sum" to the screen

        }

        public void outPut(out int parameter)
        {
            parameter = 100;
            parameter += 50;
        }
        public void outPut(out string parameter)
        {
            parameter = "Hi";
            parameter += " there!";
        }

    }
}
