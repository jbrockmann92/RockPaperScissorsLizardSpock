using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //Need to figure out Human or Computer here, because Game will just have firstPlayer and secondPlayer. secondPlayer will be either human or computer
        //ints or strings? Bool?

        public int oneOrTwoPlayer;

        public Player()
        {

        }

        public void HumanOrComputer()
        {
            Console.WriteLine("Would you like to play a one player or two player game? Press 1 for one player and 2 for two");
            oneOrTwoPlayer = int.Parse(Console.ReadLine());
        }
       

    }
}
