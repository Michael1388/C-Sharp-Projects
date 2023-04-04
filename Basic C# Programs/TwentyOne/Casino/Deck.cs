using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {   
        //Deck deck = new Deck(); comes from this CONSTRUCTOR
        public Deck() // constructor ALWAYS AT THE TOP // constructor - a method that is called as soon as an object is created  
        {
            Cards = new List<Card>();  //Data type empty List called Cards
            
            for (int i = 0; i < 13; i++) //iterate through i 13 times (faces)
            {
                for (int j = 0; j < 4; j++) //iterate through j 4 times (suits)
                {
                    Card card = new Card(); //instantiate new card 
                    card.Face = (Face)i;    //put the data type you are casting to, inside the parenteses, as so(Face), so we are casting to Face, i;  which will be done 13 times
                    card.Suit = (Suit)j;    // cast to Suit, j; which will be done 4 times
                    Cards.Add(card);    //Add card to Cards List 13 x 4 = 52 cards

                }
            }
            
            
            
            
            
            // re coded this after changin to ENUM in CARD CLASS
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; // List to loop through the Suits for the deck
            //List<string> Faces = new List<string>()
            //    { 
            //        "Two", "Three", "Four", "Five", "Six", "Seven",
            //        "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            
            //    };                                                                              // List to loop through the Faces for the deck

            //// nested foreach loop
            //foreach (string face in Faces) // foreach loop 1 // loop through each item four times (suit)
            //{
            //    foreach (string suit in Suits)  // foreach loop 2
            //    {
            //        // re coded this after cahngin to ENUM in CARD CLASS
            //        ////result we want from these loops we've iterated through

            //        //Card card = new Card();  // create a new card for each iteration called variable "card"
            //        //card.Suit = suit; // assign suit to each card iterated through
            //        //card.Face = face;   // assign face to each card iterated through
            //        //Cards.Add(card); // Adds new cards to Deck
                    
            //        //// we've used the same variable "card" over and over 4 times here and can do that
            //        //// because it will not exist anywhere but inside of this loop.
            //    }
            //}


            //This, our first example works if you want to add all 52 cards one at a time typed out INDIVIDUALLY- BUT there is an easier way!!

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

        }
             
        public List<Card> Cards { get; set; }

        // shuffle function
        public void Shuffle(int times = 1) // A Method we've made called Shuffle with a return type called "deck"
                                                                                    //weve added the int times = 1 with 1 as a default placeholder that can be changed as seen below.
                                                                                    //We then added "out int timesShuffled" 
        {
           
            for (int i = 0; i < times; i++) // added for multi option parameter above
            {
                //all of this was it's own seperate fuction before the optional parameter "int "times" = 1" was added.
                //We added that into this into the for loop and left the "return deck" outside which was under the deck.Cards = TempList; . 

               
                List<Card> TempList = new List<Card>();   // temp list to store shuffled items
                Random random = new Random(); // random shuffle method 

                while (Cards.Count > 0) // while loop 
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;

            }
            

           
        }
    }
}
