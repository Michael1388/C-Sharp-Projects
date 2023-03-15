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
            Console.WriteLine();
            Console.WriteLine("Guess a number between 1 and 5:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false; // 

            while (!isGuessed) // same as (isGuessed == false)
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

            // DO WHILE Loop
            Console.WriteLine("Play again! Guess another number between 1 and 5:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            bool wasGuessed = userNumber == 5;// was = false, changed to = number == 3

            do
            {
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
                        Console.WriteLine("You guesssed 5, that is correct!");
                        wasGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are just wrong wrong wrong! Keep trying!");
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!wasGuessed); // same as (wasGuessed == false)



            Console.ReadLine();
        }
    }
}
