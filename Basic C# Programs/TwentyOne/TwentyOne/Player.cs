using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet (int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                    return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }

        }
        
        public static Game operator +(Game game, Player player) // overloading operator+
        {
            game.Players.Add(player); //add
            return game;

        }
        public static Game operator- (Game game, Player player) // overloading operator-
        {
            game.Players.Remove(player); //remove
            return game;
        }

        public Player(string name, int beginningBalance)
        {
            Balance = beginningBalance;
            Name = name;
        }







    }

}
