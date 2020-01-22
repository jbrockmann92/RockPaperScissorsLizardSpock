using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        public List<string> gestures = new List<string>() {"rock","paper", "scissors", "lizard", "spock"};
        public string name;

        public Player()
        {

        }

        public abstract string ChooseGesture(string gestureChoice);

        public abstract void GetName();
    }
}
