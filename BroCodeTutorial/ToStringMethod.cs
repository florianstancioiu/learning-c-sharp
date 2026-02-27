namespace LearningCSharp.BroCodeTutorial
{
    public class ToStringMethod
    {
        public ToStringMethod()
        {
            // ToString converts an object to its string representation
            
            Car7 firstCar = new Car7("Chevy", "Corvette", 2022, "blue");

            Console.WriteLine(firstCar);
        }
    }

    class Car7
    {
        String make;
        String model;
        int year;
        String color;

        public Car7(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override String ToString()
        {
            return $"The car is a {this.make} {this.model} from {this.year} with a {this.color} color";
        }
    }
}