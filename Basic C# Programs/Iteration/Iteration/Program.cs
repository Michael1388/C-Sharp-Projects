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
            if (names[j] == "Michael")
            {
                Console.WriteLine(names[j]);
            }
        }
        Console.ReadLine();

    }
}

