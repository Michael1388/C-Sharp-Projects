using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment292
{   // 1. Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName. --Done

    // 2. Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: “Name: [full name]”. --Done

    // 3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int. --Done

    // 4. Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”. --Done

    // 5. Call the superclass method SayName() on the Employee object. --Done

    // 6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. --Done

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); // instantiate and initialize Employee object
            employee.FirstName = new List<string>() { "Sample" }; // initialize Employee object
            employee.LastName = new List<string>() { "Student" }; //initialize Employee object
            employee.SayName(); // call superclass Method SayName


            Console.ReadLine(); // keep console window open
        }
    }
}
