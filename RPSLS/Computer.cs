using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
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
