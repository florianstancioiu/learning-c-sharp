namespace LearningCSharp.BroCodeTutorial
{
    public class Inheritance
    {
        public Inheritance()
        {
            // There isn't a keyword for extending classes
            // There is however the colon sign (:) that does the trick

            Car3 bmw = new Car3("BMW");
            Bicycle pegasus = new Bicycle("Pegasus");

            bmw.Go();
            pegasus.Go();
        }   
    }

    public class Vehicle
    {
        public String name;

        public int speed = 0; 
    
        public Vehicle(String name)
        {
            this.name = name;
        }

        public void Go()
        {
            Console.WriteLine($"This {name} is moving!");
        }
    }

    class Car3 : Vehicle
    {
        public int wheels = 4;

        public Car3(String name) : base(name)
        {
            this.name = name;
        }
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;

        public Bicycle(String name) : base(name)
        {
            this.name = name;
        }
    }

    class Boat : Vehicle
    {
        public int wheels = 0;

        public Boat(String name) : base(name)
        {
            this.name = name;
        }
    }
}