using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Branching - one of the five elements of a program
            // Branching is what gives programs"intelligence."

            if (true) //(false) would not print
            {
                Console.WriteLine("Hello!");
   
            }
            //The above code will always print “Hello!” to the console.
            //Whatever is inside of the parentheses immediately following the
            //word “if” is evaluated to either a true or a false.
            //The Boolean value true, of course, will always evaluate to true,
            //which means the code inside the curly braces after the if statement
            //will get run.


            // IF/ELSE statements in C#
            if (1 == 1)
            {
                Console.WriteLine("1 equals 1!");
            }
            else
            {
                Console.WriteLine("1 does not equal 1"); //will not run bc 1 does = 1
            }
            //The above code, if run, will always print “1 equals 1!” to the console.
            //In this case, the else block wouldn’t get hit. 

            //another example 
            // user provides name 
            string name = "George";

            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");

            }
            else
            {
                Console.WriteLine("Your name is not Jesse");
            }

            //The above code gets input from the user and then compares the answer
            //to the string “Jesse.” If it matches exactly (including proper
            //capitalization), then the code inside of the curly braces after the
            //if statement runs. Otherwise, the code inside the curly braces after
            //the else statement runs.

            //Here is another example:

            string name1 = "Adam";

            if (name1 == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");

            }
            else if (name1 == "Fred")
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse. Your name is not Fred");
            }

            //You can put in as many else if statements as you need.

            if (4 < 5)
            {
                Console.WriteLine("True, 4 is greater than 5");
            }
            else if (4 == 5 )
            {
                Console.WriteLine("4 is equal to 5");
            }
            else
            {
                Console.WriteLine("none of that trash was true!");
            }

            // Operator NOT EQUAL != 

            string fName = "Adam";

            if (fName != "Jesse")
            {
                Console.WriteLine("Your name is not Jesse");
            }

            // The != operator answers the question “Does the value on
            // my left NOT equal the value on my right?”
            
            // Here is another example:
             if (1 != 2)
            {
                Console.WriteLine("All is right in the universe.");
            }
             else
            {
                Console.WriteLine("We live in a bizarro world.");
            }

            //GREATER THAN OPERATOR
            //Here is how to use the greater than(>) operator in C#:

            int num1 = 12;
            int num2 = 14;
            if (num1 > num2)
            {
                Console.WriteLine("The first number is larger.");
            }
            else 
            {
                Console.WriteLine("The second number is larger.");
            }

            //Lesser than is written as follows:

            int age = 19;
            if (age < 21)
            {
                Console.WriteLine("No, you may not purchase that bottle of wine. ");
            }
            else
            {
                Console.WriteLine("THat will be $23.71");
            }

            //LESSER THAN OR EQUAL TO OPERATOR
            //In C#, the lesser than or equal to operator is written as follows:

            int userAge = 20;

            if (userAge <= 20)
            {
                Console.WriteLine("No you still may not purchase that bottle of wine.");
            }
            else
            {
                Console.WriteLine("There you go!");
            }

            //The (age <= 20) asks the question, “Is the value on the
            //left less than or equal to the value on the right?”

            //Greater than or equal to is written as follows:


            int thisAge = 20;
            if (thisAge >= 25)
            {
                Console.WriteLine("Yes you may rent a car from us.");
            }
            else
            {
                Console.WriteLine("No you may not rent a car.");
            }

            // The AND Operator
            // C# allows you to get very specific with if statements.

            // The expressions before and after the AND operator both have
            // to be true for the code in the curly braces to run:

            int num3 = 7;
            int num4 = 18;
            int num5 = 12;
            if (num4 > num3 && num5 < num4)
            {
                Console.WriteLine("The second number is larger than the others.");
            }

            //When using the AND operator, for the statement inside the parentheses
            //to evaluate to true, each expression on the left and right of it must
            //be true:

            int num7 = 7;
            if (true && true && true && true && num7 ==20)
            {
                Console.WriteLine("Everything was true!");
            }
            else
            {
                Console.WriteLine("There waa a false somewhere!");
            }

            //Let’s see a real-life example:

            int packageWeight = 50;
            int packageLength = 25;
            if (packageWeight > 40 && packageLength >20)
            {
                Console.WriteLine("This package is too big to ship.");
            }

            //Translated to English, the above code reads, “If the package weight
            //is greater than 40 and also its length is greater than 20,
            //tell the person they can’t ship it.”


            //The OR OPERATOR
            //As you know, other times you may want to know if just one expression
            //evaluates to true. This is done using the OR operator (||). If one
            //value on the right or left of it evaluates to true, then the code in
            //the curly braces is run:

            int num8 = 7;
            if (num8 < 7 || num8 == 12)
            {
                Console.WriteLine("At least one value is true.");
            }

            if (num8 == 12 || num8 == 18)
            {
                Console.WriteLine("At least one value also is true here.");
            }
            else
            {
                Console.WriteLine("No value is true.");
            }

            if (num8 == 12 || num8 == 18 || num8 == 20 || num8 == 7)
            {
                Console.WriteLine("Something is true.");
            }

            //Or here’s a real-life scenario:

            string role = "admin";
            if (role == "admin" || role == "administrator")
            {
                Console.WriteLine("You may have access to the entire software system.");
            }

            //Here’s another example:

            int num9 = 7;
            if (num9 < 18 && ((num9 == 7) || num9 == 2) && ((num9 == 8 && num9 > 20) || (num9 < 20 && num9 > 2)))
            {
                Console.WriteLine("Wow that was confusing.");
            }


            // More on BRANCHING

            // TERNARY OPERATOR 
            //In normal English, ternary means “made up of three parts.”

            //The ternary operator allows you to write a single line of code
            //that will check for a condition and, depending on the outcome,
            //execute another portion of code. In C#, the ternary operator is
            //represented by the symbol “?:”

            //For example:
            int num10 = 7;
            int num11 = 12;

            string result = num10 > num11 ? "num10 is greater than num11" : "num10 is not greater than num11";
            Console.WriteLine(result);

            //In our code, the value of the string variable “result” is being set
            //to one of two strings depending on the result of the conditional
            //statement.
            //Stated another way:Is num1 greater than num2? If it is, the variable
            //result will have the value “num10 is greater than num11” (the string
            //value on the left side of the colon). If the conditional statement
            //returns false, the second string option “num10 is not greater than
            //num11” will be the value of the variable result(the string value
            //on the right side of the colon).

            // my example:

            int myAge = 32;
            int yourAge = 33;

            string resultX = myAge > yourAge ? "true" : "false";
            Console.WriteLine("The statement is: " + resultX);


            // Branching Video

            int currentTemp = 68;
            int roomTemp = 70;

            if ( currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if( currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("It is not room temperature.");
            }

            //could also use Ternary to shorten all of this to something more streamilne.
            //This example is a one line true or if else statement that is more space efficient

            string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is definitely not room temp.";
            Console.WriteLine("answer is: " + comparisonResult);


            //Now we can put this into an actual user input program and see real functionality

            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string uName = Console.ReadLine();

            Console.WriteLine("Hi, " + uName + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("It is colder than room temperature.");
            }

            // with a ternary operator

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string favresult = favNum == 12 ? "Your favorite number is 12" : "Your favorite number is not 12";
            Console.WriteLine(favresult);


            Console.ReadLine();

        }
    }
}
