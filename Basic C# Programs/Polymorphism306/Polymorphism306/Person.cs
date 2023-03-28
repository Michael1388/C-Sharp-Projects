using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism306
{
    // 1 .Create an interface called IQuittable and have it define a void method called Quit().

    // 2. Have your Employee class from the previous drill inherit that interface and
    //implement the Quit() method in any way you choose. --Done

    // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. --Done
    //Hint: an object can be of an interface type if it implements that specific interface.

    // 4. Add comments to each line or block of your code to explain what it does exactly, --Done
    //so that another developer could read and understand your code.

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
                    Console.WriteLine("\"" + firstName + "\"" + " " + "\"" + lastName + "\""); //return output of nested Foreach loops concatenate First and Last names into the desired return write to console
                }
            }

        }
    }
}
