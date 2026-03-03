namespace LearningCSharp.DerekBanasTutorial 
{
	public class OutParameter
	{
		public OutParameter()
        {
            // the out paramter allows you to pass arguments to methods as a reference type
            int solution;

            DoubleIt(15, out solution);

            Console.WriteLine("15 * 2 = {0}", solution);
        }

        public static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }
    }
}