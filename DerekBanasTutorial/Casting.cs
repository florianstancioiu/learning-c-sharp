namespace LearningCSharp.DerekBanasTutorial
{
    public class Casting
    {
        public Casting()
        {
            bool boolFromString = bool.Parse("true");
            int intFromString = int.Parse("200");
            double doubleFromString = double.Parse("1.234");

            Console.WriteLine($"boolFromString value is: {boolFromString}");
            Console.WriteLine($"intFromString value is: {intFromString}");
            Console.WriteLine($"doubleFromString value is: {doubleFromString}");

            String stringValue = doubleFromString.ToString();

            Console.WriteLine($"Data type of stringValue is: {stringValue.GetType()}");

            double dblNum = 12.345;

            Console.WriteLine($"Integer : {(int)dblNum}");

            int intNum = 10;
            long longNum = intNum;

            Console.WriteLine($"Long : {longNum}");
        }
    }
}