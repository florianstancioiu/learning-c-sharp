using System.Globalization;
using System.Text;

namespace LearningCSharp.DerekBanasTutorial 
{
	public class StringBuilderNotion
	{
		public StringBuilderNotion()
        {
            // whenever you work with strings, you actually create new instances, strings are immutable in C# 
            // StringBuilder allows you to change the strings directly in memory
            // it is useful for working with large strings
            
            StringBuilder sb = new StringBuilder("Random text", 256);

            Console.WriteLine(sb);
            Console.WriteLine("Capacity: {0}", sb.Capacity);
            Console.WriteLine("Lenght: {0}", sb.Length);
            sb.Append("\n More content text here");

            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            String bestCustomer = "Bob Smith";
            sb.AppendFormat(enUs, "Best customer: {0}", bestCustomer);

            Console.WriteLine(sb.ToString());
            sb.Replace("text", "characters");
            Console.WriteLine(sb.ToString());
        }
    }
}