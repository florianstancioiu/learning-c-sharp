namespace LearningCSharp.DerekBanasTutorial
{
    public class AnonymousTypes
    {
        public AnonymousTypes()
        {
            var shopkins = new { Name = "Shopkins", Price = 4.99 };

            Console.WriteLine("{0} costs ${1}", shopkins.Name, shopkins.Price);
            Console.WriteLine();

            var toyArray = new[]
            {
                new
                {
                    Name = "Yo-Kai Pack",
                    Price = 4.99
                },
                new
                {
                    Name = "Legos",
                    Price = 9.99
                },
            };

            foreach (var toy in toyArray)
            {
                Console.WriteLine("{0} costs ${1}", toy.Name, toy.Price);
            }
        }
    }
}