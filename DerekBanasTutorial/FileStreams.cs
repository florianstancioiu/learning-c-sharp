using System.Text;

namespace LearningCSharp.DerekBanasTutorial 
{
	public class FileStreams
	{
		public FileStreams()
        {
            string currentDir = Directory.GetCurrentDirectory();
            string dataDir = $@"{currentDir}\data";
            string exampleFilePath = $@"{dataDir}\exampleFile.txt";

            Console.WriteLine(exampleFilePath);

            // write a string to a file
            FileStream fs = File.Open(exampleFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string randomString = "This is a random string existing inside exampleFile.txt";
            byte[] randomStringByteArray = Encoding.Default.GetBytes(randomString);
            fs.Write(randomStringByteArray, 0, randomStringByteArray.Length);

            // reading the string from the file
            fs.Position = 0;

            byte[] fileByteArray = new byte[randomStringByteArray.Length];

            for (int i = 0; i < randomStringByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine();
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));

            // you need to close the filestream in order for the changes to take place
            fs.Close();
        }
    }
}