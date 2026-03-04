namespace LearningCSharp.DerekBanasTutorial 
{
	public class FileIO
	{
		public FileIO()
        {
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith",
                "John Smith",
                "Jane Smith",
            };

            string currentDir = Directory.GetCurrentDirectory();
            string dataDir = $@"{currentDir}\data";
            string customersFile = $@"{dataDir}\customersFile.txt";

            File.WriteAllLines(customersFile, customers);

            foreach(string customer in File.ReadAllLines(customersFile))
            {
                Console.WriteLine($"Customer: {customer}");
            }

            DirectoryInfo dataDirInfo = new DirectoryInfo(dataDir);
            FileInfo[] txtFiles = dataDirInfo.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine();
            Console.WriteLine($"There are {txtFiles.Length} txt files in {dataDir}");
            Console.WriteLine();

            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file);
            }
        }
    }
}