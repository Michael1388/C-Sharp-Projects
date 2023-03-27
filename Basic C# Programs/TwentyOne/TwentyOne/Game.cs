using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game // added abstract as an exapmle of what you never want to be instantiated bc an abstract cant be 
    {
        //Inheritance - ability of a class to inherit methods and properties from another class - DRY
        public List<string> Players { get; set; } //(prop tab tab)
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); // abstract method Must Be Used in all that inherit from it / Game 

        public virtual void ListPlayers() // virtual method , gets inherited by an inheriting class but has the aability to override it...can be overriedden.
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}