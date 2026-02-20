using System;

namespace LearningCSharp.BroCodeTutorial
{
    class Variables
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 30; // int stores a whole integer

            double height = 300.5;

            bool isAlive = true;

            char symbol = '@'; // a single character, in single quotes

            String name = "Florian"; // multiple string characters, in double quotes

            String userName = symbol + name;

            Console.WriteLine("Hello from " + name);
            Console.WriteLine("Your username is " + userName);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("The age is " + age);  
            Console.WriteLine("The height is " + height + "cm");  
            Console.WriteLine("The current alive status is " + isAlive);  
            Console.WriteLine("The symbol is " + symbol);  
        }
    }
}