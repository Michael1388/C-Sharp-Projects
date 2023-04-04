using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor385
{
    public class User
    {
        public User (string name) : this(name, 21) // 3. User Chaining Constructor
        { 
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }


    }
}
