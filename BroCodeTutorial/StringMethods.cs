namespace LearningCSharp.BroCodeTutorial
{
    public class StringMethods
    {
        public StringMethods()
        {
            String fullName = "Florian Stancioiu";
            String upperFullName = fullName.ToUpper();
            String lowerFullName = fullName.ToLower();

            String phoneNumber = "123-456-7890";

            // phoneNumber = phoneNumber.Replace("-", "/");

            String userName = fullName.Insert(0, "@");

            int fullNameLength = fullName.Length;

            String firstName = fullName.Substring(0, 7);
            String lastName = fullName.Substring(8, 9);

            Console.WriteLine(lastName);
        }
    }
}