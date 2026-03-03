namespace LearningCSharp.DerekBanasTutorial
{
    class GenericsNotion
    {
        public GenericsNotion()
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numberList = new List<int>();

            numberList.Add(24);

            animalList.Add(new Animal() { Name = "Doug" });
            animalList.Add(new Animal() { Name = "Paul" });
            animalList.Add(new Animal() { Name = "Sally" });

            animalList.Insert(1, new Animal() { Name = "Steve" });
            animalList.RemoveAt(2);

            int x = 5, y = 4;
            Animal.GetSum<int>(ref x, ref y);

            String stringX = "5", stringY = "4";
            Animal.GetSum<string>(ref stringX, ref stringY);
        }
    }

    class Animal
    {
        public String Name { get; set; }
        
        public Animal(String name = "No Name")
        {
            Name = name;
        }

        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double doubleX = Convert.ToDouble(num1);
            double doubleY = Convert.ToDouble(num2);

            Console.WriteLine($"{doubleX} + {doubleY} = {doubleX + doubleY}");
        }
    }
}