namespace LearningCSharp.BroCodeTutorial
{
    public class ExceptionHandling 
    {
        public ExceptionHandling()
        {
            double firstNumber;
            double secondNumber;

            // you can add multiple catch blocks to try catch
            // it's best practice to catch specific cases first and at the end to catch a general Exception
            try
            {
                Console.WriteLine("Enter number 1: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Enter number 2: ");
                secondNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("The result is: " + firstNumber / secondNumber);
            } 
            catch(FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers!");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
        }
    }
}