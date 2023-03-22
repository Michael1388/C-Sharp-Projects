using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        //1 Iterate through a string array and add user input to the end of each array string

        Console.WriteLine("Enter your name: "); // write to screen, query user for input
        string uName = Console.ReadLine(); // store user input in string variable "uName"

        string[] names = { "Michael", "Jesse", "Erik" }; // create sting array 

        for (int i = 0; i < names.Length; i++)  // for loop to iterate through the string array
        {
            if (names[i] == names[i]) // if statement to call the values of array
            {
                Console.WriteLine(names[i] + " + " + uName); // write to console contents of variable "names"
                                                             // and integer var "i" or  "names[i]" plus variable "uName" 
            }
        }


        // 2 Create and infinte loop
        int x = 1;
        while (x > 2)// infinite loop corrected from
                     // (x == 1) which is an infinite loop
        {
            Console.WriteLine("ahhhhhhhhhhhh!!!!!!!!!!!!!!!!"); //if  infinite loop is run, this prints to screen

        }


        //3.Loop comparisons

        //3.1 interate through an integer array and compare with < operator

        int[] randomNumbers = { 40, 99, 85, 70, 82, 34, 91, 90, 16 }; //int array instantiated


        for (int r = 0; r < randomNumbers.Length; r++) // for loop iterating through array
        {
            Console.WriteLine("< loop " + randomNumbers[r]); // print to console those values less than 85
        }

        // 3.3 interate through an integer array and compare with <= operator


        for (int j = 0; j <= 8; j++)  // for loop iterating through array
        {
            Console.WriteLine("<= loop " + randomNumbers[j]); // print to console those values determined in if statement
        }


        // 4. List of unique strings

        Console.WriteLine("Check if your favorite fruit is availabile: "); // user input
        string userfruit = Console.ReadLine(); // user input stores in "userfruit"
        userfruit = userfruit.ToLower(); // convert to lower to match case in list array

        List<string> fruitInventory = new List<string>() { "apple", "peach", "orange", "kiwi", "banana" }; // list of values in string list

        bool found = false; // set value of found to false
        foreach (string value in fruitInventory) // interate through string
        {
            if (value == userfruit) // if user input matches value in List string "fruitInventory"
            {
                found = true; // if match is found, "found = true"
                break; // program ends if found and continues to next loop
            }
        }


        if (found) // if found is true
        {       // console writes to screen and displays user's choice and matching index of list item in upper case
            Console.WriteLine(userfruit.ToUpper() + ": Our inventory number is " + fruitInventory.IndexOf(userfruit) + ", and " + userfruit.ToUpper() + " is available!");
        }
        else // otherwise tells user that the text entered in not (in the list) available
        {
            Console.WriteLine("You've entered a fruit that is not available.");
        }



        // 5. Two identical Strings 

        // 1 list of strings -- DONE
        // 2 get user input -- DONE
        // 3 create a lopp that iterates though 1 -- DONE
        // 4 while in that loop get the element number of found matches comparing 2 --DONE
        // 5 remove any break statements that prevent code from returning multiple matches --DONE
        // 6 add code to loop to check to see if user put text in that isn't in the list --DONE
        // 7 if user did 6 imform user input not in list --DONE


        Console.WriteLine("Check availability: "); // user input
        string userinput = Console.ReadLine(); // user input is stored in var "userfruit"
        userinput = userinput.ToLower(); // convert to lower to match case in list 

        List<string> fruitList = new List<string>() { "apple", "grape", "apple", "kiwi", "banana" }; // list of values in string list
        bool founditem = false; // set value of found to false
        string indices = ""; // create empty variable to store matches during iteration

        for (int f = 0; f < fruitList.Count; f++) // iterate through the list
        {
            if (fruitList[f] == userinput) // if user userinput matches index in fruitlist assign it to f
            {
                founditem = true;   // create true state in bool 
                indices += f + " ";     //add matching index items to variable indices

            }

        }

        if (!founditem) // if userinput item not found 
        {

            Console.WriteLine("You've entered an item that is not available."); // tell user not found

        }
        else
        {
            Console.WriteLine(indices); // print index number of found items requested
        }


        // 6.

        // 1. Create list with two identical strings
        // 2. Create foreach loop that evaluates whether each item is unique or a duplicate
        // 3. Print results to console

        List<string> dupNames = new List<string>() { "Josh", "Ethan", "Chris", "Holly", "Allie", "Josh", "Ethan" }; // list with duplicate entries
        List<string> namesUnique = new List<string>(); // new list to contain sorted items from "names" list

        foreach (string item in dupNames) // iterate through list "name" store list item in variable "item" 
        {
            if (!namesUnique.Contains(item)) // checks if "item" is not contained in "namesUnique"
            {
                namesUnique.Add(item); // adds "item" to "namesUnique" 
                Console.WriteLine("These items are unique: " + item); // prints unique items to console

            }
            else // else
            {
                Console.WriteLine("This item is a duplicate: " + item); // prints duplicate items to console
            }
        }

        //Console.WriteLine(string.Join(",", namesUnique)); // checked condition of if statement to view results while writing code 



        Console.ReadLine(); // keeps window open until closed by user or enter / return key is pressed again
    }
}


