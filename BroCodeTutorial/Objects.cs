namespace LearningCSharp.BroCodeTutorial
{
    public class Objects
    {
        public Objects()
        {
            Human florian = new Human();
            florian.name = "Florian";
            florian.age = 30;

            florian.eat();
            florian.sleep();

            Console.WriteLine();

            Human rick = new Human();
            rick.name = "Rick Sanchez";
            rick.age = 45;

            rick.eat();
            rick.sleep();
        }
    }

    public class Human
    {
        public String name;
        public int age;

        public void eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}