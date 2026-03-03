namespace LearningCSharp.DerekBanasTutorial
{
    class Dictionaries
    {
        public Dictionaries()
        {
            // a Dictionary is a generic collection that stores key value pairs

            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Barry Allen", "The Flash");

            superheroes.Remove("Barry Allen");

            Console.WriteLine("Count: {0}", superheroes.Count);
            Console.WriteLine($"Clark Kent is present: {(superheroes.ContainsKey("Clark Kent") ? "Yes" : "No")}");

            superheroes.TryGetValue("Clark Kent", out String? test);
            Console.WriteLine($"Clark Kent: {test}");

            Console.WriteLine("-----------------------------");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }
    }
}