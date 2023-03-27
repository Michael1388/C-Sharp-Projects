using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass302
{
    // 1. Create an abstract class called Person with two properties: string firstName and string lastName. --Done

    // 2. Give it the method SayName(). --Done

    // 3. Create another class called Employee and have it inherit from the Person class. --Done

    // 4. Implement the SayName() method inside of the Employee class. --Done

    // 5. Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”. Call the SayName() method on the object. --Done

    // 6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done

    public abstract class Person //public abstract class Person
    {

        public List<string> FirstName { get; set; } // public Person property FirstName of string type 
        public List<string> LastName { get; set; }  // public Person property LastName of string type 


        public virtual void SayName() // virtual Method "SayName"
        {
            //Nested Foreach loops to bring together First and last names and concatenate them into the desired return to console
            foreach (string firstName in FirstName)
            {

                foreach (string lastName in LastName)
                {
                    Console.WriteLine("\"" + firstName + "\"" + " " + "\""  + lastName + "\""); //return output of nested Foreach loops concatenate First and Last names into the desired return write to console
                }
            }

        }
    }
}
