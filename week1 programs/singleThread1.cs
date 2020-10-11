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
        public string sync()
        {
            return "Ready to start";
        }
        public string mul()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("It is sleeping is sleeping");

                    Thread.Sleep(10000);
                }
                Console.WriteLine("Never slept is at the position :" + i);
            }
            return "Thread2 exist";
        }
      

        static void Main(string[] args)
        {

            Program n = new Program();
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(n.sync());
            });
            T1.Start();
            T1.Join();
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(n.mul());

            });
            T2.Start();
            T2.Join();
            
            Console.WriteLine("Main thread executed all the threads");
            Console.ReadLine();


        }
    }
}
