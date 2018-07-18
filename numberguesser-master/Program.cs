using System;


namespace NumberGuesser
{

    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            while (true)
            {
                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                      continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and display app info
        static void GetAppInfo() {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Aditi Supekar";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser() {

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
