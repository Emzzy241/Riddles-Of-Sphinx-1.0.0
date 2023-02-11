using System;
using System.Collections.Generic;

class RiddlesOfSphinx{

    static void Main(){
        // after the Main() entry point for my application, Let's write some code

        // First Aim, asking user's a riddle

        Console.WriteLine("Welcome to Ultron's Riddles of Sphinx");
        Console.WriteLine("Enter [Y to COntinue to first question, Enter N to Quit Game]");

        string playGame = Console.ReadLine();

        // working on case sensitivity

        playGame = playGame.ToLower();

        if(playGame == "y"){}

    }
}