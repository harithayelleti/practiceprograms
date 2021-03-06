﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdelegate1
{
    public delegate void MyDelegate(string msg); // declare a delegate
    class Program
    {
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            // set target method
            MyDelegate del = new MyDelegate(MethodA);
            // or 
            MyDelegate del1 = MethodA;
            // or set lambda expression 
            MyDelegate del2 = (string msg) => Console.WriteLine(msg);
            del.Invoke("Hello World!");
            del("Hello World!");
            Console.ReadKey();
        }
    }
}
