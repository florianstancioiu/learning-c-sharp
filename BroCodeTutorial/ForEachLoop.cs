namespace LearningCSharp.BroCodeTutorial
{
    public class ForEachLoop
    {
        public ForEachLoop()
        {
            String[] cars = {"Dacia", "BMW", "Mustang"};

            // You have to set the appropriate datatype of the singular item
            // Like String in this case
            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}