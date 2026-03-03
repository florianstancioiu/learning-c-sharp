namespace LearningCSharp.DerekBanasTutorial 
{
	public class NullableTypes
	{
		public NullableTypes()
        {
            // regular datatypes can't be null 
            // you have to mark them as nullable using the ? symbol

            int? randNumber = null;

            if (randNumber == null)
            {
                Console.WriteLine("randNumber is null");
            }

            if (!randNumber.HasValue)
            {
                Console.WriteLine("randNumber is null");
            }
        }
    }
}