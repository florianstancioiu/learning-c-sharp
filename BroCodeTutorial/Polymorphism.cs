namespace LearningCSharp.BroCodeTutorial
{
    public class Polymorphism
    {
        public Polymorphism()
        {
            // in polymorphism objects can be identified by more than one type
            // basically you use the parent class to group the classes in an array when you need them grouped

            Boat3 boat = new Boat3();
            Bicycle3 bicycle = new Bicycle3();

            Vehicle3[] vehicles = {boat, bicycle};

            foreach(Vehicle3 vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicle3
    {
        public virtual void Go()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    class Boat3 : Vehicle3
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }

    class Bicycle3 : Vehicle3
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
}