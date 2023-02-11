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


                                    if (fourthAnswer == "A")
                                    {
                                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 4th Round");
                                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");

                                        // RUNNING ME 5TH RIDDLE
                                        // taking user's answer again
                                        string fifthContinueGame = Console.ReadLine();
                                        fifthContinueGame = fifthContinueGame.ToUpper();


                                        if (fifthContinueGame == "Y")
                                        {
                                            Console.WriteLine("Here is your Fifth Riddle");

                                            Console.WriteLine("If you drop me I am sure to give a crack, but if you give me a smile and I'll always smile back.  What am I?");

                                            Console.WriteLine("A. A Plastic");
                                            Console.WriteLine("B. A Mirror");
                                            Console.WriteLine("C. Goose");
                                            Console.WriteLine("D. A Key");

                                            Console.WriteLine("Times Defeated Sphinx = 4");

                                            string fifthAnswer = Console.ReadLine();
                                            fifthAnswer = fifthAnswer.ToUpper();

                                            if (fifthAnswer == "B")
                                            {
                                                Console.WriteLine("Yay!..... You defeated the Sphinx in the 5th Round");
                                                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");


                                                // RUNNING ME 6TH RIDDLE
                                                // taking user's answer again
                                                string sixthContinueGame = Console.ReadLine();
                                                sixthContinueGame = sixthContinueGame.ToUpper();


                                                if (sixthContinueGame == "Y")
                                                {
                                                    Console.WriteLine("Here is your Sixth Riddle");

                                                    Console.WriteLine("People make me, save me, change me, raise me.  What am I?");

                                                    Console.WriteLine("A. Monkey");
                                                    Console.WriteLine("B. Dog");
                                                    Console.WriteLine("C. Cow");
                                                    Console.WriteLine("D. Child");

                                                    Console.WriteLine("Times Defeated Sphinx = 5");

                                                    string sixthAnswer = Console.ReadLine();
                                                    sixthAnswer = sixthAnswer.ToUpper();


                                                    if (sixthAnswer == "A")
                                                    {
                                                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 6th Round");
                                                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");



                                                        string seventhContinueGame = Console.ReadLine();
                                                        seventhContinueGame = seventhContinueGame.ToUpper();
                                                        if (seventhContinueGame == "Y")
                                                        {
                                                            Console.WriteLine("Here is your Seventh Riddle");

                                                            Console.WriteLine("I have lakes with no water, mountains with no stone and cities with no buildings.  What am I?");

                                                            Console.WriteLine("A. A map");
                                                            Console.WriteLine("B. A Townhall");
                                                            Console.WriteLine("C. A Church");
                                                            Console.WriteLine("D. THe Eiffel Tower");

                                                            Console.WriteLine("Times Defeated Sphinx = 6");

                                                            string seventhAnswer = Console.ReadLine();
                                                            seventhAnswer = seventhAnswer.ToUpper();

                                                            if (seventhAnswer == "A")
                                                            {
                                                                Console.WriteLine("Yay!..... You defeated the Sphinx in the 7th Round");
                                                                Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");



                                                                string eightContinueGame = Console.ReadLine();
                                                                eightContinueGame = seventhContinueGame.ToUpper();

                                                                if (eightContinueGame == "Y")
                                                                {

                                                                    Console.WriteLine("Here is your Eight Riddle");

                                                                    Console.WriteLine("THe person who uses it can neither feel it nor see it.  What is it?");

                                                                    Console.WriteLine("A. A Parachute");
                                                                    Console.WriteLine("B. A Coffin");
                                                                    Console.WriteLine("C. The Internet");
                                                                    Console.WriteLine("D. An iPhone");

                                                                    Console.WriteLine("Times Defeated Sphinx = 7");

                                                                    // CHECKING IF user's eight answer ANSWER IS CORRECT
                                                                    string eightAnswer = Console.ReadLine();
                                                                    eightAnswer = eightAnswer.ToUpper();

                                                                    if (eightAnswer == "B")
                                                                    {
                                                                        Console.WriteLine("Yay!..... You defeated the Sphinx in the 8th Round");
                                                                        Console.WriteLine("Would you like to keep defeating Sphinx?, Enter [Y to continue game and N to End Game]");

                                                                        // DETERMINING if user would like to continue game

                                                                        string ninthContinueGame = Console.ReadLine();
                                                                        ninthContinueGame = ninthContinueGame.ToUpper();

                                                                        if (ninthContinueGame == "Y")
                                                                        {
                                                                            Console.WriteLine("Here is your Ninth Riddle");

                                                                            Console.WriteLine("What building has the most stories?");

                                                                            Console.WriteLine("A. The Library");
                                                                            Console.WriteLine("B. The Townhall");
                                                                            Console.WriteLine("C. An Ark");
                                                                            Console.WriteLine("D. A Cave");

                                                                            Console.WriteLine("Times Defeated Sphinx = 8");

                                                                            // DETERMINING IF user's ninth answer is correct
                                                                            string ninthAnswer = Console.ReadLine();
                                                                            ninthAnswer = ninthAnswer.ToUpper();

                                                                            if (ninthAnswer == "A")
                                                                            {
                                                                                Console.WriteLine("Yay!..... You defeated the Sphinx in the 9th Round");
                                                                                Console.WriteLine("Would you like to advance to the last round(the 10th round)?");

                                                                                // DETERMINING if user would like to continue game

                                                                                string tenthContinueGame = Console.ReadLine();
                                                                                tenthContinueGame = tenthContinueGame.ToUpper();

                                                                                if (tenthContinueGame == "Y")
                                                                                {
                                                                                    Console.WriteLine("Here is your FInal ROund, ensure you get the riddle :) ");

                                                                                    Console.WriteLine("I am always hungry and will die if not fed, but whatever I touch will soon turn red. What am I?");

                                                                                    Console.WriteLine("A. Harmattan");
                                                                                    Console.WriteLine("B. Breeze");
                                                                                    Console.WriteLine("C. Storm");
                                                                                    Console.WriteLine("D. Fire");

                                                                                    Console.WriteLine("Times Defeated Sphinx = 8");

                                                                                    // DETERMINING IF user's ninth answer is correct
                                                                                    string tenthAnswer = Console.ReadLine();
                                                                                    tenthAnswer = tenthAnswer.ToUpper();



                                                                                }


                                                                            }
                                                                        }


                                                                    }
                                                                    else if (seventhContinueGame == "N")
                                                                    {
                                                                        Console.WriteLine("Goodbye My Dear User :)");
                                                                    }
                                                                }

                                                            }
                                                            else if (seventhContinueGame == "N")
                                                            {
                                                                Console.WriteLine("Goodbye My Dear User :)");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                                                            Console.WriteLine("You failed this round, would you like to try again?");
                                                            Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                                                            string fifthStartAgain = Console.ReadLine();
                                                            fifthStartAgain = fifthStartAgain.ToUpper();

                                                            if (fifthStartAgain == "Y")
                                                            {
                                                                // running the Main() method entrypoint to play game again
                                                                Main();
                                                            }
                                                            else if (fifthStartAgain == "N")
                                                            {
                                                                Console.WriteLine("Goodbye My Dear User :)");
                                                            }
                                                        }


                                                    }


                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine("Ouch! Sphinx has just eaten up your avatar");
                                                Console.WriteLine("You failed this round, would you like to try again?");
                                                Console.WriteLine("Enter [Y to start Game Again and N to End Game]");

                                                string fifthStartAgain = Console.ReadLine();
                                                fifthStartAgain = fifthStartAgain.ToUpper();

                                                if (fifthStartAgain == "Y")
                                                {
                                                    // running the Main() method entrypoint to play game again
                                                    Main();
                                                }
                                                else if (fifthStartAgain == "N")
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

                                            string fourthStartAgain = Console.ReadLine();
                                            fourthStartAgain = fourthStartAgain.ToUpper();

                                            if (fourthStartAgain == "Y")
                                            {
                                                // running the Main() method entrypoint to play game again
                                                Main();
                                            }
                                            else if (fourthStartAgain == "N")
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
    }
