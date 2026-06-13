namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var settings = SelectDifficulty();
            PlayGame(settings.range, settings.attemptsLimit);
        }

        static (int range, int attemptsLimit) SelectDifficulty()
        {
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("1 - Easy   (0-100, 10 attempts)");
            Console.WriteLine("2 - Medium (0-150, 5 attempts)");
            Console.WriteLine("3 - Hard   (0-200, 3 attempts)");

            Console.Write("\nSelect a difficulty (1-3): ");

            int gameLevel;

            while (!int.TryParse(Console.ReadLine(), out gameLevel) ||
                   gameLevel < 1 || gameLevel > 3)
            {
                Console.Write("Please enter 1, 2, or 3: ");
            }

            if (gameLevel == 1)
            {
                return (100, 10);
            }
            else if (gameLevel == 2)
            {
                return (150, 5);
            }
            else
            {
                return (200, 3);
            }
        }

        static void PlayGame(int range, int attemptsLimit)
        {
            Random rand = new Random();
            int number = rand.Next(range + 1);

            int attempts = 0;
            int userGuess;

            Console.WriteLine($"\nGuess a number between 0 and {range}.");
            Console.WriteLine($"You have {attemptsLimit} attempts.");

            while (attempts < attemptsLimit)
            {
                Console.Write("\nGuess a number: ");

                while (!int.TryParse(Console.ReadLine(), out userGuess))
                {
                    Console.Write("Invalid value. Please enter a valid number: ");
                }

                attempts++;

                if (userGuess == number)
                {
                    Console.WriteLine($"\nYou win! The number was {number}");
                    Console.WriteLine($"You guessed the correct number in {attempts} attempts.");
                    return;
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("\nToo high.");
                }
                else
                {
                    Console.WriteLine("\nToo low.");
                }

                Console.WriteLine($"You have {attemptsLimit - attempts} attempts remaining...");
            }

            Console.WriteLine("\nYou reached the limit of attempts.");
            Console.WriteLine($"The number was {number}");
        }
    }
}