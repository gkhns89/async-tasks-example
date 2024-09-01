using System;
using System.Threading;

namespace TasksExample
{
    class Works
    {
       public static void Work1()
        {
            Console.WriteLine("Work 1 is started.");
            Thread.Sleep(2000);
            Console.WriteLine("Work 1 done.");
        }
       
       public static void Work2()
        {
            Console.WriteLine("Work 2 is started.");
            Thread.Sleep(10000);
            Console.WriteLine("Work 2 done.");
        }
       
       public static void Work3()
        {
            Console.WriteLine("Work 3 is started.");
            Thread.Sleep(15000);
            Console.WriteLine("Work 3 done.");
        }
       
       public static void Work4()
        {
            Console.WriteLine("Work 4 is started.");
            Thread.Sleep(10000);
            Console.WriteLine("Work 4 done.");
        }
    }
}
