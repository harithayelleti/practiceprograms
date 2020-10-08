﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public delegate void numsDelegate(int a,int b);//Defined the delegate
    public delegate void GreetingsDelegate(string str);//Defined the delegate

    class nonstatic1
    {
        public static void Addnums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void multinums(int c, int d)
        {
            Console.WriteLine(c * d);
        }
        public static void divnums(int e, int f)
        {
            Console.WriteLine(e + f);
        }
        public static void Greetings(string name)
        {
            Console.WriteLine("Hello Hi!!!!!!");
        }
        public static void Wishes(string wish)
        {
            Console.WriteLine(wish + " " +"Happy Birthday!!!!!!");
        }

        static void Main(string[] args)
        {
            numsDelegate p = new numsDelegate(Addnums);
            numsDelegate m = new numsDelegate(multinums);
            numsDelegate v = new numsDelegate(divnums);
            GreetingsDelegate g = new GreetingsDelegate(Greetings);
            GreetingsDelegate w = new GreetingsDelegate(Wishes);




            p.Invoke(100, 50);
            m.Invoke(500, 600);
            v.Invoke(800, 9000);
            g.Invoke("Hari");
            w.Invoke("wish you ");

            Console.ReadLine();
            
        }
    }
}
