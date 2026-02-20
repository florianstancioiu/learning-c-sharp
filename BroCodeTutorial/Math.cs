namespace LearningCSharp.BroCodeTutorial
{
    public class Math
    {
        public Math()
        {
            double x = -3.14;
            double y = 5;

            double a = System.Math.Pow(x, 2);
            double b = System.Math.Sqrt(x);
            double c = System.Math.Abs(3);
            double d = System.Math.Round(x);
            double e = System.Math.Ceiling(x);
            double f = System.Math.Floor(x);
            double g = System.Math.Max(x, y);
            double h = System.Math.Min(x, y);

            Console.WriteLine(h);
        }
    }
}