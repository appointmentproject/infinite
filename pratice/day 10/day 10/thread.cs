using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day11Dotnet
{
    class MultiThreadEg
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started...");
            //creating Threads
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1",
                Priority = ThreadPriority.Highest,
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2",
                Priority = ThreadPriority.Normal,

            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            //executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended..");
            //example to work with threadstart (a delegate)
            //first creating an object of the delegate and manking it point to DisplayNumbers Method
            //  ThreadStart ts = new ThreadStart(DisplayNumbers);
            //passing the threadstart delegate object as a parameter to thread class Constructor
            // Thread t4 = new Thread(ts);
            //way2
            //Thread t4 = new Thread(new ThreadStart(DisplayNumbers));
            //way3
            //Thread t4 = new Thread(delegate () { DisplayNumbers(); });
            //way4
            //Thread t4 = new Thread(() => { DisplayNumbers(); });
            //way6
                     Thread t4 = new Thread(() => {
                         for (int i = 1; i <= 10; i++)
                           {
                             Console.WriteLine(i);
                           }
                           });

            t4.Start();
            Console.Read();
        }

        static void DisplayNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 1:" + i);
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 2:" + i);
                if (i == 3)
                {
                    Console.WriteLine("Data Copying Operation Started...");
                    //put the thread to sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Data Copying Operation Completed");
                }
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 3:" + i);
            }
        }
    }
}