using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        //I think I'll just do 5 variables here that can be assigned values later. May want to have 5 classes, one for each choice, but I don't think I'll need that
        int rock;
        int paper;
        int scissors;
        int lizard;
        int spock;

        //Maybe in this class add a print statement, foreach loop that iterates over each option, and says, $"{rock} for for Rock, etc."

        public Gesture(int rock, int paper, int scissors, int lizard, int spock)
        {
            this.rock = rock;
            this.paper = paper;
            this.scissors = scissors;
            this.lizard = lizard;
            this.spock = spock;
        }

        public void PrintGestures()
        {
            Console.WriteLine($"{rock} for Rock, {paper} for Paper, {scissors} for Scissors, {lizard} for Lizard, {spock} for Spock");
        }
        
    }
}
