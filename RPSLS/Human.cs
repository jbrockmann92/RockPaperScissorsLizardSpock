using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public string humanGesture;

        public Human()
        {

        }

        public override void GetName()
        {
            Console.WriteLine("What would you like this character's name to be?");
            name = Console.ReadLine();
            if (name.Length > 10)
            {
                Console.WriteLine("Please enter a name shorter than 11 characters");
                GetName();
            }
        }

        public override string ChooseGesture()
        {
            Console.WriteLine($"Please enter {gestures[0]}, {gestures[1]}, {gestures[2]}, {gestures[3]}, or {gestures[4]}");
            string gestureChoice = Console.ReadLine().ToLower();
            switch (gestureChoice)
            {
                case "rock":
                    humanGesture = gestureChoice;
                    break;
                case "paper":
                    humanGesture = gestureChoice;
                    break;
                case "scissors":
                    humanGesture = gestureChoice;
                    break;
                case "lizard":
                    humanGesture = gestureChoice;
                    break;
                case "spock":
                    humanGesture = gestureChoice;
                    break;
                default:
                    Console.WriteLine("Please enter one of the options above");
                    break;
            }
            return humanGesture;
        }
    }
}
