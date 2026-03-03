namespace LearningCSharp.DerekBanasTutorial.ComplexExample
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}