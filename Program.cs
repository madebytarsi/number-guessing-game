namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            int attempts = 0;
            int attemptsLimit = 5;
            int range = 0;

            Console.WriteLine("Inform the level you want to play: ");
            Console.WriteLine("1 - Easy (10 attempts)");
            Console.WriteLine("2 - Medium (5 attempts)");
            Console.WriteLine("3 - Hard  (3 attempts)");
            
            Console.Write("Inform a level: ");
            int gameLevel = Convert.ToInt16(Console.ReadLine());

            if (gameLevel == 1)
            {
                range = 100;
                attemptsLimit = 10;
            } else if (gameLevel == 2)
            {
                range = 150;
                attemptsLimit = 5;
            } else
            {
                range = 200;
                attemptsLimit = 3;
            }

            // generates the random number
            Random rand = new Random();
            int number = rand.Next(range + 1);

            Console.WriteLine(number);  // for testing

            int remainingAttempts = attemptsLimit;

            while (keepPlaying && remainingAttempts != 0)
            {
                remainingAttempts = attemptsLimit - attempts;

                Console.Write("\nInform a number: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                attempts++;

                if (userGuess == number)
                {
                    Console.WriteLine($"\nYou win! The number was {number}");
                    Console.WriteLine($"You guessed the correct number in {attempts} attempts.");
                    keepPlaying = false;
                } else if (userGuess > number)
                {
                    Console.WriteLine("\nToo high.");
                    Console.WriteLine($"You have {remainingAttempts} attemps remaining...");
                } else if (userGuess < number)
                {
                    Console.WriteLine("\nToo low.");
                    Console.WriteLine($"You have {remainingAttempts} attemps remaining...");
                }
            }

            if (remainingAttempts == 0)
            {
                Console.WriteLine($"\nYou reached the limit of attempts to guess the number.\nThe number was {number}");
            }
        }  
    }
}