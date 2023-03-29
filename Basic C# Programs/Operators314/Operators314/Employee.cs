using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators314
{
    //Create an Employee class with Id, FirstName and LastName properties.  --Done

    //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. --Done
    //... meaning I'd have to use != also

    //In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.Then compare the two Employee objects using the newly overloaded operators and display the results. --Done

    //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

    public class Employee   //new public Class Employee 
    {
        public int Id { get; set; } // public int class property Id
        public List<string> FirstName { get; set; } // public property FirstName of string type 
        public List<string> LastName { get; set; }  // public property LastName of string type 


     
        public static bool operator ==(Employee id1, Employee id2) // overloading operator ==
        {
            return (id1.Id == id2.Id); // returns boolean result of equals to objects compared

            // same as above written differently for my reference later
            //{
            //    return true;
            //}

            //return false;


        }
        public static bool operator !=(Employee id1, Employee id2) // overloading operator !=
        {
            return (id1.Id != id2.Id);  // returns boolean result of not equals to objects compared

            // same as above written differently for my reference later
            //if (id1.Id != id2.Id)
            //{
            //    return true;
            //}


            //return false;

        }
    }
}
