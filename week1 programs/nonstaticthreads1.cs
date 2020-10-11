using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Nonstaticthreads1
{
    class nonstaticthreads1
    {
        public string sync(string name)
        {
            return "synchronisation is started";
        }
        public int ou(int f)
        {
            for (f = 0; f < 15; f++)
            {
                if (f == 10)
                {
                    Console.WriteLine("It is sleeping");

                    Thread.Sleep(10000);
                }
                Console.WriteLine("The position :" + f);
            }
            return f;
        }
        public string async(string str)
        {
            if (str.Length > 6)
            {
                Console.WriteLine("It is sleeping for 5 seconds");

                Thread.Sleep(5000);
            }
            return "It is started";
        }

        static void Main(string[] args)
        {

            nonstaticthreads1 n = new nonstaticthreads1();
            string s = n.sync("Hari");
            Console.WriteLine(s);
            int j = n.ou(5);
            Console.WriteLine(j);
            string a = n.async("Thread programming");
            Console.WriteLine(a);

            Console.WriteLine("Main thread executed all the threads");
            Console.ReadLine();


        }
    }
}
