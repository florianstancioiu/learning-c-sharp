namespace LearningCSharp.BroCodeTutorial
{
    public class ReturnKeyword
    {
        public ReturnKeyword()
        {
            Console.WriteLine("Enter the first number to multiply: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine("Enter the second number to multiply: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The result is: " + Multiply(firstNumber, secondNumber));
        }

        public static double Multiply(double x, double y)
        {
            double z = x * y;

            return z;
        }
    }
}