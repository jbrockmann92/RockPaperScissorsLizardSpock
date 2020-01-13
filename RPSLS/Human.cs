using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //Simple enough here. Allow the player to choose. One player will be guaranteed to be Human, and the other will be optional. 
        //Both do the same thing, but the Computer will randomize the same actions that the Human player will get to choose from.
        //I'll want a list of the 5 options in this class that will be assigned values ultimately in the Game class
        //Human and computer will inherit from the Player class

        public List<Gesture> gestures = null;

        public Human()
        {

        }

        //public void ChooseGesture()
        //{
        //    Console.WriteLine("Would you like to do 0) Rock, 1) Paper, 2) Scissors, 3) Lizard, or 4) Spock? Make your entry now");
        //    whichGesture = int.Parse(Console.ReadLine());
        //    //gesture.PlayerChoice(); -- I want this input so I can, in the Game class, assign the values to each of the variables in Gesture()
        //}

        public void GestureChoice()
        {
            Console.WriteLine("Which Gesture would you like to do?");
            foreach (Gesture gesture in gestures)
            {

            }
        }



    }
}
