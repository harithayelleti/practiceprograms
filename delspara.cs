using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateprac2
{
    public delegate void MyDelegate(string msg); //declaring a delegate

    class delprac1
    {
        class ClassA
        {
     public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
    static void Main(string[] args)
        {
            delprac1 d = new delprac1();

        MyDelegate del = ClassA.MethodA;
        InvokeDelegate(del);

        del = ClassB.MethodB;
        InvokeDelegate(del);

        del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        InvokeDelegate(del);
    }

    static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
    {
        del("Hello World");
            Console.ReadKey();
        }
        //Console.ReadKey();
}

        }
    


    

