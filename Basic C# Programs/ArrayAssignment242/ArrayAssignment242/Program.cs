using System;
using System.Collections.Generic;


namespace ArrayAssignment242
{
    class Program
    {
        static void Main()
        {
            // Create a one-dimensional Array of strings. Ask the user to
            // select an index of the Array and then display the string at that index on the screen.
            // Add in a message that displays when the user selects an index that doesn’t exist.

            Console.WriteLine("Enter a number between 0 and 5 to view the contents of that memory slot. "); // write user input query to console
            string userinput1 = Console.ReadLine();    // store user input in string variable "userinput1"
            int viewNum1 = Convert.ToInt32(userinput1);   // convert string "userinput1" to int(eger) and store as variable "viewNum1" 
            string[] stringArray1 = { "Egg", "Yolk", "Green Onions", "Chicken Broth", "Ginger", "Garlic" };  // create string array and store in variable "stringArray1"

            if (viewNum1 < 0 || viewNum1 > 5)  //if statement returns comment if user selects an index that doesn’t exist
            {
                Console.WriteLine("That choice does not exist.");   // write to console for error "does not exist"
                //viewNum1 = Convert.ToInt32(Console.ReadLine());   // store new choice in variable "viewNum1" --> needs a while loop..will work on later

            }
            else
           
               Console.WriteLine(stringArray1[viewNum1]); // write user choice to console





            // Create a one-dimensional Array of integers. Ask the user to select an index
            //of the Array and then display the integer at that index on the screen.
            // Add in a message that displays when the user selects an index that doesn’t exist.

            Console.WriteLine("Enter a number between 0 and 7 to view that memory slot. ");     // write user input query to console
            string userinput2 = Console.ReadLine();  // store user input in string variable "userinput2"
            int viewNum2 = Convert.ToInt32(userinput2);  // convert string "userinput2" to int(eger) and store as variable "viewNum2" 
            int[] numArray2 = { 100, 32, 15, 200, 525, 60, 88, 575 };  // create integer array and store in variable "numArray2"

            if (viewNum2 < 0 || viewNum2 > 7)   //if statement returns comment if user selects an index that doesn’t exist
            {
                Console.WriteLine("That choice does not exist.");    // write to console for error "does not exist"
                //viewNum2 = Convert.ToInt32(Console.ReadLine()); // store new choice in variable "viewNum2" --> needs a while loop..will work on later

            }
            else

            Console.WriteLine(numArray2[viewNum2]); // write user choice to console


            //Create a list of strings. Ask the user to select an index of the list and then
            //display the content at that index on the screen.

            Console.WriteLine("Enter a number between 0 and 6 to view the TEXT contained in that memory slot. ");   // write user input query to console
            string userinput3 = Console.ReadLine(); // store user input in string variable "userinput3"
            int viewNum3 = Convert.ToInt32(userinput3); // convert string "userinput3" to int(eger) and store as variable "viewNum3"
            List<string> stringList = new List<string>(); // create list store as variable "stringList
            stringList.Add("Hello"); //add string content
            stringList.Add("I");    //add string content
            stringList.Add("am");
            stringList.Add("Michael, ");
            stringList.Add("a");
            stringList.Add("real");
            stringList.Add("human.");

            if (viewNum3 < 0 || viewNum3 > 6)   //if statement returns comment if user selects an index that doesn’t exist
            {
                Console.WriteLine("That choice does not exist.");    // write to console for error "does not exist"
                //viewNum3 = Convert.ToInt32(Console.ReadLine()); // store new choice in variable "viewNum3" --> needs a while loop..will work on later

            }
            else


                Console.WriteLine(stringList[viewNum3]); // write user choice to console


            Console.ReadLine(); // keeps console open until closed by user....// && this concludes our program for today, thank you for participating :)


        }
    }
}
