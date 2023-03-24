using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment280
{

    //1. Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.--Done

    //2. In the Main() method of the console app, instantiate the class.--Done

    //3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.--Done

    //4. Call the method in the class, passing in the one or two numbers entered.--Done

    //5. Try various combinations of numbers on the code, including having no second number.--Done

    //6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.--Done

    class OptionalParameters // New Class
    {
        public static int OpParam(int some, int other = 1)  // New public static Method OpParam with integer return and two integer type parameters, one optional with a default set to 1
        {
            int sum = some + other;     // math operation adding those two parameters together stored in var "sum"
            return sum;     // return of var "sum"

        }


    }
}
