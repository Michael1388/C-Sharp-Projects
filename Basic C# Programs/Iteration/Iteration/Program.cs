using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {
        //interate through an integer array
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }

        }

        //now through a string

        string[] names = { "Jesse", "Erik", "Daniel", "Adam", "Michael" };

        for (int j = 0; j < names.Length; j++)
        {
            //if (names[j] == "Michael") // comment out to see full list of names/ write to console if needed
            {
                Console.WriteLine(names[j]);
            }
        }


        int[] numberArray = { 300, 75, 420, 380, 225 };

        for (int i = 0; i < numberArray.Length; i++)
        {
            if (numberArray[i] / 2 >= 150)
            {
                Console.WriteLine(numberArray[i] + " divided by 2 is greater than or equal to 150");
            }
        }

        //returns:
        //300 divided by 2 is greater than or equal to 150
        //420 divided by 2 is greater than or equal to 150
        //380 divided by 2 is greater than or equal to 150


        // LISTS

        //LIST - INT

        List<int> testResults = new List<int>();
        testResults.Add(98);
        testResults.Add(99);
        testResults.Add(81);
        testResults.Add(72);
        testResults.Add(70);

        foreach (int result in testResults)
        {
            if (result > 85)
            {
                Console.WriteLine("Passing test score result: " + result);
            }
        }


        //LIST - STRING
        List<string> namesString = new List<string>() { "Michael", "Joshua", "Ethan", "Holly" };

        foreach (string userName in namesString)
        {
            //if (userName == "Holly")
            {
                Console.WriteLine(userName);
            }
        }


        // Adding something to something??....
        List<int> testResults1 = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>(); // new list to contain var "passingScores"

        foreach (int results in testResults1)
        {
            if (results > 85)
            {
                //Console.WriteLine("Passing test score result: " + results); to view results > 85
                passingScores.Add(results); // Add to new list "passingScores" "results" > 85
            }
        }
        Console.WriteLine(passingScores.Count); // to count results and write output to screen



        //JOsh example 

        int x = 0;
        Console.WriteLine("x is: " + x);
        Console.WriteLine("x after prepend is: " + ++x);
        Console.WriteLine("x postpend is: " + x++);
        Console.WriteLine("x post postpend is: " + x);


        //// ?? uncecessary code commented out 
        ////Console.WriteLine(fruitInventory.IndexOf(userfruit));

        ////if (fruitInventory.IndexOf(userfruit) != -1)
        ////{
        ////    Console.WriteLine("You chose: " + userfruit + ": Our inventory number is " + fruitInventory.IndexOf(userfruit) + ", and " + userfruit + " is available!");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("You've entered a fruit that is not available.");
        ////}
        //// ?? END uncecessary code commented out 
        ///

        //1 Iterate through a string array and add user input to the end of each array string

        Console.WriteLine("Enter your name: "); // write to screen, query user for input
        string useName = Console.ReadLine(); // store user input in string variable "useName"

        string[] names1 = { "Michael", "Jesse", "Erik" }; // create string array 

        for (int p = 0; p < names1.Length; p++)  // for loop to iterate through the string array
        {
            if (names1[p] == names1[p]) // if statement to call the values of our array
            {
                Console.WriteLine(names1[p] + " + " + useName); // write to console contents of variable "names1"
                                                                // and integer var "p" or  "names1[p]" plus variable "useName" 
            }
        }


        // 2. Create and infinte loop

        // int x = 1; // UNCOMMENT TO VIEW INFINITE LOOP
        while (x > 2)// infinite loop corrected from COMMENT OUT TO VIEW INFINITE LOOP
                     // (x == 1) which is an infinite loop UNCOMMENT TO VIEW INFINITE LOOP
        {
            Console.WriteLine("ahhhhhhhhhhhh!!!!!!!!!!!!!!!!"); //if  infinite loop is run, this prints to screen

        }

        // 3 Loop comparisons

        // interate through an integer array and compare with < operator

        int[] randomNumber = { 40, 99, 85, 70, 82, 34, 91, 90, 16 }; //int array instantiated

        for (int e = 0; e < randomNumber.Length; e++) // for loop iterating through array
        {
            if (randomNumber[e] < 80) // if statement comparing iteration of "randomNumber" to < 85
            {
                Console.WriteLine(randomNumber[e]); // print to console those values less than 85
            }

        }

        // interate through an integer array and compare with <= operator

        int[] numArray = { 250, 199, 30, 375, 201, 75 };   //int array instantiated

        for (int g = 0; g < numArray.Length; g++)  // for loop iterating through array
        {
            if (numArray[g] / 2 >= 75)  // if statement comparing iteration to >= 75
            {
                Console.WriteLine(numArray[g]); // print to console those values determined in if statement
            }
        }

        //5.
        Console.WriteLine("Check availability: "); // user input
        string userid = Console.ReadLine(); // user input is stored in var "userfruit"
        userid = userid.ToLower(); // convert to lower to match case in list 

        List<string> fruitList = new List<string>() { "apple", "grape", "apple", "kiwi", "banana" }; // list of values in string list


        List<string> familyList = new List<string>() { "Josh", "Josh", "Josh", "Josh", "Allie", "Holly", "Ethan", "Chris" }; // list of values in string list

        //for (declare variable used for itterating ; if statement that determines if the loop can continue ;  amount to increase variable by each itteration )

        // write a for loop that checks each element of the list to find an element that contains 'Chris' then print out its index
        string indexes = "";
        for (int a = 0; a < familyList.Count; a++)
        {
            if (familyList[a] == "Chris")
            {
                indexes += a + "";
            }
        }
        Console.WriteLine("Chris = " + indexes);

        // write a for loop that finds each instance of "Josh" and removes them, then prints the new list


        for (int b = 0; b < familyList.Count; b++)
        {
            if (familyList[b] == "Josh")
            {
                familyList.RemoveAt(b);
            }
        }
        string output = string.Join(",", familyList);

        Console.WriteLine(output);

        // ABOVE IS WRITTEN CORRECT EXCEPT THAT IT LEAVES DATA BECAUSE IT HAS TO BE WRITTEN IN REVERSE AS SHOWN BELOW

        for (int b = familyList.Count - 1; b >= 0; b--)
        {
            if (familyList[b] == "Josh")
            {
                familyList.RemoveAt(b);
            }
        }

        output = string.Join(",", familyList); //could eliminate var and..
        Console.WriteLine(output); //just use inside of ();(string.Join(",", familyList);

        //for (declare variable used for itterating (int i = 0;); if statement that determines if the loop can continue (i < length);  amount to increase variable by each itteration (i++)  )


        string indices = "";
        int k = 0;
        
            if (k < fruitList.Count) // 161
        {
            if (fruitList[k] == userid)
            {
                indices += k + " ";
            }
            k++;
            
        }
        Console.WriteLine(indices);

        int m = 0;
        while (m < fruitList.Count)
        {

            if (fruitList[m] == userid)
            {
                indices += m + " ";
            }
            m++;
        }

        Console.ReadLine(); // keeps window open until closed by user

    }

}


