using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // Need to inherit from multiple classes? Can't do it in C#. Only one allowed per class.
    // But you can have multiple "Interfaces" so lets see how that works.
    interface IWalkAway     
    {
        void WalkAway(Player player);  // all interfaces are public so don;t need to say it/
                                       // like abstract classes, interfaces also demand that you inherit from them
    }
}
