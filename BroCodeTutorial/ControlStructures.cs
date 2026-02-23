namespace LearningCSharp.BroCodeTutorial
{
    public class ControlStructures
    {
        public ControlStructures()
        {
            // this.IfStatement();
            this.switchStatement();
        }

        public void IfStatement()
        {
            Console.WriteLine("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible for a credit card");
            } 
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet");
            }
            else if (age > 100)
            {
                Console.WriteLine("You are too old");
            }
            else
            {
                Console.WriteLine("You are not eligible for a credit card");
            }

            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name...");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }
        }

        public void switchStatement()
        {
            Console.WriteLine("Enter day: ");
            String day = Console.ReadLine();

            switch(day)
            {
                case "Monday": 
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday": 
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday": 
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday": 
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday": 
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday": 
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday": 
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a valid day");
                    break;
            }
        }
    }
}