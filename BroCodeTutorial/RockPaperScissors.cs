namespace LearningCSharp.BroCodeTutorial
{
    public class RockPaperScissors
    {
        public RockPaperScissors()
        {
            String[] choices = ["rock", "paper", "scissors"];
            Random randomObject = new Random();
            int intComputersChoice = randomObject.Next(0, 3);
            String computersChoice = choices[intComputersChoice];

            Console.WriteLine("Rock, Paper or Scissors ?");
            String playersChoice = Console.ReadLine()!;
            playersChoice = playersChoice.ToLower();

            if (!choices.Contains(playersChoice))
            {
                Console.WriteLine("Please choose between Rock, Paper or Scissors!");
                return;
            }

            Console.WriteLine("Computer: " + computersChoice);
            Console.WriteLine("Player: " + playersChoice);
            Console.WriteLine();

            if (playersChoice == computersChoice)
            {
                Console.WriteLine("It's a draw!");
            }

            if (playersChoice == "rock")
            {
                if (computersChoice == "paper")
                {
                    Console.WriteLine("The computer won!");
                }

                if (computersChoice == "scissors")
                {
                    Console.WriteLine("You won!");
                }
            }

            if (playersChoice == "paper")
            {
                if (computersChoice == "scissors")
                {
                    Console.WriteLine("The computer won!");
                }

                if (computersChoice == "rock")
                {
                    Console.WriteLine("You won!");
                }
            }

            if (playersChoice == "scissors")
            {
                if (computersChoice == "rock")
                {
                    Console.WriteLine("The computer won!");
                }

                if (computersChoice == "paper")
                {
                    Console.WriteLine("You won!");
                }
            }
        }
    }
}