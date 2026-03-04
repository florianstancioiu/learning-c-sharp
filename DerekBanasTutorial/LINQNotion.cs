namespace LearningCSharp.DerekBanasTutorial
{
    public class LINQNotion
    {
        public LINQNotion()
        {
            // LINQ = Language Integrated Query
            // it's similar to sql and it can work with data, not only databases

           QueryStringArray();
           QueryIntArray();
        }

        static void QueryStringArray()
        {
             String[] dogs =
            {
                "K 9",
                "Brian Griffin",
                "Scooby Doo",
                "Old Yeller",
                "Rin Tin Tin",
                "Benji",
                "Charlie B. Barkin",
                "Lassie",
                "Snoopy",
            };

            var dogsWithSpaces = from dog in dogs
                                    where dog.Contains(" ")
                                    orderby dog descending
                                    select dog;

            foreach (var dog in dogsWithSpaces)
            {
                Console.WriteLine(dog);
            }
        }

        static void QueryIntArray()
        {
            int[] nums = {5, 10, 15, 20, 25, 30, 35};

            var greaterThan20 = from num in nums 
                                where num > 20
                                orderby num
                                select num;
            
            foreach(int num in greaterThan20)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"Get Type : {greaterThan20.GetType()}");
        }
    }
}