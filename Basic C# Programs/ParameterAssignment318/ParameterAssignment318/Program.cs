using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment318
{

    //1. Make the Employee class take a generic type parameter. --Done
    
    //2. Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class. --Done
    
    //3. Instantiate an Employee object with type “string” as its generic parameter. --Done
    //3a.Assign a list of strings as the property value of Things. --Done
    
    //4. Instantiate an Employee object with type “int” as its generic parameter. --Done
    //4a. Assign a list of integers as the property value of Things.--Done
    
    //5. Create a loop that prints all of the Things to the Console. --Done
    
    //6.Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();     //Instantiate <generic string> object
            Employee<int>employee2 = new Employee<int>();    //Instantiate <generic int> object 2

            employee.things = new List<string>() { "Moe is "}; // Assign a list of strings as the property value of Things 
            employee2.things = new List<int>() { 21 }; //Assign a list of integers as the property value of Things

            foreach (string thing in employee.things) // loop through "things"
            {   
                foreach (int thing2 in employee2.things)

                {
                    Console.WriteLine(thing + thing2); // prints things to console
                }
            }

        


            Console.ReadLine(); // keep console window open

        }
    }
}
