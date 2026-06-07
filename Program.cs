namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            // generates the random number
            Random rand = new Random();
            int number = rand.Next(101);

            Console.WriteLine(number);  // for testing

            while (keepPlaying)
            {
                Console.Write("\nInform a number: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess == number)
                {
                    Console.Write($"You win! The number was {number}");
                    keepPlaying = false;
                } else if (userGuess > number)
                {
                    Console.Write("Too high.");
                } else
                {
                    Console.Write("Too low.");
                }
            }
            
        }  
    }
}