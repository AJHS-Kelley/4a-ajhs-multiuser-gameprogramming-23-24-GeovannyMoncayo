// Geovanny Moncayo, Number Guess, v0.4
/*
Generate secret number from a defined range of numbers. (i.e. 0-10, 0-50, 0-100)
Print game instructions including range and num. of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts.
Ask the player what difficulty they want to play on.
Ask the player what their guess is.
Determine if guess is correct or not.
    If guess is correct {
        Tell them they have guessed correctly.
        Award the player a point.
    } else {
        Tell them they are wrong.
        Tell player if guess is too high or too low
        Check to see if they have guesses remaining {
            if guess remain: {
                allow player to guess again.
            } else {
                CPU wins the round.
            }
        }
    }

*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int playerGuess = -1;
            int numGuesses = 0; // Number of guesses player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN.
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guess Game!\nYou will select a difficulty next.\n");
            Console.WriteLine("Easy Mode: Range is 0 - 10 with 4 guesses.\nNormal Mode: Range is 0 - 25 with 4 guesses.\nHard Mode: Range is from 0 - 50 with 3 guesses.");
            
            // Difficulty Selection
            Console.WriteLine("Please type Easy, Normal, or Hard and press ENTER.\n");
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to STRING by default.

            
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 10;
                numGuesses = 4;
            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuesses = 3;
            } else {
                rangeMin = 0;
                rangeMax = 25;
                numGuesses = 4;
                difficulty = "Normal";
            }
            Console.WriteLine("You have selected " + difficulty );
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // START THE MATCH!
            while (playerScore != 3 && cpuScore != 3) {
                // Any code you want to run BEFORE each round goes here.
                // GENERATE SECRET NUMBER
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine(secretNumber); // REMOVE AFTER YOU TEST THE CODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
                Console.WriteLine("Choose a number from " + rangeMin + " to " + rangeMax);
                Console.WriteLine("Player Score: " + playerScore + "\n");
                Console.WriteLine("CPU Score " + cpuScore + "\n");
                // START EACH ROUND
                for (int i = 0; i < numGuesses; i++) {
                    // Code to guess number goes here.
                    
                    Console.WriteLine("You have used " + numAttempts + " this round.\n");
                    Console.WriteLine("You must guess between " + rangeMin + " and " + rangeMax);
                    playerGuess = System.Convert.ToInt32(Console.ReadLine());
                    if (playerGuess == secretNumber) {
                        Console.WriteLine("You are absolutely right!");
                        playerScore++;
                        break;
                    } else if (secretNumber == -1) {
                        Console.WriteLine("Error in code.");
                    } else {
                        if (playerGuess > secretNumber) {
                            Console.WriteLine("You are wronggggg! Try guessing a lower.");

                        } else if (playerGuess < secretNumber) {
                            Console.WriteLine("You are wronggggg! Try guessing a higher.");

                        }
                    }
                    numAttempts++;
                }
                if (playerGuess != secretNumber) {
                    cpuScore ++;
                    // Print a round lost message to console.
                    Console.WriteLine("You have lost this round");
                }
                numAttempts = 0;
            }
            if (playerScore >= 3) {
                Console.WriteLine("You have won the game!\n");
            } else {
                Console.WriteLine("You have lost the game!\n");
            }

        }
    }
}