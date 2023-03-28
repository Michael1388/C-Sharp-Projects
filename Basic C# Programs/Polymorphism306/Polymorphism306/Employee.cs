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

    // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. -- Done

    // 4. Add comments to each line or block of your code to explain what it does exactly,
    //so that another developer could read and understand your code. --Done

    public class Employee : Person, IQuittable //new Class Employee inherts from Person Class and has Interface IQuittable 
    {
        //public override void SayName()
        //{
        //    base.SayName();  // calling the base class "SayName" method
        //}

        //public void Quit(Employee employee) // Polymorphism of Employee 
        public void Quit(string name)
        {

            Console.WriteLine(name + " Quits.");
            //base.FirstName = new List<string>() { "John" };   // initialize Employee object
            //base.LastName = new List<string>() { "Smith" };  //initialize Employee object
            //base.SayName(); // calling the base class "SayName" method


        }

    }
}
