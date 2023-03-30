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

    // 3. Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking. --Done

    // 4. Perform the same action again, but this time with a lambda expression. --Done

    // 5. Using a lambda expression, make a list of all employees with an Id number greater than 5. --Done

    // 6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee> { new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee(), new Employee() }; // 10 employees
            employeeList[0].FirstName = "joe"; //instance of joe
            employeeList[0].Id = 5; // assign id = 

            employeeList[1].FirstName = "sue"; //instance of joe
            employeeList[1].Id = 6; // assign id =

            employeeList[2].FirstName = "joe"; //instance of sue
            employeeList[2].Id = 7; // assign id =




            // # 3 - foreach loop
            List<Employee> joeList = new List<Employee>();

            foreach (Employee employee in employeeList)
            {

                if (employee.FirstName == "joe")
                {
                    joeList.Add(employee);
                    //Console.WriteLine(employee.FirstName);  // test result
                }

            }
            // END #3


            //#4. Lambda Expression

            List<Employee> newjoeList = employeeList.Where(x => x.FirstName == "joe").ToList();
            //Console.WriteLine(newjoeList[0].FirstName + ", " + newjoeList[1].FirstName);    // test result

            //#4 END


            //5. Lambda ID list > 5

            List<Employee> idjoeList = employeeList.Where(x => x.Id > 5).ToList(); // Lambda to return Id greater than 5
            //Console.WriteLine(idjoeList[0].Id + ", " + idjoeList[1].Id);  // test result

            //#5 END

            ////Console.WriteLine(joeList[0].FirstName + ", " + joeList[2].FirstName); // NOT USED

            Console.ReadLine();// keep it open
        }
     
        
    }
}
