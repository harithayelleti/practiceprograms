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
        string Sync()
        {
            return "Sync is started";
        }

        public string Multi()
        {
            return "Multi Thread is started";
        }

        public string Thread()
        {
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread3 is started at the position" + i);

            }
            return "Thread  got exist";
        }
        static void Main(string[] args)
        {
            Multithread n = new Multithread();

            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(n.Sync());
            });
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(n.Multi());

            });
            Thread T3 = new Thread(delegate ()
            {
                Console.WriteLine(n.Thread());

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



