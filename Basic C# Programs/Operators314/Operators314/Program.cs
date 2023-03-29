using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators314
{

    //Create an Employee class with Id, FirstName and LastName properties. --Done

    //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. --Done

    //In the "Program.cs" file, instantiate two objects of the Employee class and assign values to their properties.Then compare the two Employee objects using the newly overloaded operators and display the results. --Done

    //Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();     //Instantiate object
            Employee employee2 = new Employee();    //Instantiate object 2

            employee.FirstName = new List<string>() { "Mickey" }; // initialize Employee object
            employee.LastName = new List<string>() { "Mouse" }; // initialize Employee object
            employee.Id = 1;    //add value of 1 to employee property 


            employee2.FirstName = new List<string>() { "Minnie" }; // initialize Employee object
            employee2.LastName = new List<string>() { "Moose" }; // initialize Employee object
            employee2.Id = 2;   //add value of 2 to employee2 property

          


            Console.WriteLine((employee == employee2)); // display result of if equals, could also return if not equal !=
            
            Console.ReadLine(); // keep console window open

        }
       
    }
}
