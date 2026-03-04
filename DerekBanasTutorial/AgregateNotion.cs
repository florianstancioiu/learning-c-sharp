namespace LearningCSharp.DerekBanasTutorial
{
    class AgregateNotion
    {
        public AgregateNotion()
        {
            // Agregate is like .reduce() in JavaScript
            var numList = new List<int>() { 1,2,3,4,5 };
            
            Console.WriteLine("Sum {0}", numList.Aggregate((a, b) => a + b));
            Console.WriteLine("Product {0}", numList.Aggregate((a, b) => a * b));
        }
    }
}