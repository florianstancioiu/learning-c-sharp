namespace LearningCSharp.DerekBanasTutorial
{
    class OperatorOverloading
    {
        public OperatorOverloading()
        {
            Box box1 = new Box(2,3,4);
            Box box2 = new Box(5,6,7);

            Box box3 = box1 + box2;

            Console.WriteLine($"box3: {box3}");
            Console.WriteLine($"box3 int: {(int)box3}");

            Box box4 = (Box)4;

            Console.WriteLine($"box4: {box4}");
        }
    }

    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }
    
        public Box() : this(1,1,1) {}

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };

            return box;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };

            return box;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if (
                (box1.Length == box2.Length) && 
                (box1.Width == box2.Width) && 
                (box1.Breadth == box2.Breadth)
            )
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if (
                (box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth)
            )
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Length: {Length}, Width: {Width}, Breadth: {Breadth}";
        }

        // convert a box into an int
        public static explicit operator int(Box box)
        {
            return (int)((box.Length + box.Width + box.Breadth) / 3);
        }

        // convert an int into a box
        public static implicit operator Box(int number)
        {
            return new Box(number, number, number);
        }

        // This is needed because we created an operator overloader for == or !=
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        // This is needed because we created an operator overloader for == or !=
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}