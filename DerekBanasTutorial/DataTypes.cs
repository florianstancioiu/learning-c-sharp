namespace LearningCSharp.DerekBanasTutorial 
{
	public class DataTypes
	{
		public DataTypes()
		{
			bool canIVote = true;

			Console.WriteLine($"Can I vote? {(canIVote ? "Yes" : "No")}");

			Console.WriteLine($"The max value of int is {int.MaxValue}");
			Console.WriteLine($"The min value of int is {int.MinValue}");

			Console.WriteLine();

			Console.WriteLine("The max value of long is {0}", long.MaxValue);
			Console.WriteLine("The min value of long is {0}", long.MinValue);

			decimal PiValue = 3.14159M;
			decimal decBigNum = 3.000000000000000011M;

			Console.WriteLine("DEC : PI + bigNum = {0}", PiValue + decBigNum);

			Console.WriteLine("Biggest decimal: {0}", decimal.MaxValue);
		}
	}
}