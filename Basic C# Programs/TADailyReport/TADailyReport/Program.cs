using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Purpose: To create a daily report(DR) for students of The Tech Academy.

            Console.WriteLine("The Tech Academy\nStudent Daily Report"); //write to screen
            Console.WriteLine("What is your name?"); //write to screen
            string yourName = Console.ReadLine(); //stores user input in variable yourName of data type string

            Console.WriteLine("What course are you on?");//write to screen
            string courseName = Console.ReadLine(); //stores user input in variable courseName of data type string

            Console.WriteLine("What page number?"); //write to screen
            string pageNumber = Console.ReadLine(); //stores user input in variable pageNumber of data type string
            int userInputPageNumber = Convert.ToInt32(pageNumber); // convert to integer
            //Console.WriteLine(userInputPageNumber); //print to review accurate functionality

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");//write to screen
            string needHelp = Console.ReadLine();   //stores user input in variable needHelp of data type string
            bool userNeedHelp = Convert.ToBoolean(needHelp); // convert to bool
           //Console.WriteLine(userNeedHelp); //print to review accurate functionality

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");   //write to screen
            string positiveExperiences = Console.ReadLine();  //stores user input in variable positiveExperiences of data type string  

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");//write to screen
            string otherFeedback = Console.ReadLine();  //stores user input in variable otherFeedback of data type string  

            Console.WriteLine("How many hours did you study today?");//write to screen
            string studentHours = Console.ReadLine(); //stores user input in variable studentHours of data type string --- wanted to use byte but not sure how to convert...
            int hoursStudied = Convert.ToInt32(studentHours);   //stores user input in variable hoursStudied of data type string 
            //byte studentHours = Convert.ToInt32(hoursStudied);
            //Console.WriteLine(hoursStudied); //print to review accurate functionality

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");//write to screen
            Console.ReadLine(); // used to continue screen being in active state allowing ability to read before program automatically closes the console.

        }

    }
}
