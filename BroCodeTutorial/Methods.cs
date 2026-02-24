namespace LearningCSharp.BroCodeTutorial
{
    public class Methods
    {
        public Methods()
        {
            String name = "Florian";

            this.HappyBirthday(name);
            this.HappyBirthday(name);
            this.HappyBirthday(name);
        }

        public void HappyBirthday(string name)
        {
            Console.WriteLine("Happy birthday!");
            Console.WriteLine("Happy birthday!");
            Console.WriteLine("Happy birthday, dear " + name + "!");
            Console.WriteLine("--------------");
        }
    }
}