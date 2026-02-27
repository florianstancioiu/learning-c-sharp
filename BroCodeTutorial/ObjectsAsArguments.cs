namespace LearningCSharp.BroCodeTutorial
{
    public class ObjectsAsArguments
    {
        public ObjectsAsArguments()
        {
            Car6 firstCar = new Car6("Mustang", "red");
            Car6 secondCar = CopyCar(firstCar);

            ChangeColor(firstCar, "green");

            Console.WriteLine($"The {firstCar.model} has a {firstCar.color} color");
            Console.WriteLine($"The second car is a {secondCar.model} with a {secondCar.color} color");
        }

        public static void ChangeColor(Car6 car, String color)
        {
            car.color = color;
        }

        public static Car6 CopyCar(Car6 car)
        {
            return new Car6(car.model, car.color);
        }
    }

    public class Car6
    {
        public String model;

        public String color;

        public Car6(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}