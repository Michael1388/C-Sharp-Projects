using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {   
        public Deck() // constructor ALWAYS AT THE TOP // constructor - a method that is called as soon as an object is created  
        {
            Cards = new List<Card>();  //Data type empty List called Cards

            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; // List to loop through the Suits for the deck
            List<string> Faces = new List<string>()
                { 
                    "Two", "Three", "Four", "Five", "Six", "Seven",
                    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            
                };                                                                              // List to loop through the Faces for the deck

            // nested foreach loop
            foreach (string face in Faces) // foreach loop 1 // loop through each item four times (suit)
            {
                foreach (string suit in Suits)  // foreach loop 2
                {
                    //result we want from these loops we've iterated through

                    Card card = new Card();  // create a new card for each iteration called variable "card"
                    card.Suit = suit; // assign suit to each card iterated through
                    card.Face = face;   // assign face to each card iterated through
                    Cards.Add(card); // Adds new cards to Deck
                    // we've used the same variable "card" over and over 4 times here and can do that
                    // because it will not exist anywhere but inside of this loop.
                }
            }


            //This, our first example works if you want to add all 52 cards one at a time typed out INDIVIDUALLY- BUT there is an easier way!!

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

        }
             
        public List<Card> Cards { get; set; }
    }
}
