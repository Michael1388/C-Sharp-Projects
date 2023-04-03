using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime370
{   
    class Program
    {
        //1. Prints the current date and time to the console. --Done
        //2. Asks the user for a number. --Done
        //3. Prints to the console the exact time it will be in X hours,
        // X being the number the user entered in step 2. --Done
        //4. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.--Done

        static void Main(string[] args)
        {
            Console.WriteLine("Current date and time is: " + DateTime.Now); // Display current Date and Time
            Console.WriteLine("User, enter a number of hours to add to the current time: "); // Ask user for number input to add to hours
            int usernumber = Convert.ToInt32(Console.ReadLine()); // store in variable usernumber

            DateTime usertime = DateTime.Now.AddHours(usernumber); // convert usernumber and add to DateTime.Now (aka current time and date) and store in var "usertime"
            Console.WriteLine("Your New Time is: " + usertime); // print new time result to console


            Console.ReadLine(); // keeps console open to view
        }
    }
}
