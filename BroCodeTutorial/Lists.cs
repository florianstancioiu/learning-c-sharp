using System.Collections.Generic; 

namespace LearningCSharp.BroCodeTutorial
{
    public class Lists
    {
        public Lists()
        {
            // List = data structure similar to array, but it can dynamically increase/decrease in size
            // it's available inside System.Collections.Generic
            
            List<String> meals = new List<String>();

            meals.Add("pizza");
            meals.Add("hamburger");
            meals.Add("hotdog");
            meals.Add("fries");

            // meals.Remove("fries");
            meals.Insert(0,  "sarmale");

            Console.WriteLine($"The meal item at index 0 is: {meals[0]}");
            Console.WriteLine();

            Console.WriteLine($"The amount of meals is: {meals.Count}");
            Console.WriteLine();

            Console.WriteLine($"The index of fries is: {meals.IndexOf("fries")}");
            Console.WriteLine();

            Console.WriteLine($"Is there a pizza in the meals list? : {(meals.Contains("pizza") ? "Yes" : "No")}");
            Console.WriteLine();

            // meals.Sort();
            // meals.Clear();
            // String[] mealsArray = meals.ToArray();

            foreach (String meal in meals)
            {
                Console.WriteLine(meal);
            }
        }
    }
}