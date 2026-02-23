namespace LearningCSharp.BroCodeTutorial
{
    public class CalculatorProgram
    {
        public CalculatorProgram()
        {
            Console.WriteLine("First number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result; 

            String[] operations = ["add", "substract", "multiply", "divide"];

            Console.WriteLine("Select an operation between: " + string.Join(", ", operations));
            String operation = Console.ReadLine()!;

            if (!operations.Contains(operation))
            {
                Console.WriteLine("Please select a valid operation: " + string.Join(", ", operations));
                return;
            }

            switch(operation)
            {
                case "subtract":
                    result = number1 - number2;
                    break;
                case "multiply":
                    result = number1 * number2;
                    break;
                case "divide":
                    result = number1 / number2;
                    break;
                default:
                    result = number1 + number2;
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("The result of the " + operation + " is: " + result);
        }
    }
}