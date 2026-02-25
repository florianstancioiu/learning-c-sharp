namespace LearningCSharp.BroCodeTutorial
{
    public class MultidimensionalArrays
    {
        public MultidimensionalArrays()
        {
            String[] ford = {"Mustang", "F-150", "Explorer"};
            String[] chevy = {"Corvette", "Camaro", "Siverado"};
            String[] toyota = {"Corolla", "Camry", "Rav4"};

            String[,] parkingLot =
            {
                {"Mustang", "F-150", "Explorer"},
                {"Corvette", "Camaro", "Siverado"},
                {"Corolla", "Camry", "Rav4"},
            };

            parkingLot[0, 2] = "Fusion"; // change the first row, third item to Fusion
            parkingLot[2, 0] = "Tacoma";

            Console.WriteLine("Iterate through the array with foreach");
            Console.WriteLine();

            // foreach will go through every single item
            // not through every single row
            foreach(String car in parkingLot)
            {
                Console.WriteLine(car);
            }


            Console.WriteLine();
            Console.WriteLine("Iterate through the array with nested for loops");
            Console.WriteLine();
            for (int i = 0; i<parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j<parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i, j]);
                }
            }
        }
    }
}