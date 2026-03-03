namespace LearningCSharp.DerekBanasTutorial 
{
	public class PassByReference
	{
		public PassByReference()
        {
            // the ref keyword allows you to pass values by reference
            // you need to use it both in the method call and method definition
            int num3 = 10;
            int num4 = 20;

            Console.WriteLine("Before swap: num1={0} and num2={1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After swap: num1={0} and num2={1}", num3, num4);
        }

        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
    }
}