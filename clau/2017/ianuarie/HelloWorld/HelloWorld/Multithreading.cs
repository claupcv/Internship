using System;
using System.Threading;

namespace HelloWorld
{
    using System.Collections.Generic;

    class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child tread starts");

            int sleepFor = 5000;
            Console.WriteLine("Child thread pause for {0} sec", sleepFor / 1000);
            Thread.Sleep(sleepFor);
            Console.WriteLine("Child thread resumes");
        }

        public static void ThreadTest()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        public static void ThreadTimer()
        {
            Timer thTimer = new Timer(Run,10,1,3000);
            Timer thTimer2 = new Timer(Run2, 10, 1,5000);
        }
        static void Run(object args)
        {
            Console.WriteLine("Time : " + DateTime.Now.ToLongTimeString());
        }
        static void Run2(object args)
        {
            Console.WriteLine("Timer =========: " + DateTime.Now.ToLongTimeString());
        }

        //testing lock statement
        static readonly object objectTest = new object();
        static Queue<int> test= new Queue<int>(); 
        static void LockTest()
        {
            //lock allows only 1 tread at a time to run
            //with no lock the program will run all threads at the same time
            lock (objectTest)
            {
                Thread.Sleep(1000);
                Console.WriteLine(Environment.TickCount);
            }
        }

        public static void MainLockTest()
        {
            // Create ten new threads.
            for (int i = 0; i < 10; i++)
            {
                ThreadStart startThread = new ThreadStart(LockTest);
                new Thread(startThread).Start();
            }
            Console.WriteLine("finished");
        }

    }
    
}
