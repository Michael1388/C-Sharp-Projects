using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterAssignment318
{
    //1. Make the Employee class take a generic type parameter. --DONE

    //2. Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class. --Done

    //3. Instantiate an Employee object with type “string” as its generic parameter.
    //3a. Assign a list of strings as the property value of Things.

    //4. Instantiate an Employee object with type “int” as its generic parameter.
    //4a. Assign a list of integers as the property value of Things.

    //5. Create a loop that prints all of the Things to the Console.

    //6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.

    public class Employee<T>   //new public Class Employee that is  of the <T> Generic Type
    {
       
        public List<T> things { get; set; } // Generic List named things

        
    }
}
