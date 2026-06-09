namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            int attempts = 0;
            int attemptsLimit = 5;
            // int level = 0;

            // generates the random number
            Random rand = new Random();
            int number = rand.Next(101);

            Console.WriteLine(number);  // for testing

            while (keepPlaying && attempts < attemptsLimit)
            {
                Console.Write("\nInform a number: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == number)
                {
                    Console.WriteLine($"\nYou win! The number was {number}");
                    Console.WriteLine($"You guessed the correct number in {attempts} attempts.");
                    keepPlaying = false;
                } else if (userGuess > number)
                {
                    Console.WriteLine("\nToo high.");
                    attempts++;
                } else
                {
                    Console.WriteLine("\nToo low.");
                    attempts++;
                }
            }

            Console.WriteLine($"You reached the limit of attempts to guess the number.\nThe number was {number}");
            // TODO: add dificulty levels
        }  
    }
}