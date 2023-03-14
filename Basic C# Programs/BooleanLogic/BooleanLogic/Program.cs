using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            //BOOLEAN LOGIC (&&) AND is represented by the && symbol, as follows:
            Console.WriteLine("Boolean Logic and the && operator");
            int packageWidth = 10;
            int packageHeight = 25;
            bool tooBig = (packageHeight > 25 && packageWidth > 25);
            Console.WriteLine(tooBig);

            //The output is False.
            //The above expression asks the question,
            // “True or false ?: Are both the package height
            //and the package width greater than 25 ?”
            //The answer is assigned to the variable called tooBig.

            Console.WriteLine("Boolean Logic and the && operator: Examples");
            // AND operator: all have to be TRUE to return TRUE
            Console.WriteLine(true && false); //false
            Console.WriteLine(true && true); //true
            Console.WriteLine(false && false); //false
            Console.WriteLine(true && true && true && false); //false


            //BOOLEAN LOGIC (||) OR is represented by the || symbol, as follows:
            Console.WriteLine("Boolean Logic and the OR || operator");
            int packWidth = 10;
            int packHeight = 25;
            bool tooBig1 = (packHeight > 25 || packWidth > 25);
            Console.WriteLine(tooBig1);

            //The output is False.
            //The above expression asks the question,
            //“True or false ?: Are either the package height or the package
            //width greater than 25 ?” The answer is assigned to the variable
            //called tooBig1.

            Console.WriteLine("Boolean Logic and the OR || operator: Examples");
            //will only evaluate to true if one of these are True
            Console.WriteLine(true || false); //true
            Console.WriteLine(true || true); //true
            Console.WriteLine(false || false); //false


            //BOOLEAN LOGIC: MULTIPLE USES OF AND
            //More than one AND can be used in an expression, as follows:
            Console.WriteLine("BOOLEAN LOGIC: MULTIPLE USES OF AND");
            string firstName = "Jesse";
            string lastName = "Johnson";
            string socialSecurityNumber = "111-11-1111";

            bool isAuthorized = (firstName == "Jesse" && lastName == "Johnson" && socialSecurityNumber == "111-11-1111");
            Console.WriteLine(isAuthorized);

            //The output is True.
            //The above expression asks the question,
            //“True or false ?: Is this person’s first name ‘Jesse’ and his last name
            // ‘Johnson’ and is his social security number ‘111 - 11 - 1111’?”
            //The answer is assigned to the variable called isAuthorized.


            //BOOLEAN LOGIC MULTIPLE USES OF OR
            //The same goes for the OR operator, as follows:

            Console.WriteLine("BOOLEAN LOGIC: MULTIPLE USES OF OR");
            int bankAccountBalance = 500;
            bool isInARockBand = false;
            string name = "Jesse";

            bool isReallyCool = (bankAccountBalance > 100000 || isInARockBand || name == "Jesse");

            Console.WriteLine(isReallyCool);

            //The output is True.
            //The above expression asks the question, “True or false ?:
            //Does this person have over a hundred thousand dollars in his
            //bank account or is he in a rock band or is his name Jesse ?”
            //The answer is assigned to the variable called isReallyCool.


            //BOOLEAN LOGIC COMBINING && AND ||
            //Sometimes both operators are used in one line of code, like as follows:
            Console.WriteLine("BOOLEAN LOGIC: COMBINING && AND || ");
            bool result = (true && (true || false));
            Console.WriteLine(result);

            //The output is True.
            //For example:
            Console.WriteLine("BOOLEAN LOGIC: COMBINING && AND || for example: ");
            int num1 = 7;
            int num2 = 12;
            int num3 = 23;
            int num4 = 14;
            int num5 = 8;
            int num6 = 5;

            bool resultedin = (num1 > num2 && (num3 == num4 || num5 > num6));
            Console.WriteLine(resultedin);

            //The output is False.
            //This code asked the question, “True or false ?: is this true AND either
            //this or this true ?
            //The answer was then assigned to the variable called result.

            Console.WriteLine("Are you permitted to board international flight? ");
            int age = 31;
            bool hasTicket = true;
            bool hasPassport = true;

            bool canFly = (age >= 18 && hasTicket && hasPassport);
            Console.WriteLine(canFly);

            //True


            // BOOLEAN LOGIC: Not Operator !=
            Console.WriteLine("BOOLEAN LOGIC: Not Equal Operator != ");
            Console.WriteLine(true != true); //false
            Console.WriteLine(true != false); //true
            Console.WriteLine(false != false); //false

            //X OR Operator ^
            // Will evaluate to TRUE if one are TRUE bot NOT BOTH
            Console.WriteLine("BOOLEAN LOGIC: X OR operator ^ ");
            Console.WriteLine(true ^ true); //false
            Console.WriteLine(true ^ false); //true
            Console.WriteLine(false ^ false); //false

            Console.ReadLine();
        }
    }
}
