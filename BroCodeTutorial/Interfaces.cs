namespace LearningCSharp.BroCodeTutorial
{
    public class Interfaces
    {
        public Interfaces()
        {
            // interface = a contract that all inheriting classes should follow
            // a class denotes that it implements an interfaces with the colon sign (:)

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            fish.Hunt();
            fish.Flee();
        }
    }

    interface IPrey
    {
        public void Flee();
    }

    interface IPredator
    {
        public void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is hunting!");
        }
    }

    class Fish : IPredator, IPrey 
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }
}