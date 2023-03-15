using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch statement 
            
            // switch

            Console.WriteLine("What is today?");
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednseday");
                    break;
            }

            // another example with default added

            // then we add a while loop with a bool set to false and paste
            // the switch statement into the while loop {}
            // then we went to a "do" while loop whew really? ok lol!

            //Console.WriteLine("Guess a number between 1 and 5:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = false;//number == 3; // was = false, changed to = number == 3

            //while (!isGuessed) // same as (isGuessed == false)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine("You guessed 1, that's wrong, guess again!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 2:
            //            Console.WriteLine("You guessed 2, try again!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 3:
            //            Console.WriteLine("You guessed 3, that is correct!");
            //            isGuessed = true; // added after we created while loop with "isGuessed" variable = false
            //            break;
            //        case 4:
            //            Console.WriteLine("You guessed 4, that is incorrect, try again");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 5:
            //            Console.WriteLine("You guesssed 5, also wrong! Try again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine("You are just wrong! Keep trying!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}



            // Copying the above, we can also add a "DO" and change the variable isGuessed to a static
            // number or previously indicated and fixed answer and error handle for
            // when a user guesses that number on the first try


            Console.WriteLine("Guess a number between 1 and 5:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 3;// was = false, changed to = number == 3

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1, that's wrong, guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2, try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, that is correct!");
                        isGuessed = true; // added after we created while loop with "isGuessed" variable = false
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, that is incorrect, try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guesssed 5, also wrong! Try again.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are just wrong! Keep trying!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed); // same as (isGuessed == false)
            {
                
            }
            Console.ReadLine(); // keep window open
        }
    }
}
