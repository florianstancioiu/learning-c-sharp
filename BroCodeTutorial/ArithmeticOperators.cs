namespace LearningCSharp.BroCodeTutorial
{
    public class ArithmeticOperators
    {
        public ArithmeticOperators()
        {
            int friends = 10;

            // friends = friends + 1;
            // friends += 1;
            // friends++;
            
            // friends = friends - 1;
            // friends -= 1;
            // friends--;

            // friends = friends * 2;
            // friends *= 2;

            // friends = friends / 2;
            // friends /= 2;

            int remainder = friends % 3;

            Console.WriteLine("The number of friends is: " + friends);
            Console.WriteLine("The remainder is: " + remainder);
        }
    }
}