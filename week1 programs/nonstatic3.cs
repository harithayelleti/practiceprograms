using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public delegate void numsDelegate(int a, int b);//Defined the delegate
    public delegate void stringsDelegate(string str);//Defined the delegate

    class nonstatic1
    {
        public static void Addnums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        
        public static void divnums(int e, int f)
        {
            Console.WriteLine(e + f);
        }
        public static void sync(string name)
        {
            Console.WriteLine("Sync started!!!!!!");
        }
        public static void async(string name1)
        {
            Console.WriteLine(name1 + " " + "async exited!!!!!!");
        }

        static void Main(string[] args)
        {
            numsDelegate p = new numsDelegate(Addnums);
            
            numsDelegate v = new numsDelegate(divnums);
            stringsDelegate g = new stringsDelegate(sync);
            stringsDelegate w = new stringsDelegate(async);




            p.Invoke(100, 50);
            
            v.Invoke(800, 9000);
            g.Invoke("There");
            w.Invoke("The");

            Console.ReadLine();

        }
    }
}

