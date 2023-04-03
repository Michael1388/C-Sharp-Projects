using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer // public
    {
        public string Name { get; set; } // properties (prop tab tab)
        public Deck Deck { get; set; } // why would we not have Dealer class inherit from Deck?
                                       // Reason why is that inheritance is a "is a" not a "has a" relationship. "Is a" inherits, "has a" lists it as a property, like here.
                                       // If you are uncedrtain which way it shoudl be, make it a property( err on the side of caution. 
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            //is now to add LOGGING
            Hand.Add(Deck.Cards.First()); //Adds first item (card) in the Deck and moves it to Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); // displays what was dealt to Hand
            using (StreamWriter file = new StreamWriter(@"C:\Users\Michael\Logs\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0); // removes card from deck


            //was: 

            //Hand.Add(Deck.Cards.First()); //Adds first item (card) in the Deck and moves it to Hand
            //Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // displays what was dealt to Hand
            //Deck.Cards.RemoveAt(0); // removes card from deck
        }

    }
}
