using System;

namespace LearningCSharp.BroCodeTutorial
{
    
    class Constants
    {
        static void Main(string[] args)
        {
            /* 
                In order to set a variable as a constant you must prefix the data type with the const keyword
            */
            const double pi = 3.14159; 

            Console.WriteLine("PI with the first 5 digits is: " + pi);
        }
    }
}