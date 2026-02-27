namespace LearningCSharp.BroCodeTutorial
{
    public class ArrayOfObjects
    {
        public ArrayOfObjects()
        {
            Car5[] garage = new Car5[3];

            Car5 firstCar = new Car5("Mustang");
            Car5 secondCar = new Car5("Corvette");
            Car5 thirdCar = new Car5("Lambo");

            garage[0] = firstCar;
            garage[1] = secondCar;
            garage[2] = thirdCar;

            /*
            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            */

            Car5[] garage2 =
            {
                new Car5("Ford Mustang"),
                new Car5("Chevy Corvette"),
                new Car5("Lamborghini"),
            };

            foreach (Car5 car in garage2)
            {
                Console.WriteLine(car.model);
            }
        }
    }

    public class Car5
    {
        public String model;

        public Car5(String model)
        {
            this.model = model;
        }
    } 
}