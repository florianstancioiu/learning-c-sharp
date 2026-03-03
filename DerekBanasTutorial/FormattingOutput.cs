namespace LearningCSharp.DerekBanasTutorial 
{
	public class FormattingOutput
	{
		public FormattingOutput()
        {
            Console.WriteLine("Currency: {0:c}", 23.455);
            Console.WriteLine("Pad with zeroes: {0:d4}", 23);
            Console.WriteLine("3 Decimals: {0:f3}", 23.45555);
            Console.WriteLine("Commas: {0:n4}", 2300);
        }
    }
}