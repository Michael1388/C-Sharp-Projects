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

    public class Employee : Person //new Class Employee inherts from Person Class
    {
        public override void SayName()
        {
            base.SayName();  // calling the base class "SayName" method
        }
        
    }
}
