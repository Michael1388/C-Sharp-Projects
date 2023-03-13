using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperations1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////basic addition 
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());

            ////or
            //int totals = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = totals + otherTotal;
            //Console.WriteLine(combined);


            ////basic subtraction
            //int difference = 10 - 5;
            //Console.WriteLine(difference.ToString());
            ////or
            //Console.WriteLine("Ten minus Five = " + difference.ToString());

            ////basic multiplication *
            //int product = 10 * 5;
            //Console.WriteLine(product);

            //basic division
            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);

            ////basic division plus ...
            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);

            //Modulous % - or Remainders...Odds or Evens 
            //int even = 10 % 2;
            //int odd = 11 % 2;
            //Console.WriteLine(even);

            //int num1 = 200/3;
            //Console.WriteLine(num1);

            ////Comparison Operators or Booleans < > 
            //bool trueOrFalse = 12 < 5;
            //Console.Write(trueOrFalse.ToString());

            //int roomTemp = 70;
            //int currentTemp = 72;

            //bool isWarm = currentTemp > roomTemp;

            //Console.WriteLine(isWarm);

            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp <= roomTemp;
            //bool isWarm = currentTemp == roomTemp;
            bool isWarm = currentTemp != roomTemp;

            Console.WriteLine(isWarm);

            Console.ReadLine();
        }
    }
}
