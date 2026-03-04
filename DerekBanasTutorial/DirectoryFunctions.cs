namespace LearningCSharp.DerekBanasTutorial 
{
	public class DirectoryFunctions
	{
		public DirectoryFunctions()
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(".");

            Console.WriteLine(currentDirectory.FullName);
            Console.WriteLine(currentDirectory.Name);
            Console.WriteLine(currentDirectory.Parent);
            Console.WriteLine(currentDirectory.Attributes);
            Console.WriteLine(currentDirectory.CreationTime);

            String dirLocation = @"C:\Code\learning-c-sharp\DinamicallyCreated";
            DirectoryInfo dinamicallyCreatedDir = new DirectoryInfo(dirLocation);

            if (!Directory.Exists(dirLocation))
            {
                // Create the directory
                dinamicallyCreatedDir.Create();
                
                // Delete the directory
                // Directory.Delete(dirLocation);
            }

        }
    }
}