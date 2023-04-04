using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game // added abstract as an exapmle of what you never want to be instantiated bc an abstract cant be 
    {
        //Inheritance - ability of a class to inherit methods and properties from another class - DRY
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players;  } set { _players = value; } } //(prop tab tab)
        
        
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; }  set { _bets = value; } }

        public abstract void Play(); // abstract method Must Be Used in all that inherit from it / Game 

        public virtual void ListPlayers() // virtual method , gets inherited by an inheriting class but has the aability to override it...can be overriedden.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}