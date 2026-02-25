namespace LearningCSharp.BroCodeTutorial
{
    public class StringInterpolation
    {
        public StringInterpolation()
        {
            // string interpolation is done by preceding the string with a $ (dollar sign) and using {} (curly braces) to interpolate variables
            String firstName = "Florian";

            Console.WriteLine($"The firstName is: {firstName}");

            // you can pass a second integer parameter to the interpolated variables
            // that you can use to append spaces before or after the variables

            int age = 30;

            Console.WriteLine($"Your age is {age, 10} years old"); // this will add 10 spaces before the age
            Console.WriteLine($"Your age is {age, -10} years old"); // this will add 10 spaces after the age
        }
    }
}