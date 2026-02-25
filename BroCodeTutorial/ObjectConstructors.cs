namespace LearningCSharp.BroCodeTutorial
{
    public class ObjectConstructors
    {
        public ObjectConstructors()
        {
            Human2 florian = new Human2("Florian", 30);
            florian.eat();
            florian.sleep();

            Console.WriteLine();

            Human2 rick = new Human2("Rick Sanchez", 45);
            rick.eat();
            rick.sleep();

            Console.WriteLine();

            Car firstCar = new Car("Ford", "Mustang", 2022, "red");
            firstCar.Drive();
            Console.WriteLine();

            Car secondCar = new Car("Chevy", "Corvette", 2021, "blue");
            firstCar.Drive();
        }
    }

    public class Human2
    {
        protected String name;
        protected int age;

        public Human2(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        public void sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }

    public class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;        
        }

        public void Drive()
        {
            Console.WriteLine($"You drive a {make} {model} from year {year} with a {color} color.");
        }
    }
}