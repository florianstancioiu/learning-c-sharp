namespace LearningCSharp.BroCodeTutorial
{
    public class MethodOverloading
    {
        public MethodOverloading()
        {
            // method overloading = methods with the same name but different parameters

            double result = Multiply(2,3,4);

            Console.WriteLine(result);
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }
}