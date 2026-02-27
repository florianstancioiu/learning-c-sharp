namespace LearningCSharp.BroCodeTutorial
{
    public class AbstractClasses
    {
        public AbstractClasses()
        {
            // the abstract modifier signals that the class has an incomplete implementation

            // Vehicle2 vehicle = new Vehicle2(); // this is not allowed because the class Vehicle2 is incomplete
            Car4 bmw = new Car4(); // this is allowed because it's not abstract

            bmw.Go();
        }
    }

    public abstract class Vehicle2
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving!");
        } 
    }

    public class Car4 : Vehicle2
    {
        
    }
}