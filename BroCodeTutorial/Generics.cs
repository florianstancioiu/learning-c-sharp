namespace LearningCSharp.BroCodeTutorial
{
    public class Generics
    {
        public Generics()
        {
            // generic = allows multiple data type, is not specific to a particular data type
            // add a <T> to classes, methods, fields (properties)
            // allows for greater code reusuability

            int[] intArray = [1,2,3];
            double[] doubleArray = [3.0, 2.0, 1.0];
            string[] stringArray = ["1", "2", "3"];

            DisplayItems(intArray);
            DisplayItems(doubleArray);
            DisplayItems(stringArray);

            Console.WriteLine();
        }

        public static void DisplayItems<Thing>(Thing[] array)
        {
            Console.WriteLine();
            foreach(Thing item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}