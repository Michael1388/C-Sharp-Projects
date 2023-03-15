using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile229
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop

            Console.WriteLine("Guess a number between 1 and 5:");   //write user input query to console
            int number = Convert.ToInt32(Console.ReadLine());   // convert input from string to integer stored as "number"
            bool isGuessed = false; // create boolean variable "isGuessed" and set it as "false"

            while (!isGuessed) // create while loop to check boolen condition against
                               // the switch statment cases below
                               // (!isGuessed) is the same as (isGuessed == false)
            {
                switch (number) // switch case to iterate through the cases below and compare the variable "number" given by user
                {
                    case 1:
                        Console.WriteLine("You guessed 1, that's wrong, guess again!"); // responds to user's "guess" input and asks for another guess
                        number = Convert.ToInt32(Console.ReadLine()); // enables user to guess again and continue the while loop and switch block 
                        break; // stops this case and enables program to move on to the next line of code
                    case 2:
                        Console.WriteLine("You guessed 2, try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, that is correct!");  
                        isGuessed = true; // defines correct answer and changes boolean value to True
                        break; // breaks the program and exits the switch black of code
                    case 4:
                        Console.WriteLine("You guessed 4, that is incorrect, try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guesssed 5, also wrong! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default: // designates code to run if no case is matched
                        Console.WriteLine("You are just wrong! Keep trying!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            // DO WHILE Loop

            Console.WriteLine("Play again! Guess another number between 1 and 5:"); //write user input query to console
            int userNumber = Convert.ToInt32(Console.ReadLine());   // convert input from string to integer stored as "userNumber"
            bool wasGuessed = userNumber == 5;// creates boolean variable "wasGuessed" and sets True condition to "userNumber == to 5" meaning 5 is the correct answer

            do // do loop enables the program to run atleast once if user guesses 5 (previously set true condition of "wasGuessed = userNumber == 5") above.
            {
                // comment for code below is same as for code above with variable name changes to avoind overlap and change of "guessed" number being case 5 instead of the previous case 3.
                switch (userNumber)
                {
                    case 1:
                        Console.WriteLine("You guessed 1, nope, guess again!");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2, nope, guess again!");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, nope, also wrong try again! ");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, nope, guess again!");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guesssed 5. Great, that is correct!");
                        wasGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are just wrong wrong wrong! Keep trying!");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!wasGuessed); // same as (wasGuessed == false) , closes program as condition is met as True above



            Console.ReadLine();
        }
    }
}
