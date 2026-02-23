namespace LearningCSharp.BroCodeTutorial
{
    public class NumberGuessingGame
    {
        public NumberGuessingGame()
        {
            Random randomObject = new Random();
            int randomNumber = randomObject.Next(0, 100);
            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("Guess the number between 0 and 99: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == randomNumber)
                {
                    Console.WriteLine("You guessed right!");
                    keepPlaying = false;
                }
                else if (number < randomNumber)
                {
                    Console.WriteLine("The number you entered ("+ number +") is smaller than the random number");
                }
                else if (number > randomNumber)
                {
                    Console.WriteLine("The number you entered ("+ number +") is bigger than the random number");
                }
            }
        }
    }
}