namespace LearningCSharp.BroCodeTutorial
{
    public class ParamsKeyword
    {
        public ParamsKeyword()
        {
            // when it is used, the "params" keyword must precide any array datatype 
            // for example: (params double[] prices)

            double total = CheckOut(3.99, 5.75, 15, 1.0, 10.25);

            Console.WriteLine("The total is: " + total);
        }

        public static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach(double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}