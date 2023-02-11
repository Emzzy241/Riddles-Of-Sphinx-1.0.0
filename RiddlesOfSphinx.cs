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

        playGame = playGame.ToUpper();

        if (playGame == "Y")
        {
            // now I know my user wants to Play Game

            // RUNNING ME 4TH RIDDLE

            Console.WriteLine("Here is your First Riddle");


            Console.WriteLine("What Has to be broken before you can use it?");
            Console.WriteLine("A. Beans");
            Console.WriteLine("B. Egg");
            Console.WriteLine("C. Yam");
            Console.WriteLine("D. Plastics");


            string userAnswer = Console.ReadLine();
            // converting users answer into upper case; the standards of My Application
            userAnswer = userAnswer.ToUpper();

            if (userAnswer == "B")
            {
                Console.WriteLine("Yay!..... You defeated the Sphinx in the first Round");
                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue Game Again and N to End Game]");


                // taking user's answer again
                // RUNNING ME 2ND RIDDLE

                string continueGame = Console.ReadLine();
                continueGame = continueGame.ToUpper();

                if (continueGame == "Y")
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

                    userSecondAnswer = userSecondAnswer.ToUpper();

                    if (userSecondAnswer == "A")
                    {
                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 2nd Round");
                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");


                        // taking user's answer again
                        // RUNNING ME 3RD RIDDLE

                        string secondContinueGame = Console.ReadLine();
                        secondContinueGame = secondContinueGame.ToUpper();

                        if (secondContinueGame == "Y")
                        {
                            Console.WriteLine("Here is your Third Riddle");

                            Console.WriteLine("What five-letter word becomes shorter when you add two letters to it?");

                            Console.WriteLine("A. Tesla");
                            Console.WriteLine("B. Tired");
                            Console.WriteLine("C. Drink");
                            Console.WriteLine("D. Short");

                            Console.WriteLine("Times Defeated Sphinx = 2");

                            string thirdAnswer = Console.ReadLine();
                            thirdAnswer = thirdAnswer.ToUpper();

                            if (thirdAnswer == "D")
                            {
                                Console.WriteLine("Yay!..... You defeated the Sphinx in the 3rd Round");
                                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");

                                // RUNNING ME 4TH RIDDLE
                                // taking user's answer again
                                string thirdContinueGame = Console.ReadLine();
                                thirdContinueGame = thirdContinueGame.ToUpper();

                                if (thirdContinueGame == "Y")
                                {
                                    Console.WriteLine("Here is your Fourth Riddle");

                                    Console.WriteLine("A word I know, six letters it contains, remove one letter and 12 remains.  What is it?");

                                    Console.WriteLine("A. Dozens");
                                    Console.WriteLine("B. Threes");
                                    Console.WriteLine("C. Farmer");
                                    Console.WriteLine("D. Harper");

                                    Console.WriteLine("Times Defeated Sphinx = 3");

                                    string fourthAnswer = Console.ReadLine();
                                    fourthAnswer = fourthAnswer.ToUpper();


                                    if (thirdAnswer == "A")
                                    {
                                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 3rd Round");
                                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");

                                        // RUNNING ME 4TH RIDDLE
                                        // taking user's answer again
                                        string fourthContinueGame = Console.ReadLine();
                                        fourthContinueGame = fourthContinueGame.ToUpper();
                                    }



                                }

                                else
                                {
                                    Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                                    Console.WriteLine("You failed this round, would you like to try again?");
                                    Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                                    string startAgain = Console.ReadLine();
                                    startAgain = startAgain.ToUpper();

                                    if (startAgain == "Y")
                                    {
                                        // running the Main() method entrypoint to play game again
                                        Main();
                                    }
                                    else if (startAgain == "N")
                                    {
                                        Console.WriteLine("Goodbye My Dear User :)");
                                    }
                                }





                            }





                        }
                        else
                        {
                            Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                            Console.WriteLine("You failed this round, would you like to try again?");
                            Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                            string thirdStartAgain = Console.ReadLine();
                            thirdStartAgain = thirdStartAgain.ToUpper();

                            if (thirdStartAgain == "Y")
                            {
                                // running the Main() method entrypoint to play game again
                                Main();
                            }
                            else if (thirdStartAgain == "N")
                            {
                                Console.WriteLine("Goodbye My Dear User :)");
                            }
                        }


                    }
                    else
                    {
                        Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                        Console.WriteLine("You failed this round, would you like to try again?");
                        Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                        string secondStartAgain = Console.ReadLine();
                        secondStartAgain = secondStartAgain.ToUpper();

                        if (secondStartAgain == "Y")
                        {
                            // running the Main() method entrypoint to play game again
                            Main();
                        }
                        else if (secondStartAgain == "N")
                        {
                            Console.WriteLine("Goodbye My Dear User :)");
                        }
                    }






                }
                else
                {
                    Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                    Console.WriteLine("You failed this round, would you like to try again?");
                    Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                    string startAgain = Console.ReadLine();
                    startAgain = startAgain.ToUpper();

                    if (startAgain == "Y")
                    {
                        // running the Main() method entrypoint to play game again
                        Main();
                    }
                    else if (startAgain == "N")
                    {
                        Console.WriteLine("Goodbye My Dear User :)");
                    }
                }


            }

        }
    }
}