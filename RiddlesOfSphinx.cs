using System;
using System.Collections.Generic;

class RiddlesOfSphinx
{

    static void Main()
    {
        // after the Main() entry point for my application, Let's write some code

        // First Aim, asking user's a riddle

        Console.WriteLine("Welcome to Ultron's Riddles of Sphinx");
        Console.WriteLine("Enter [Y to COntinue to first question, Enter N to Quit Game]");

        string playGame = Console.ReadLine();

        // working on case sensitivity

        playGame = playGame.ToLower();

        if (playGame == "y")
        {
            // now I know my user wants to Play Game

            Console.WriteLine("Here is your First Riddle");


            Console.WriteLine("What Has to be broken before you can use it?");
            Console.WriteLine("A. Beans");
            Console.WriteLine("B. Egg");
            Console.WriteLine("C. Yam");
            Console.WriteLine("D. Plastics");

            // Console.WriteLine("What Has to be broken before you can use it?");
            // Console.WriteLine("A. Beans");
            // Console.WriteLine("B. Egg");
            // Console.WriteLine("C. Yam");
            // Console.WriteLine("D. Plastics");

            string userAnswer = Console.ReadLine();

            string upperUserAnswer = userAnswer.ToUpper();

            if (upperUserAnswer == "B")
            {
                Console.WriteLine("Yay!..... You defeated the Sphinx in the first Round");
                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to start Game Again and N to End Game]");


                // taking user's answer again
                string continueGame = Console.ReadLine();
                string upperContinueGame = continueGame.ToUpper();

                if (upperContinueGame == "Y")
                {
                    // running the Main() method entrypoint to play game again
                    Main();
                }
                else if (upperContinueGame == "N")
                {
                    Console.WriteLine("Goodbye My Dear User :)");
                }

                // no need to write the else again, because opposite of an if statement is an else statement





            }
            else
            {
                Console.WriteLine("Ouch! Sphinx has just eaten up your character");
                Console.WriteLine("You failed this round, would you like to try again?");
                Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                string startAgain = Console.ReadLine();
                string upperStartAgain = startAgain.ToUpper();

                if (upperStartAgain == "Y")
                {
                    // running the Main() method entrypoint to play game again
                    Main();
                }
                else if (upperStartAgain == "N")
                {
                    Console.WriteLine("Goodbye My Dear User :)");
                }
            }


        }

    }
}