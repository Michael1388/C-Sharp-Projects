using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne // same namespace as the main Program 21
{
    public class Card // Class Card / Is public; = accessible for use by all parts of this program
                        //A Class is just a "Model" , a design for an object
    {   
        // now we are going to add "state" or properties
        public Card()   // This is called a "constructor" it is a "Method" or a "function" - It declares those Values assigned to an object upon creation.
                        // Those values seen below will be the default 
                        // values given to the Class "Card" if none other are specified
        {
            Suit = "Spades"; //"property called "Suit"
            Face = "Two";   //"property called "Face"
        }

        // below:  Class "Card" has a property of data type string called Suit and Face
        // and you can get and set this property. Is public, or accessible for use by all parts of this program.

        public string Suit { get; set; } // get, set; the only two things you can do with an Object property.
        public string Face { get; set; }
        
    }
}
