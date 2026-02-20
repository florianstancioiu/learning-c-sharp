using System;

namespace LearningCSharp.BroCodeTutorial
{
    class TypeCasting
    {
        static void Main(string[] args)
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
    }
}