using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Priorities
{
    class Priorities
    {
        static double sync1, sync2, sync3, sync4;//declare of 2 variables

        public static void DecrementSync()
        {
            while (true)//infiniteloop
                sync1 += 1;

            Console.WriteLine("Priorities are going to start");
           
        }
        public static void DecrementSync1()
        {
            while (true)//infiniteloop
                sync2 += 1;

            Console.WriteLine("Priorities are going to start");

        }
        public static void DecrementSync2()
        {
            while (true)//infiniteloop
                sync3 += 1;

            Console.WriteLine("Priorities are going to start");

        }
        public static void DecrementSync3()
        {
            while (true)//infiniteloop
                sync4 += 1;

            Console.WriteLine("Priorities are going to start");

        }
        static void Main(string[] args)
        {
            Thread T1 = new Thread(DecrementSync);
            Thread T2 = new Thread(DecrementSync1);//Invoke the method Decrementsync2
            Thread T3 = new Thread(DecrementSync2);
            Thread T4 = new Thread(DecrementSync3);

            Console.WriteLine("Main threAD IS GOING TO SLEEP FOR 5 SECONDS");
            Thread.Sleep(10000);
            Console.WriteLine("Main thread is going to start up");
            T1.Priority = ThreadPriority.Highest;
            T2.Priority = ThreadPriority.Lowest;
            T3.Priority = ThreadPriority.AboveNormal;
            T4.Priority = ThreadPriority.BelowNormal;
            T1.Start();T2.Start(); T3.Start(); T4.Start();
            T1.Abort();T2.Abort(); T3.Abort(); T4.Abort();
            T1.Join();T2.Join(); T3.Join(); T4.Join();
            Console.WriteLine("sync is:"+sync1);
            Console.WriteLine("sync1 is:" + sync2);
            Console.WriteLine("sync2 is:" + sync3);
            Console.WriteLine("sync3 is:" + sync4);

            Console.ReadKey();

        }
    }
}
