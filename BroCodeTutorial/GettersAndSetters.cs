namespace LearningCSharp.BroCodeTutorial
{
    public class GettersAndSetters
    {
        public GettersAndSetters()
        {
            
            Car8 car = new Car8(40);

            // we limit the speed to 80 in the setter "method" of Speed
            car.Speed = 10000;
            
            Console.WriteLine($"The speed of the car is: {car.Speed}");
        }
    }

    public class Car8
    {
        protected int speed;

        public Car8(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get 
            { 
                return speed; 
            }
            set
            {
                if (value > 80)
                {
                    speed = 80;
                } else
                {
                    // value is a special keyword that represents the value given in the assignment operation
                    speed = value; 
                }
            }
        }
    }
}