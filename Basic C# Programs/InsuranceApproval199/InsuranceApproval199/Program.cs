using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApproval199
{
    class Program
    {
        static void Main(string[] args)
        {
            //Applicant questionaire introduction

            Console.WriteLine("Insurance Application: ");   // write to console
            Console.WriteLine("Answer the following questions: ");  // write to console

            //Applicant questions and answers
            Console.WriteLine("What is your age?"); // write user input query to console
            string age = Console.ReadLine();    // store user input in string variable "age"
            int applicantAge = Convert.ToInt32(age);    // convert string "age" to int(eger) and store as variable "applicantAge" for use below
            //Console.WriteLine(applicantAge);  // uncommnet to view output data to console


            Console.WriteLine("TRUE or FALSE, Have you ever had a DUI?");   // write user input query to console
            string dui = Console.ReadLine();    // store user input in string variable "dui"
            bool answer = Convert.ToBoolean(dui);   // convert string "dui" to boolean value and store as variable "answer" for use below
            //Console.WriteLine(answer);  // uncommnet to view output data to console


            Console.WriteLine("How many speeding tickets do you have?");    // write user input query to console
            string tickets = Console.ReadLine();    // store user input in string variable "tickets"
            int ticketnums = Convert.ToInt32(tickets);  // convert string "tickets"to int(eger) and store as variable "ticketnums" for use below
            //Console.WriteLine(ticketnums);  // uncommnet to view output data to console

            // Does Applicant Qualify?
            bool qualify = (applicantAge > 15 && answer == false && ticketnums < 4); // if all are true,True will be stored in variable "qualify" if any are false will store False in var "qualify"
            Console.WriteLine("Do you qualify? " + qualify); // Print to screen and display variable "qualify" (True or False) based on information received from user input.


            Console.ReadLine(); // keeps console window open until closed by user



        }
    }
}
