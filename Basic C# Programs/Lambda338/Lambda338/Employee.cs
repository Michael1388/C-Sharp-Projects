using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda338
{

    // 1.Create an Employee class with the following properties: --Done
    // a.Id
    // b.First Name
    // c. Last Name

    // 2.In the Main() method, create a list of at least 10 employees.At least two employees should have the first name “Joe”.

    // 3. Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.

    // 4. Perform the same action again, but this time with a lambda expression.

    // 5. Using a lambda expression, make a list of all employees with an Id number greater than 5.

    // 6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.


    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
