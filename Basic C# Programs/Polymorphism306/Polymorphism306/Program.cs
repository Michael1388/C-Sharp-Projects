using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism306
{
    // 1 .Create an interface called IQuittable and have it define a void method called Quit(). --Done

    // 2. Have your Employee class from the previous drill inherit that interface and --Done
    //implement the Quit() method in any way you choose.

    // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. --Done
    //Hint: an object can be of an interface type if it implements that specific interface.

    // 4. Add comments to each line or block of your code to explain what it does exactly, --Done
    //so that another developer could read and understand your code.

    class Program
    {
        static void Main(string[] args)
        {
            {
                Employee employee = new Employee(); // instantiate and initialize Employee object
                employee.FirstName = new List<string>() { "Sample" }; // initialize Employee object
                employee.LastName = new List<string>() { "Student" }; //initialize Employee object
                employee.SayName();     //call superclass Method SayName
                employee.Quit(employee); //call Quit method from interface IQuittable


                Console.ReadLine(); // keep console window open
            }
        }
    }
}
