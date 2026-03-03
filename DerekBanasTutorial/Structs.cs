namespace LearningCSharp.DerekBanasTutorial 
{
	public class Structs
	{
		public Structs()
        {
            // struct = a value type that can encapsulate data and related functionality
            // struct must be used inside of the class definition, not inside the method definition

            Rectangle rectangle1;
            rectangle1.length = 150;
            rectangle1.width = 50;

            Rectangle rectangle2 = new Rectangle(2, 8);

            Console.WriteLine("The area of rectangle1 is {0}", rectangle1.Area());
            Console.WriteLine("The area of rectangle2 is {0}", rectangle2.Area());
        }
        
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 2)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}