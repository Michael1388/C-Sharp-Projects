using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {   
        // Classes and Objects

        // Objects are items that can be represented by a cpu program.
        // They are often meant to represent real world things.
        // In the world around you, you are surounded by objects. The tv, the dog, etc.
        // Objects have state and behavior. The state of an object would be the size, color, etc at any point in time.

        //Methods - aka as Functions or Routines they are essentially the same thing: Little blocks of reusable code that do somethihng.
        //They are composed of an access modifier, that comes first, that basically says is this accessible everywhere in the program or just this Class? More on that later
        // Methods have to be part of a Class. If it is being used without first creating an Object of that Class then it has to be marked Static



        //21 Game!! Black Jack! A player and a dealer.

       //We will create a new class called Card - In the solution explorer to the right,
       // right click/ Add / Class / name file in this case "Card"

        static void Main(string[] args)
        {
            Deck deck = new Deck();  // created a new Object of data type called Deck. Weve instated an object called Deck and called it variable "deck", it's now empty
            deck = Shuffle(deck); // Call the method - declared below as:  public static Deck Shuffle(Deck deck) // comment this line out to see unshuffled deck

            foreach (Card card in deck.Cards) // to see list
            {
                Console.WriteLine(card.Face + " of " + card.Suit);  // to see list
            }
            Console.WriteLine(deck.Cards.Count);    // to see how many cards are in the list...should be 52

            //NONE OF THIS WILL BE NEEDED BC WE ARE GOING TO CREATE A CONSTRUCTOR IN DECK TO CREATE ALL THE CARDS AT ONCE INSTEAD OF ONE AT A TIME!!
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            //deck.Cards = new List<Card>(); // property of Deck



            //Card cardOne = new Card(); // Object of data type "Card"(Class) assigned to variable cardOne. We created a new Card in our program, a card object, we've instatiated an object an empty one..//commented out for Deck.cs
            //cardOne.Face = "Queen"; // assigned property "Face"  // these two would be commented out so that the constructor on Card.cs would assign it's values here
            //cardOne.Suit = "Spades"; // property "Suit"         // these two would be commented out so that the constructor on Card.cs would assign it's values here

            //deck.Cards.Add(cardOne); // added 1 card to deck 

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit); // write it to the screen // commneted out for Deck

            Console.ReadLine(); // keeps screen window open
        }

        public static Deck Shuffle(Deck deck) // A Method we've made called Shuffle with a return type called "deck"
        {
            List<Card> TempList = new List<Card>();   // temp list to store shuffled items
            Random random = new Random(); // random shuffle method 

            while (deck.Cards.Count > 0) // while loop 
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;

        }
    }
}
