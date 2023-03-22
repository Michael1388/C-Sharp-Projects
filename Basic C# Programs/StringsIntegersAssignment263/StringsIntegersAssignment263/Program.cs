using System;
using System.Collections.Generic;


namespace StringsIntegersAssignment263
{
    class Program
    {
        static void Main(string[] args)
        {

            //Strings and Integers assignment
            //
            //1. Create list of integers --DONE
            //2. Ask user for a number input to divide EACH number in the list by.--DONE
            //3. Create loop, take each integer and divide it by user input -- DONE
            //4. Display results to screen --DONE
            //5 Run and check code results using NON ZERO numbers -- DONE
            //6.Run AGAIN but using ZERO to divide and NOTE error messages. --DONE
            // DIVIDE BY ZERO EXCEPTION

            //7.Run AGAIN but using STRING to divide and NOTE error messages. --DONE
            // FORMAT EXCEPTION

            //8.Create and put the loop into a try/catch block. --DONE

            //9. Make the program display a message to let you know the program
            //has emerged from a try catch block and continued with program execution --Done

            //10. In the catch block, display the error message to the screen. --Done
            //11. try various things to produce errors --Done
            //12. Ensure the proper error messages display on the screen, and that
            //the code after the try/catch block gets executed. --Done



            //foreach (int number in divideme) // to test if list works properly
            //{ 
            //    Console.WriteLine(number);
            //}

            try // try catch block
            {
                List<int> divideMe = new List<int>() { 20, 12, 44, 18, 88, 56 }; //integer list

                Console.WriteLine("Please enter a number to divide each number in the list by: "); // query user for input
                int userNumber = Convert.ToInt32(Console.ReadLine()); // convert user input to integer and name "usernember"
                
                for (int i = 0; i < divideMe.Count; i++) // iterate through list
                {
                    if (divideMe[i] == divideMe[i]) // if statement to enact result
                    {
                        int result = divideMe[i] / userNumber; // divide results desired

                        Console.WriteLine(result); // write results to screen
                    }

                }

            }

            catch (FormatException exs) // this function is specific to the error message received by entering a name vs a number and as seen in the output dialog in VS
            {
                Console.WriteLine(exs.Message + " Please type a whole number."); // exs variable and .Message are all that is needed but you can instead just or also add your own message... 
               
            }
            catch (DivideByZeroException var) // handles exception divide by 0
            {
                Console.WriteLine(var.Message + " Please don't divide by zero.");
            }
            catch (Exception example) // general catch all exception handler
            {
                Console.WriteLine(example.Message); // this is where you would use the generic .Message
            }

            Console.WriteLine("Program has completed task and ended."); // program is complete and closing


            Console.ReadLine();// keeps window open until closed by user

        }
    }
}
