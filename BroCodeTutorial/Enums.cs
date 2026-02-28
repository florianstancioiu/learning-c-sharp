namespace LearningCSharp.BroCodeTutorial
{
    public class Enums
    {
        public Enums()
        {
            Console.WriteLine($"{Planets.Mars} is a planet.");
            Console.WriteLine($"{Planets.Mercury} is planet number {(int)Planets.Mercury}.");
            Console.WriteLine($"{Planets.Venus} is planet number {(int)Planets.Venus}.");
            Console.WriteLine();

            String name = PlanetRadius.Earth.ToString();
            int radius = (int)PlanetRadius.Earth;
            double volume  = Volume(PlanetRadius.Earth); 

            Console.WriteLine($"planet : {name}");
            Console.WriteLine($"radius : {radius}km");
            Console.WriteLine($"volume : {volume}km^3");
        }

        public static double Volume(PlanetRadius radius)
        {
            double volume = (4.0/3.0) * System.Math.PI * System.Math.Pow((int) radius, 3);

            return volume;
        }
    }

    public enum Planets
    {
        Mercury = 1, 
        Venus, 
        Earth, 
        Mars, 
        Jupiter, 
        Saturn, 
        Neptune
    }

    public enum PlanetRadius
    {
        Mercury = 2439, 
        Venus = 6051, 
        Earth = 6371, 
        Mars = 3389, 
        Jupiter = 69911, 
        Saturn = 58232, 
        Neptune = 24622
    }
}