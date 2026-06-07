namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // generates the random number
            Random rand = new Random();
            int number = rand.Next(101);

            Console.WriteLine(number);  // for testing

            Console.Write("Inform a number: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess == number)
            {
                Console.Write($"You win! The number was {number}");
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