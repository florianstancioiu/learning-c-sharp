namespace LearningCSharp.DerekBanasTutorial 
{
	public class StringFormat
	{
		public StringFormat()
        {
            String newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");

            Console.Write(newString + "\n");

            // escape characters are characters preceded by a backwards slash
            // \' \" \\ \t \a 
            Console.WriteLine("My name is \"Florian\"");

            // verbatim strings are string that are defined with @""
            Console.WriteLine(@"Exactly what I typed \t \n");
        }
    }
}