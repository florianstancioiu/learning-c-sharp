namespace LearningCSharp.BroCodeTutorial
{
    public class Classes
    {
        public Classes()
        {
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
        }
    }

    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Welcome to the program");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }

        public static void Bye()
        {
            Console.WriteLine("Bye! Thanks for visiting!");
        }
    }
}