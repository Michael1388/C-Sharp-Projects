using System;
using System.Collections.Generic; // for Lists


class Program
{
    static void Main()
    {   //Array basics - arrays are limited whereas lists are more broad use.
        //You will usually use them when you have a fixed quantity that you want to group together
        //*** that you know isn't going to change bc in an array, once you set the size it is difficult to change it
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 }; // simplified version of the above code

        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 }; // YET ANOTHER EVEN MORE simplified version of the above code

        numArray2[5] = 650;

        // you can use what is called a byte array for very large objects
        // byte[] byteArray = new byte[5000];

        Console.WriteLine(numArray[3]);
        Console.WriteLine(numArray1[3]);
        Console.WriteLine(numArray2[5]);

        //Lists || using System.Collections.Generic;

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(4);

        Console.WriteLine(intList[0]);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Michael");
        //stringList.Remove("Hello");

        Console.WriteLine(stringList[0]);

        Console.ReadLine();
            
    }
}