﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment281
{
    class Program
    {


        //1. Create a class. In that class, create a void method that takes two integers as parameters. --Done
        //a. Have the method do a math operation on the first integer and display the second integer to the screen. --Done

        //2. In the Main() method of the console app, instantiate the class. --Done

        //3. Call the method in the class, passing in two numbers.--Done

        //4. Call the method in the class, specifying the parameters by name. --Done

        //5. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done

        static void Main(string[] args)
        {

            OptionalParameters name1 = new OptionalParameters(); // instantiated Class 
            name1.OpParam(some: 1, other :2); // called method passing in two numbers, specifying the parameters by name...this time :)


            Console.ReadLine(); // keep console open to view program until closed by user or return/enter key
        }
    }
}
