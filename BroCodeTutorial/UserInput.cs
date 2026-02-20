namespace LearningCSharp.BroCodeTutorial
{
    public class UserInput
    {
        public UserInput()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine(); // this will throw an exception when null is passed, when you press enter without typing anything

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine()); // this will throw an exception when you press enter without typing anything

            Console.WriteLine("Hi, " + name + ", your age is " + age);
        }
    }
}