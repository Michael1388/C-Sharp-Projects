using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //different methods of string useage and \escapes
            string name = "Michael";
            string quote = "The man said, \"Hello\", Michael.\n Hello on a new line. \nAlso a double\\to show one\\ \t which is an escape for a tab,";
            string fileName = "C:\\Users\\Michael"; //takes two \\ to show one
            string altFileName = @"C:\\Users\\Michael\folder\folder http\\:stuff.com\file\here\index.com";

            // \ is an "escape" charachter allowing quotes to be used inside of quotes
            // w/o being recognized as part of the program code, an "escape"
            // can also use \n for a new line, \t for tab and a \\ to show one \
            
            //@@ you can also use the @ symbol which tells the program that everything
            // is in the string and no escapes are needed 

            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(altFileName);

            //Call various functions on a string variable with string variable

            bool trueOrFalse = name.Contains("h"); //true
            trueOrFalse = name.EndsWith("s"); // false reassigns variable and returns most recent asssignment

            int length = name.Length; // property of a string this case is 7 for Michael
            name = name.ToUpper(); // converts to uppercase**, can use to convert user input to all uppercase or...whatevs
            name = name.ToLower(); //yes, lower lol (**this will default to last used variable assignment...this one) 
            // ToUpper or ToLower makes it easy to compare strings

            //Strings are IMMUTABLE, meaning once you create them they can't be changed.
            //If you change it, it actually creates a new string, which can become a
            //problem if you are creating very large programs so you can use what is
            //called "STRING BUILDER"...welll get to that later but here is a quick example.
            //which technically are objects and classes... but more about that later

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Michael");




            Console.WriteLine("Name contains letter h ? " + trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(name);
            Console.WriteLine(sb);


            Console.ReadLine();


        }
    }
}
