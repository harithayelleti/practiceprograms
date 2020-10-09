
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        public string Thread1()
        {
            return "thread1 started";
        }
        public string Thread2()
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("the thread2 is sleeping");

                    Thread.Sleep(10000);
                }
                Console.WriteLine("the thread is at the position :" + i);
            }
            return "Thread2 exist";
        }
        public string Thread3(string str)
        {
           if ( str.Length > 5)
            {
                Console.WriteLine("the thread is sleeping for 5 seconds");

                Thread.Sleep(5000);
            }
            return "thread3 started";
        }

        static void Main(string[] args)
        {

            Program n = new Program();
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread1());
            });
            T1.Start();
            T1.Join();
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread2());

            });
            T2.Start();
            T2.Join();
            Thread T3 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread3("Threadprogramming"));

            });
            T3.Start();
            T3.Join();
            Console.WriteLine("Main thread executed all the threads");
            Console.ReadLine();

                
        }
    }
}
