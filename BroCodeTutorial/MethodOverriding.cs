namespace LearningCSharp.BroCodeTutorial
{
    public class MethodOverriding
    {
        public MethodOverriding()
        {
            // method overriding is available when you declare the parent method as 'abstract' or 'virtual'
            // you also need to write the 'override' before the datatype when you override the method
            // it is used with the ToString() method and polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof woof*");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow meow*");
        }
    }
}