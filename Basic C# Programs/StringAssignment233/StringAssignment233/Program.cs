using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment233
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Assignment 
            //1. Concatenate three strings
            string name = "My name is Michael. ";
            string sentence = "I am happy to have met you. ";
            string sentence2 = "Hopefully we can do this again sometime!";

            Console.WriteLine(name + sentence + sentence2); // concatenates the three above strings
            
            //2. Converts a string to uppercase
            sentence = sentence.ToUpper(); // converts the string "sentence" to uppercase
            Console.WriteLine(sentence); // prints to console


            //3. Creates a StringBuilder and builds a paragraph of text,
            // one sentence at a time.

            StringBuilder sb = new StringBuilder();
            sb.Append("Hi! ");
            sb.Append("My name is Michael. I used Append here. ");
            sb.AppendLine("I'm not exactly sure when I am going to get a new line. I used AppendLine here");
            sb.AppendLine("It appears AppendLine indicates to the next line of code to begin on a new line. I used AppendLine here also. ");
            sb.Append("Append appears to indicate to the next line that it should Append to the previous line, or this one in this case because I used Append here. ");
            sb.AppendLine("But I am not sure so this test should give me a better uderstanding of how it operates. (I used AppendLine here). ");
            sb.AppendLine("This is a new line."); // because I figured it out!!!!!!

            Console.WriteLine(sb);

            Console.ReadLine(); // keeps console window open


        }
    }
}
