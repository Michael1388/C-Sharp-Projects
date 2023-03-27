using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game
    {
        //Inheritance - ability of a class to inherit methods and properties from another class - DRY
        public List<string> Players { get; set; } //(prop tab tab)
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}