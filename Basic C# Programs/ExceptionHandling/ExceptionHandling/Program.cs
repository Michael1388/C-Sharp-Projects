using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {   

            //TRY CATCH BLOCK

            try
            {   // this was what we coded and then put entirely into a "TRY" block and added "Catch" Blocks after lastly a "Finally" statement to continue running the program
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                `
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;

                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            }
            
            catch (FormatException ex) // this function is specific to the error message received by entering a name vs a number and as seen in the output dialog in VS
            {
                Console.WriteLine(ex.Message + " Please type a whole number."); // ex variable and .Message are all that is needed but you can instead just or also add your own message... 
                //return; // this will require a "finally" statement as seen below
            }
            catch (DivideByZeroException var)
            {
                Console.WriteLine(var.Message + " Please don't divide by zero.");
            }
            catch (Exception example)
            {
                Console.WriteLine(example.Message); // this is where you would use the .Message
            }
            finally
            {
                Console.WriteLine("I am finally");
                Console.ReadLine(); //returns user to error message not really clear on this but  "something to log to databse that a card was charged but an exception was encountered and failed to execute transaction..."
                //Console.WriteLine("THe program has emerged from an exception, please check the error log");
                
            }





            Console.ReadLine();
        }
        

    }
}
