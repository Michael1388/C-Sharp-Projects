using System;


namespace MathComparisonOperator186
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // write to console

            //Person 1
            Console.WriteLine("Person 1"); // write to console
            Console.WriteLine("Enter Hourly Rate"); // write user input query to console
            string hourlyRateP1 = Console.ReadLine();   // store user input in string variable "hourlyRateP1"
            Console.WriteLine("Enter Hours Worked Per Week");   // write user input query to console
            string hoursWorkedP1 = Console.ReadLine();  // store user input in string variable "hoursWorkedP1"

            //Person 2
            Console.WriteLine("Person 2");  // write to console
            Console.WriteLine("Enter Hourly Rate"); // write user input query to console
            string hourlyRateP2 = Console.ReadLine();   // store user input in string variable "hourlyRateP2"
            Console.WriteLine("Enter Hours Worked Per Week"); // write user input query to console
            string hoursWorkedP2 = Console.ReadLine();  // store user input in string variable "hoursWorkedP2"

            //Annual Salary Person 1
            Console.WriteLine("Annual Salary of Person 1: ");   // write to console
            int convertHR1 = Convert.ToInt32(hourlyRateP1);  // convert string "hourlyRateP1"to int(eger) and store as variable "convertHR1" to be able to multiply integers below
            int convertHW1 = Convert.ToInt32(hoursWorkedP1);    // convert string "hoursWorkedP1"to int(eger) and store as variable "convertHW1" to be able to multiply integers below
            int multiply1 = convertHR1 * convertHW1 * 52;   // multiply integers "convertHR1" and "convertHW1" by each other and then * by 52 and store in variable "multiply1"
            Console.WriteLine("$" + multiply1); // writes to console Annual Salary of Person 1  which is the variable "multiply1"

            //Annual Salary Person 2
            Console.WriteLine("Annual Salary of Person 2: ");   // same as "Annual Salary Person 1" above with variable names ammended to apply accordingly
            int convertHR2 = Convert.ToInt32(hourlyRateP2);
            int convertHW2 = Convert.ToInt32(hoursWorkedP2);
            int multiply2 = convertHR2 * convertHW2 * 52;
            Console.WriteLine("$" + multiply2);

            //Annual Salary Comparison 
            Console.WriteLine("Does Person 1 make more money than Person 2?");  // write to console
            bool boolresult = multiply1 > multiply2;    // using boolean data type compare Salariy of "Person 1" or var "multiply1 being greater than "Person 2" or var "multiply2 and store result in var "boolresult"
            Console.WriteLine("Answer: " + boolresult); // print to console the result of "boolresult" based on input data represented by variables in preceeding line. 

            Console.ReadLine(); //keeps console window open until closed by user 
        }
    }
}
