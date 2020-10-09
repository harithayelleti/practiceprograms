using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithread
{
    class Multithread
    {
         string Thread1()
        {
            return "Thread1 is started";
        }

        public string Thread2()
        {

            for (int i = 1; i < 15; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("Thread 2 is sleeping for 10 seconds");
                    Thread.Sleep(10000);
                }


                Console.WriteLine("Thread2 is started after 10 seconds at the position" + i);

            }
            return "Thread got exit";
        }

        public  string  Thread3()
        {
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread3 is started at the position" + i);

            }
            return "Thread 3 got exist";
        }
        static void Main(string[] args)
        {
            Multithread n = new Multithread();

            Thread T1 = new Thread(delegate ()
            {
            Console.WriteLine(n.Thread1());
        });
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread2());

            });
            Thread T3 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread3());

            });
            //Thread T4 = new Thread(Thread4);
            //One main thread and 3 child threads

            T1.Start();
            T2.Start();
            T3.Start();

            Console.ReadKey();

        }
    }
}
    

