namespace LearningCSharp.BroCodeTutorial
{
    public class Arrays
    {
        public Arrays()
        {
            // arrays are fuxed size
            // and you use curly braces in the right side, instead of square brackets
            String[] carsFixed = new string[2];

            carsFixed[0] = "Dacia";
            carsFixed[1] = "Aro";

            String[] cars = {"BMW", "Mercedes", "Dacia"};

            cars[0] = "Tesla";

            Console.WriteLine(cars[2]);
            // Console.WriteLine(cars[3]);
            Console.WriteLine(String.Join(", ", carsFixed));

            for (int i = 0; i<cars.Length; i++)
            {
                Console.WriteLine("The car brand at index " + i + " is: " + cars[i]);
            }
        }
    }
}