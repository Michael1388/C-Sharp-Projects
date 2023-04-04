using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

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
            //Logging EXAMPLES: add "using System.IO;" to top of page with other "using"s

            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Michael\Logs\log.txt", text);

            //string text = File.ReadAllText(@"C:\Users\Michael\Logs\log.txt"); // hover over "text" in string "text" and it will read the text in the file called

            //DateTime and TimeSpan usage EXAMPLES:

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 5, 23, 8, 32, 45);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;




            ////Dictionary<string, string> newDictionary = new Dictionary<string, string>(); // OR INSTEAD DO THIS
            // var newDictionary = new Dictionary<string, string>();


            // //Player newPlayer = new Player("Michael"); OR INSTEAD--
            // var newPlayer = new Player("Michael"); //var - instead of Player - don't have to name the data type after 4.0 C#

            // DON'T FORGET TO REBUILD CASINO SOLUTION OR OTHER "REFERENCES" AFTER EDITS OTHERWISE PROGRAM MAIN WILL NOT WORK 

            const string casinoName = "BlackJack table"; //Constant keyword Example

            //Guid identifier = Guid.NewGuid(); //GUID Global Uniquie Identifier

            Console.WriteLine("Welcome to my {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            //error handling 
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); // int is just like saying Convert.ToInt32. Try Parse has options for in and output
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }
            //End error handle
            //Console.WriteLine("And how much money did you bring today?"); // REPLACED ABOVE with Error Handling
            //int bank = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);

                player.Id = Guid.NewGuid(); //GUID Global Uniquie Identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\Michael\Logs\log.txt", true))  // this is the using System.IO method the system allows to log with. It will by using this Streamwriter code clean up after it
                                                                                                      // logs and release the memory used to log this, "true" parameter appends existing instead of creating a new file everytime.
                {
                    file.WriteLine(player.Id); //logs player ID //GUID Global Uniquie Identifier  always UNIQUE! `
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {   
                    try
                    {
                        game.Play();  ////// breaks if hit enter and not enter a bet instead
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your System Administrator");
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            Console.ReadLine();
        }
    }
}







////// --------------THESE were all the notes prior to creating the actual game-------------------------------------------------------


/////{

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



// //Reference Type Example:


// Card card1 = new Card();
// card1.Face = Face.Eight;
// Console.WriteLine(card1.Face); // returns King
// Card card2 = card1;
// Console.WriteLine(card2.Face); // returns King
// card2.Face = Face.King;

// Console.WriteLine(card1.Face); // returns King
// Console.WriteLine(card2.Face); // returns King

// int x = 1;
// int y = x;
// y = 2; // x is 1, y is 2

// string helloWorld = "hello";
// helloWorld = "not hello";

//// pass by VALUE TYPE will copy another value
//// pass by reference will reference another existing object
///




//Deck deck = new Deck();


//Example Lambda functions


//int count = deck.Cards.Count(x => x.Face == Face.Ace); // iterating through using LAMBDA FUNCTIONS =>
//Console.WriteLine(count);

//Another Example Lambda function

//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);

//}


//Another Example Lambda function  -- FAst way to sum numbers in a list

//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Sum(); // sum the numbers = 906

//Console.WriteLine(sum);


//Another Example Lambda function  -- FAst way to sum numbers in a list + Add an iterationand find sum plus max plus min  plus plus plus
//it makes a way to do things that would otherwise require loops and a lot of code reduced down to one line in many instances...
//and Lambda expressions are FASTER than for loops 

// List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Sum(x => x + 5); // sum the numbers +  add five to each of them or + 30 = 936
//int sum = numberList.Max();  // or get the Max item in the list ... 535
//int sum = numberList.Min();  // or get the Min item in the list ... 1
//int sum = numberList.Where(x => x > 20).Sum();  // Where creates a new list , in teis case we are calling items x that are greater than 20 and then we will "sum" that list.
// In this case it will be the items that are greater than 20 being added together in the sum of ... 900 or (535, 342, 23)

// OK WITH THT SAID, A FEW WORDS OF CAUTION REGARDING LAMBDA's
//they are hard to debug......can't step through them in debugging 
// so if  you have an error you are on your own. Also don't make them too long, they become difficult to read the logic in them and debug for others as well as yourself.


//Console.WriteLine(sum); // sum the numbers





// created a new Object of data type called Deck. Weve instantiated an object called Deck and called it variable "deck", it's now empty
//deck.Shuffle(3);

//foreach (Card card in deck.Cards) // to see list
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);  // to see list
//}
//Console.WriteLine("Cards in deck: " + deck.Cards.Count);

// Console.ReadLine(); // keeps screen window open



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
        //}
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
    //}
