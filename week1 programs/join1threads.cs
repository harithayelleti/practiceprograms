using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join_threads
{
    class Program
    {
        
        static void Sync()
        {
            Console.WriteLine("4-2 results released");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Happy to anounce" + i);
            }
            Console.WriteLine("I am Graduated");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Demonstartion on Join Method in Multithreading");
            Console.WriteLine("Main Thread started");
            //Binded the method with the method object
            
           
            Thread T = new Thread(Sync);
            T.Start();
            T.Join();

            Console.WriteLine("Main thread is exited");
            Console.ReadKey();

        }
    }
}
