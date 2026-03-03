namespace LearningCSharp.DerekBanasTutorial 
{
	public class InnerClasses
	{
		public InnerClasses()
        {
            // you can have classes within classes
            // the inner classes are helper classes

            AnimalHealth horseHealth = new AnimalHealth();

            Console.WriteLine($"the horse has a healthy weight: {(horseHealth.HealthyWeight(140, 200) ? "Yes" : "No")}");
        }

        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;

                return calc >= .18 && calc <= .27;
            }
        }
    }
}