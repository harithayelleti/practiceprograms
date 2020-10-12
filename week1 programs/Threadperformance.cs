using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

//Performance = task Performed by the time taken
//Single thread is good or multi thread is good !!!

namespace performances
{
    class ThreadPerformances
    {
        public static void Increment1()
        {
            long count = 0;
            for (int i = 0; i <= 10000; i++)
            {
                count++;
                //Console.WriteLine("Number of counts" + count);
            }
            Console.WriteLine("Number of counts" + count);
            Console.ReadLine();
        }
        public static void Increment2()
        {
            long count = 0;
            for (int i = 0; i <= 100000; i++)
            {
                count++;
                //Console.WriteLine("Number of counts" + count);
            }
            Console.WriteLine("Number of counts" + count);
            Console.ReadLine();
        }
        //inbuilt method stopwatch
        //inbuilt namespace diagnostics 

        static void Main(string[] args)
        {
            ThreadPerformances p = new ThreadPerformances();
            Stopwatch st = new Stopwatch();//created method for stopwatch
            st.Start();
            Console.WriteLine("Stopwatch started working");
            // Console.ReadKey();
            /*Thread o = new Thread();
            Thread o = new Thread();*/
            Thread T1 = new Thread(Increment1);
            Thread T2 = new Thread(Increment2);

            T1.Start(); T2.Start();
            T1.Join(); T2.Join();
            st.Stop();

            Console.WriteLine("Stopwatch stopped");
            Console.WriteLine("The time taken to convert the 100000 seconds is" + st.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
