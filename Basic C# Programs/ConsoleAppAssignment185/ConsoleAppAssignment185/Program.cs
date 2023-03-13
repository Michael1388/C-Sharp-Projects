using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment185
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1. User input is multiplied by 50 and printed to console:
            Console.WriteLine("Please enter a number to multiply by 50: "); // write user input query to console
            string usernum1 = Console.ReadLine(); // store user input in variable "usernum1"
            int convertUser1 = Convert.ToInt32(usernum1); // convert string to int(eger) and store as variable "convertUser1" to be able to multiply by integer on next line
            double result = convertUser1 * 50; // using double to have 64bit data field, using var "convertUser1" multiply by 50 and store result in var "result"
            Console.WriteLine("Your number multiplied by 50 is: " + result); // write the stored value of "result" to the console

            //2. Add 25 to User input and print to console:
            Console.WriteLine("Please enter a number to add to 25: "); // write user input query to console
            string usernum2 = Console.ReadLine(); //store user input in variable "usernum2"
            int convertUser2 = Convert.ToInt32(usernum2); // convert string to int(eger) and store as variable "convertUser2" to be able to add integer on next line
            double results = convertUser2 + 25; // using double to have 64bit data field, using var "convertUser2" add 25 and store result in var "results"
            Console.WriteLine("Your number plus 25 is: " + results); // write the stored value of "results" to the console

            //3. Divide User input by 12.5 and print result to console:
            Console.WriteLine("Please enter a number to divide by 12.5: "); // write user input query to console
            string usernum3 = Console.ReadLine(); //store user input in variable "usernum3"
            int convertUser3 = Convert.ToInt32(usernum3); // convert string to int(eger) and store as variable "convertUser3" to be able to divide float integer on next line
            float resultF = convertUser3 / 12.5f; // change data type to float, using var "convertUser3" divide by 12.5 and store result in var "resultF"
            Console.WriteLine("Your number divided by 12.5 is: " + resultF); // write the stored value of "resultF" to the console

            //4. Check User input is greater than 50 and print True/False result to console:
            Console.WriteLine("Please enter any number: "); // write user input query to console
            string usernum4 = Console.ReadLine(); //store user input in variable "usernum4"
            int convertUser4 = Convert.ToInt32(usernum4); // convert string to int(eger) and store as variable "convertUser4 "to be able to compare boolean result on next line
            bool boolresult = convertUser4 > 50; // using var "convertUser4" query whether it's true or false that it "convertUser4" is greater than > 50 and store result in var "boolresult"
            Console.WriteLine("Is your number greater than 50?: " + boolresult); // write the stored value of "boolresult" to the console

            //5. Take input from user, divide it by 7 and print the remainder to the console:
            Console.WriteLine("Please enter a number to divide by 7: "); // write user input query to console
            string usernum5 = Console.ReadLine(); //store user input in variable "usernum5"
            int convertUser5 = Convert.ToInt32(usernum5);  // convert string to int(eger) and store as variable "convertUser5 "to be able to compare modulous remainder result on next line
            int modresult = convertUser5 % 7; // determine the remainder of "convertUser5" / 7  and store result in var "modresult"
            Console.WriteLine("Your number divided by 7 has a remainder of: " + modresult); // write the stored value of "modresult" to the console


            Console.ReadLine(); // keeps console open and active until closed by user.
        }
    }
}
