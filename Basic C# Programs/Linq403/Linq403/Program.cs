using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq403
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source
            string[] students = new string[] { "Joe", "Fred", "Sue", "Alan", "Mary", "Elizabethann", "Holly" };

            //Define the query expression.
            IEnumerable<string> studentQuery =
                from student in students
                where student.Length >= 5 // >= names length returns Elizabethann Holly
                select student;

            //Execute the query.
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }

            Console.ReadLine();

        }
    }
}
//In this image, first note that we are using System.Linq. The System.Linq namespace provides classes and interfaces that support queries that use LINQ.

//Next, our data source is created. The string array “students” is the data source that we will use LINQ to query. Since LINQ will return results as an object,
//the query must be stored in a variable that the object can be returned to. In the example above, the query is saved to the variable “studentQuery.”
//The query syntax is stored inside of that variable.

//The next step is to execute the LINQ query. For this example we are executing the query through a foreach loop.