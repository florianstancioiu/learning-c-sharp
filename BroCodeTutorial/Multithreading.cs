using System.Threading;

namespace LearningCSharp.BroCodeTutorial
{
    public class Multithreading
    {
        public Multithreading()
        {
            // thread = an execution path of a program
            // we can use multiple threads to perform different tasks at the same time
            // the current thread is "main" thread
            // we use threads by including the System.Threading namespace

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            // the following code will run sequentially
            // it will first execute the entirety of CountDown method and then proceed with CountUp

            /*
            Console.WriteLine($"The name of the mainThread is: {mainThread.Name}");

            CountDown();
            CountUp();
            
            Console.WriteLine();
            Console.WriteLine($"The mainThread is complete!");
            */

            // the following code will run in parallel, it will not be sequential
            Thread firstThread = new Thread(() => CountDown());
            Thread secondThread = new Thread(() => CountUp());

            firstThread.Start();
            secondThread.Start();
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Timer #1: {i} seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Timer #2: {i} seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #2 is complete!");
        }
    }
}