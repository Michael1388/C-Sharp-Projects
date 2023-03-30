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
            //TwentyOneGame game = new TwentyOneGame(); // inherited from Game Class
            //game.Players = new List<string>() { "Michael", "Holly", "Josh" };
            //game.ListPlayers();

            //Game game = new TwentyOneGame(); // Polymorphism 

            //game.Players = new List<Player>(); // workaround for error experienced bc Game/List<> has not instantiated that list

            //Player player = new Player();
            //player.Name = "Michael";

            //game +=  player; // in a way this is our method that returns a game //overload the operator +=
            //game -= player; // added removed player to list...I guess we instantiated and added player now we are removing it

            //Card card = new Card();
            //card.Suit = Suit.Clubs;

            //int underlyingvalue = (int)Suit.Diamonds; // can convert an ENUM string of say a Clubs integer to a string... bc ENUM are kindof weird... they're underlying data type is integer 
            //Console.WriteLine(underlyingvalue);


            Deck deck = new Deck();  // created a new Object of data type called Deck. Weve instantiated an object called Deck and called it variable "deck", it's now empty
            deck.Shuffle(3);

            foreach (Card card in deck.Cards) // to see list
            {
                Console.WriteLine(card.Face + " of " + card.Suit);  // to see list
            }
            Console.WriteLine("Cards in deck: " + deck.Cards.Count);

            Console.ReadLine(); // keeps screen window open



            //DaysOfTheWeek day = DaysOfTheWeek.Monday; // ENUM example 

            //    public enum DaysOfTheWeek  /// example of an ENUM 
            //{
            //    Monday,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday

            //}




            //////////////// ??????? All of that below has been willted down to those 6 lines of code starting with ***********DECK DECK down there
            //// Card card = new Card() { Face = "King", Suit = "Spades" }; //Object initialization I hear this is called but looks like were not going to use it either

            //***********DECK DECK
            //Deck deck = new Deck();  // created a new Object of data type called Deck. Weve instantiated an object called Deck and called it variable "deck", it's now empty
            //deck.Shuffle(3);

            ////// below was comment out for multi deck funciton // then we used that same rewrite for the new multi parameter method
            //////deck = Shuffle(deck); // Call the method - declared below as:  public static Deck Shuffle(Deck deck) // comment this line out to see unshuffled deck
            ////int timesShuffled = 0; //added as below "timesShuffled"
            ////deck = Shuffle(deck: deck, out timesShuffled, times: 3); //overload method and or optional multi parameter method, works for both.
            ////                                      //To make it easier to read we added (deck: deck, times: 3) to what was just (deck, 3). either way works

            //foreach (Card card in deck.Cards) // to see list
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);  // to see list
            //}
            //Console.WriteLine("Cards counted in the deck: " + deck.Cards.Count);    // to see how many cards are in the list...should be 52
            ////Console.WriteLine("Times shuffled: {0}", timesShuffled); // added as above and below after adding "timesShuffled" 
            ////NONE OF THIS WILL BE NEEDED BC WE ARE GOING TO CREATE A CONSTRUCTOR IN DECK TO CREATE ALL THE CARDS AT ONCE INSTEAD OF ONE AT A TIME!!
            ////Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);

            ////deck.Cards = new List<Card>(); // property of Deck



            ////Card cardOne = new Card(); // Object of data type "Card"(Class) assigned to variable cardOne. We created a new Card in our program, a card object, we've instatiated an object an empty one..//commented out for Deck.cs
            ////cardOne.Face = "Queen"; // assigned property "Face"  // these two would be commented out so that the constructor on Card.cs would assign it's values here
            ////cardOne.Suit = "Spades"; // property "Suit"         // these two would be commented out so that the constructor on Card.cs would assign it's values here

            ////deck.Cards.Add(cardOne); // added 1 card to deck 

            ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit); // write it to the screen // commneted out for Deck

            //Console.ReadLine(); // keeps screen window open
        }
        //// shuffle function -----MOVED TO DECK
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) // A Method we've made called Shuffle with a return type called "deck"
        //                                                                            //weve added the int times = 1 with 1 as a default placeholder that can be changed as seen below.
        //                                                                            //We then added "out int timesShuffled" 
        //{
        //    timesShuffled = 0;  // added after as above
        //    for (int i = 0; i < times; i++) // added for multi option parameter above
        //    {
        //        //all of this was it's own seperate fuction before the optional parameter "int "times" = 1" was added.
        //        //We added that into this into the for loop and left the "return deck" outside which was under the deck.Cards = TempList; . 

        //        timesShuffled++;    // added after as above
        //        List<Card> TempList = new List<Card>();   // temp list to store shuffled items
        //        Random random = new Random(); // random shuffle method 

        //        while (deck.Cards.Count > 0) // while loop 
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;

        //    }
        //    return deck;

        //    // }
        //    //multi shuffle function //overload method -- or we can go back up and add this to the to the previous method for a single function
        //    //public static Deck Shuffle(Deck deck, int times)
        //    //{
        //    //    for(int i = 0; i < times; i++)
        //    //    {
        //    //        deck = Shuffle(deck);
        //    //    }
        //    //    return deck;
        //    //}
        //}
    }
}
