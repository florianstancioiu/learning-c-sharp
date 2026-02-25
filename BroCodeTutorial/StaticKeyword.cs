namespace LearningCSharp.BroCodeTutorial
{
    public class StaticKeyword
    {
        public StaticKeyword()
        {
            Car2 firstCar = new Car2("Mustang");
            Car2 secondCar = new Car2("Corvette");
            Car2 thirdCar = new Car2("BMW");

            Console.WriteLine($"There are {Car2.instances} instances of Car2 objects");
            Car2.StartRace();
        }
    }

    class Car2
    {
        public static int instances = 0;

        String model;

        public Car2(String model)
        {
            this.model = model;

            instances += 1;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race was started!");
        }
    }
}