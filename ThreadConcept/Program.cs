// See https://aka.ms/new-console-template for more inform
namespace ThreadConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Before");
            Console.WriteLine(Thread.CurrentThread.Name);
           var t1= new Thread(BoilingWater);
            var t2= new Thread(BoilingWater);
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;
            Thread.CurrentThread.Priority=ThreadPriority.BelowNormal;
            t1.Name = "Boiling Water Thread 1";
            t2.Name = "Boiling Water Thread 2";
            Thread.CurrentThread.Name = "Main Thread";
            t1.Start();
            t2.Start ();
            BoilingWater();

        }

        private static void BoilingWater() 
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }

        }
        private static void OpenDoor()
        {
            Console.WriteLine("Opening the door... ");
        }
    }
}