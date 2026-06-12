namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] settings = SelectDifficulty();

            int range = settings[0];
            int attemptsLimit = settings[1];

            PlayGame(range, attemptsLimit);
        }  
    
        static int[] SelectDifficulty()
        {
            Console.WriteLine("Select a difficulty:");
            Console.WriteLine("1 - Easy   (0-100, 10 attempts)");
            Console.WriteLine("2 - Medium (0-150, 5 attempts)");
            Console.WriteLine("3 - Hard   (0-200, 3 attempts)");

            Console.Write("Inform a level: ");
            int gameLevel = Convert.ToInt32(Console.ReadLine());

            if (gameLevel == 1)
            {
                return new int[] {100, 10};
            } else if (gameLevel == 2)
            {
                return new int[] {150, 5};
            } else
            {
                return new int[] {200, 3};
            }
        }
    
        static void PlayGame(int range, int attemptsLimit)
        {
            Random rand = new Random();
            int number = rand.Next(range + 1);

            Console.WriteLine(number); // testing

            int attempts = 0;
            bool keepPlaying = true;

            while (keepPlaying && attempts < attemptsLimit)
            {
                Console.Write("\nInform a number: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (userGuess == number)
                {
                    Console.WriteLine($"\nYou win! The number was {number}");
                    Console.WriteLine($"You guessed the correct number in {attempts} attempts.");
                    keepPlaying = false;
                }
                else if (userGuess > number)
                {
                    Console.WriteLine("\nToo high.");
                    Console.WriteLine($"You have {attemptsLimit - attempts} attempts remaining...");
                }
                else
                {
                    Console.WriteLine("\nToo low.");
                    Console.WriteLine($"You have {attemptsLimit - attempts} attempts remaining...");
                }
            }
            if (attempts == attemptsLimit && keepPlaying)
            {
                Console.WriteLine($"\nYou reached the limit of attempts.");
                Console.WriteLine($"The number was {number}");
            }
        }
    }
}