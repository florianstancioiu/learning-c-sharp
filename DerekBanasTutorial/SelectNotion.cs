namespace LearningCSharp.DerekBanasTutorial
{
    class SelectNotion
    {
        public SelectNotion()
        {
            // Select used on Lists in C# is like .map() used on arrays in JavaScript
            var oneToTen = new List<int>();
            oneToTen.AddRange(Enumerable.Range(1, 10));

            var squares = oneToTen.Select(a => a  * a);

            foreach(var square in squares)
            {
                Console.WriteLine(square);
            }
        }
    }
}