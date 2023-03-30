using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums325
{

    //1. Create an enum for the days of the week. --Done

    //2. Prompt the user to enter the current day of the week. --Done

    //3. Assign the value to a variable of that enum data type you just created. --Done

    //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs. --Done

    //5. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter the current day of the week: "); /// ask user for input
                string userInput = Console.ReadLine(); // store user input in variable input
                string input = userInput.ToLower(); // converts string to Lower case to match case used in Enum DaysOfTheWeek

                //test loop checking for values// not necessary but keeping for future reference

                //foreach (DaysOfTheWeek today in Enum.GetValues(typeof(DaysOfTheWeek)))
                //{
                //    Console.WriteLine(today);
                    
                //    if (Enum.GetName(typeof(DaysOfTheWeek), today) == input)
                //    {
                //        Console.WriteLine("Found");
                //    }
                //}
                
               
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input); // Parse through days of week to find match with user input

                Console.WriteLine(day); // write to console
            }


            catch ( Exception ex) // catch function, general exception catch all
            {
                Console.WriteLine(ex.Message + " Please enter an actual day of the week."); // catch statement

            }


            Console.ReadLine();
        }
        public enum DaysOfTheWeek  // ENUM DaysOfTheWeek
        

        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday

        }
    
    }

}
