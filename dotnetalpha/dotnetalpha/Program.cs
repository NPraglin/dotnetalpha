using System;

// Namespace holds classes
namespace NumberGuesser
{
    // Main class which holds methods/functions
    class Program
    {
        // Function for math
        public void guesser(int[] args)
        {

        }
        // Entry point method/function
        static void Main(string[] args) //void is return type, static allows instantiate objects and creating instances
        {
            // Get App Info
            GetAppInfo();

            // Greet user
            // Ask user's name
            Console.WriteLine("What is your name?");

            // String input
            string? input;
            input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", input);

            while (true)
            {

                // Set correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // Set Guesses
                int guessCount = 5;

                // Init Guess Var
                int guessVar = 0;
                string guessLine = Console.ReadLine();

                // Ask for a guess
                Console.WriteLine("{0}, I am thinking of a number, you have {1} guesses", input, guessCount);

                // While loop for guess
                while (guessVar != correctNumber)
                {
                    // Player input
                    string? inputGuess = Console.ReadLine();

                    // Ensure it is int
                    if (!int.TryParse(inputGuess, out guessVar))
                    {
                        // Call our printer function
                        PrintColorMessage(ConsoleColor.Red, "That is not a number, please try again");
                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guessVar = Int32.Parse(inputGuess);

                    // Match guess to correct number
                    if (guessVar != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                // Output SuccessMessage
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT! You guessed the color.");

                // Ask to play again?
                Console.WriteLine("Play Again? [Y or N]");

                // Get Answer
                string? answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo()
        {
            // Set App vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Nathan Praglin";

            // Chanbge text color
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0} version {1} written by {2}", appName, appVersion, appAuthor);

            // Reset console text color
            Console.ResetColor();
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}