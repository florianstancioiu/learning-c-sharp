namespace LearningCSharp.BroCodeTutorial
{
    public class AutoImplementedProperties
    {
        public AutoImplementedProperties()
        {
            Car9 car = new Car9("BMW");

            Console.WriteLine($"The model of the car is: {car.Model}");
        }
    }

    public class Car9
    {
        public String Model { get; set; } // this is equal with the code commented bellow
        
        /*
        private String model;

        public String Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        } 
        */

        public Car9(String model)
        {
            this.Model = model;
        }
    }
}