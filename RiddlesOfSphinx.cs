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
                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue Game Again and N to End Game]");


                // taking user's answer again
                string continueGame = Console.ReadLine();
                string upperContinueGame = continueGame.ToUpper();

                if (upperContinueGame == "Y")
                {

                    Console.WriteLine("Here is your Second Riddle");


                    Console.WriteLine("I am tall when I'm young, and I'm short when I'm old, what am I?");
                    Console.WriteLine("A. Candle");
                    Console.WriteLine("B. Dog");
                    Console.WriteLine("C. Stick");
                    Console.WriteLine("D. Broom");


                    Console.WriteLine("Times Defeated Sphinx = 1");

                    // determining the answer of 2nd Riddle

                    string userSecondAnswer = Console.ReadLine();
                    string upperSecondAnswer = userSecondAnswer.ToUpper();

                    if (upperSecondAnswer == "A")
                    {
                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 2nd Round");
                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");


                        // taking user's answer again
                        string secondContinueGame = Console.ReadLine();
                        string upperSecondContinueGame = continueGame.ToUpper();

                        if (upperSecondContinueGame == "Y")
                        {
                            Console.WriteLine("Here is your THird Riddle");


                            Console.WriteLine("What Fi?");
                            Console.WriteLine("A. Candle");
                            Console.WriteLine("B. Dog");
                            Console.WriteLine("C. Stick");
                            Console.WriteLine("D. Broom");

                        }



                    }
                    else if (upperSecondAnswer == "N")
                    {
                        Console.WriteLine("Goodbye My Dear User :)");
                    }


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