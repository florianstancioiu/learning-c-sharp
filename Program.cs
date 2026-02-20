using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program.Variables();
            // Program.Constants();
            // Program.TypeCasting();
            Program.UserInput();
        }
        
        static void Variables()
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

        static void Constants()
        {
            /* 
                In order to set a variable as a constant you must prefix the data type with the const keyword
            */
            const double pi = 3.14159; 

            Console.WriteLine("PI with the first 5 digits is: " + pi);
        }

        static void TypeCasting()
        {
            // type casting = convert a variable type to a different one

            double a = 3.14;

            int b = Convert.ToInt32(a);

            int c = 123;

            double d = Convert.ToDouble(c);
            
            int e = 321;

            String f = Convert.ToString(e);

            // we can store a single character in a string
            // but that doesn't mean it acts like a char, is still a string
            String g = "$";

            char h = Convert.ToChar(g);

            String i = "true";

            bool j = Convert.ToBoolean(i);

            Console.WriteLine("the value of b is " + b);
            Console.WriteLine("the data type of b is " + b.GetType());
            
            Console.WriteLine();

            Console.WriteLine("the value of d is " + d);
            Console.WriteLine("the data type of d is " + d.GetType());
            
            Console.WriteLine();
            
            Console.WriteLine("the value of f is " + f);
            Console.WriteLine("the data type of f is " + f.GetType());
            
            Console.WriteLine();
            
            Console.WriteLine("the value of h is " + h);
            Console.WriteLine("the data type of h is " + h.GetType());
            
            Console.WriteLine();
            
            Console.WriteLine("the value of j is " + j);
            Console.WriteLine("the data type of j is " + j.GetType());
        }


        static void UserInput()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine(); // this will throw an exception when null is passed, when you press enter without typing anything

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine()); // this will throw an exception when you press enter without typing anything

            Console.WriteLine("Hi, " + name + ", your age is " + age);
        }
    }
}