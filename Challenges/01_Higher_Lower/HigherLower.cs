using System;
using System.Threading;

namespace HigherLowerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNotCorrectInput = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("<----------Higher/Lower Game---------->");

            while (isNotCorrectInput)
            {
                Console.WriteLine("Please press 's' to start the game (press Enter to exit)");

                // Set a timeout of 10 seconds for user input
                if (Console.KeyAvailable || Console.ReadLine() == "s")
                {
                    StartGame();
                    isNotCorrectInput = false; // Set to false to exit the loop after starting the game
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Press 's' only.");
                }
            }
        }

        static void StartGame()
        {
            int maxNumber = GetDifficultyLevel();
            Random rand = new Random();
            int randomNumber = rand.Next(1, maxNumber + 1);
            int number = 0;
            int attempt = 0;
            Console.WriteLine("\nGame Start!");

            do
            {
                Console.Write("Enter a valid number: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Not a valid number.");
                    continue;
                }

                attempt++;

                if (number == randomNumber)
                {
                    Console.WriteLine($"Hurray! You won :) Attempts: {attempt}");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (number < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (number != randomNumber);

            PlayAgain();
        }

        static void PlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string decision = Console.ReadLine().ToLower();

            if (decision == "y")
            {
                StartGame();
            }
            else if (decision == "n")
            {
                Console.WriteLine("Thanks for playing. :)");
            }
            else
            {
                Console.WriteLine("Wrong option");
                PlayAgain();
            }
        }

        static int GetDifficultyLevel()
        {
            Console.WriteLine("\n1. Easy (1-10)\n2. Medium (1-100)\n3. Hard (1-1000)\nPick difficulty level: ");
            int maxNumber;
            string difficulty = Console.ReadLine();

            switch (difficulty)
            {
                case "1":
                    maxNumber = 10;
                    break;
                case "2":
                    maxNumber = 100;
                    break;
                case "3":
                    maxNumber = 1000;
                    break;
                default:
                    Console.WriteLine("Wrong option.");
                    maxNumber = GetDifficultyLevel();
                    break;
            }

            return maxNumber;
        }
    }
}
