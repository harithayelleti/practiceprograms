using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdelegate1
{
    public delegate void MyDelegate(string msg); // declare a delegate
    class delegateprac
    {
        static void Delete(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            delegateprac pr = new delegateprac();
            // set target method
            MyDelegate d = new MyDelegate(Delete);
            // or 
            MyDelegate d1 = Delete;
            // or set lambda expression 
            MyDelegate d2 = (string msg) => Console.WriteLine(msg);
            d.Invoke("Hello Programmers!");
            d("This is c# Programming!");
            Console.ReadKey();
        }
    }
}
