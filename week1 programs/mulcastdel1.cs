using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicastdel
{
    public delegate void MyDelegate(string msg); //declaring a delegate
    class multicastdel
    {
        class sync1
        {
            public static void Me(string message)
            {
                Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
            }
        }

        class sync2
        {
            public static void MeB(string message)
            {
                Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
            }
        }
        static void Main(string[] args)
        {
            multicastdel m = new multicastdel();
            MyDelegate delm = sync1.Me;
            MyDelegate deln = sync2.MeB;

            MyDelegate del = delm + deln; // combines del1 + del2
            del("Hello World");

            MyDelegate deli = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del += deli; // combines del1 + del2 + del3
            del("Hello World");

            del = del - delm; // removes del2
            del("Hello World");

            del -= delm; // removes del1
            del("Hello World");
            Console.ReadLine();
        }
    }
}
