namespace LearningCSharp.BroCodeTutorial
{
    public class RandomNumbers
    {
        public RandomNumbers()
        {
            Random random = new Random(); 

            int randomIntNumber = random.Next(1, 7);
        
            double randomDoubleNumber = random.NextDouble();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}