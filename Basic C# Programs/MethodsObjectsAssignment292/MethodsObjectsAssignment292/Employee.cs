using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment292
{   // Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName. --Done

    // Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”. --Done

    // Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int. --Done

    // Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”. --Done

    // Call the superclass method SayName() on the Employee object. --Done

    // Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done

    public class Employee : Person //new Class Employee inherts from Person Class
    {
        public int Id { get; set; } // public int class property Id
    }
}
