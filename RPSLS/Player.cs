using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Need to figure out Human or Computer here, because Game will just have firstPlayer and secondPlayer. secondPlayer will be either human or computer
        //ints or strings? Bool?

        public List<string> gestures = new List<string>() {"rock","paper", "scissors", "lizard", "spock"};

        public Player()
        {

        }

        public abstract string ChooseGesture();
    }
}
