namespace LearningCSharp.DerekBanasTutorial
{
    class ZipNotion
    {
        public ZipNotion()
        {
            // Zip iterates through 2 lists of the same length and performs actions on both of the parameters at the same time
            var listOne = new List<int>(new int[] {1,3,4});
            var listTwo = new List<int>(new int[] {4,6,8});

            var sumList = listOne.Zip(listTwo, (x, y) => x + y);

            foreach(var item in sumList)
            {
                Console.WriteLine(item);
            }
        }
    }
}