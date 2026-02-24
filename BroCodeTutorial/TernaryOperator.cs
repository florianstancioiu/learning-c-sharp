namespace LearningCSharp.BroCodeTutorial
{
    public class TernaryOperator
    {
        public TernaryOperator()
        {
            double temperature = 15;

            String message = temperature >= 15 ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(message);
        }
    } 
}