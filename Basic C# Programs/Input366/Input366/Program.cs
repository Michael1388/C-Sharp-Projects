using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input366
{
    class Program
    {
        //Asks the user for a number. --Done
        //Logs that number to a text file. --Done
        //Prints the text file back to the user. --Done
        //Add comments to each line or block of your code to explain what it does exactly,
        //so that another developer could read and understand your code. --Done

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: "); //asks user for a number
            string userinput = Console.ReadLine(); // strores usernumber in userinput
            File.WriteAllText(@"C:\Users\Michael\Logs\log.txt", userinput); // implement "using System,IO to log to file, logs userinput to file
            string printit = File.ReadAllText(@"C:\Users\Michael\Logs\log.txt"); // reads userinput and stores it in variable "printit"
            Console.WriteLine("You entered " + printit); // prints contents of "printit" which is the user's input number



            //string card = string.Format(Deck.Cards.First().ToString() + "\n");  // this is the beginning of the logging code
            //Console.WriteLine(card); // displays what was dealt to Hand
            //using (StreamWriter file = new StreamWriter(@"C:\Users\Michael\Logs\log.txt", true))  // this is the using System.IO method the system allows to log with. It will by using this Streamwriter code clean up after it
            //                                                                                      // logs and release the memory used to log this, "true" parameter appends existing instead of creating a new file everytime.
            //{
            //    file.WriteLine(card); // logs the card(s) dealt
            //}

            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Michael\Logs\log.txt", text);

            //string text = File.ReadAllText(@"C:\Users\Michael\Logs\log.txt"); // hover over "text" in string "text" and it will read the text in the file called



            Console.ReadLine();
        }
    }
}
