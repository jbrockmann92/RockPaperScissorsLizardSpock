using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Need to figure out how to automate the same processes that the human player will do in the human class. Both inherit from Player class
        //Randomize the three options. Have something like playerGesture and that's what will be automated in this class, while Human gets to choose
        //Human and computer will inherit from the Player class
        int computerRandInt;
        public string computerGesture;

        public Computer()
        {

        }

        public override string ChooseGesture()
        {
            Random randint = new Random();
            computerRandInt = randint.Next(0, 5);
            computerGesture = gestures[computerRandInt];
            return computerGesture;
        }

        public override void GetName()
        {
            name = "Computer";
        }
    }
}
