using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism306
{
    // 1 .Create an interface called IQuittable and have it define a void method called Quit(). --Done

    // 2. Have your Employee class from the previous drill inherit that interface and
    //implement the Quit() method in any way you choose. --Done

    // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. --Done
    //Hint: an object can be of an interface type if it implements that specific interface. 

    // 4. Add comments to each line or block of your code to explain what it does exactly, --Done
    //so that another developer could read and understand your code.

    interface IQuittable // interface called IQuittable
    {
        void Quit(Employee employee); //void method called Quit
    }
}
