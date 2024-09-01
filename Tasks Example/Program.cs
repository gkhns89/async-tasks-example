using System;
using System.Threading.Tasks;

namespace TasksExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Method is started.");

            Task.Factory.StartNew(() => Works.Work3());
            Task.Factory.ContinueWhenAll(
          
                new Task[]
            {
                        Task.Factory.StartNew(() => Works.Work4()),
                        Task.Factory.StartNew(() => Works.Work2())
            
            },

            tasks=>Works.Work1()
            
            );
            

            Console.WriteLine("Main Method done.");
            Console.ReadLine();
        }
    }
}
