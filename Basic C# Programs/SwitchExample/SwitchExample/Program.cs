using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch(userNumber)
            {
                case 0:
                    {
                        Console.WriteLine("User selected number 0");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("User selected number 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("User selected number 2");
                        goto case 5;
                    }
                case 5:
                    {
                        Console.WriteLine("User selected number 2, but we are also in 5 now");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("User selected number " + userNumber);
                        break;
                    }
            }
            Console.ReadLine();

            if (userNumber == 0)
            { 
            
            }
            else if (userNumber == 1)
            {

            }
            else
            {

            }
        }
    }
}