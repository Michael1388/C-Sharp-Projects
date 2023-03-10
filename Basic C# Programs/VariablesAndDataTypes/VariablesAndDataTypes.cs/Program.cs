using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOCK COMMENT = CTRL+K+C

            // This is a simple program

            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //CASTING example string to int

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine(); // example began int "favoriteNumber" BUT can't bc Readline is string command, so CASTING, change to string "favoriteNumber" then...
            //int favNum = Convert.ToInt32(favoriteNumber); // CAST string to INT then we can add other numbers to it
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //DATA TYPES IN C#

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = 'X';
            char questionMark = '\u2103'; // u2103 is unicode for ?
            
            decimal moneyInBank = 100.5m; // "deciaml" requires m after the amount ex 100.5m for compliler sake 
            double heightInCentimeters = 211.30203092;
            float secondsLeft = 2.62f; // float must use f after 

            short temperaturesOnMars = -341;

            string myName = "Michael";

            // CAST or convert from int to string
            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            //convert bool to string
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            int num1 = 5;
            int num2 = 7;
            int total = num1 + num2;
            Console.WriteLine(total);
            Console.ReadLine();




        }
    }
}
