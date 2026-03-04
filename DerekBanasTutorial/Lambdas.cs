namespace LearningCSharp.DerekBanasTutorial
{
    class Lambdas
    {
        public Lambdas()
        {
            // lambdas are arrow functions
            doubleIt dblIt = x => x * 2;

            Console.WriteLine($"5*2={dblIt(5)}");

            List<int> numList = new List<int> {1, 9, 2, 6, 3};

            // .Where is like .filter in JavaScript
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach (var evenNumber in evenList)
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine();

            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();
            foreach (var rangeNumber in rangeList)
            {
                Console.WriteLine(rangeNumber);
            }

            Console.WriteLine();

            List<int> flipList = new List<int>();
            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());
            Console.WriteLine();

            var nameList = new List<String> {"Doug", "Sally", "Sue"};
            var sNameList = nameList.Where(x => x.StartsWith("S"));

            foreach(var name in sNameList)
            {
                Console.WriteLine(name);
            }
        }

        delegate double doubleIt(double value);
    }
}