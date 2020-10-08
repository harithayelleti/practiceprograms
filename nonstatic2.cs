using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonstatic2
{
    class nonstatic2
    {
        public delegate void numsDelegate(int a, int b);//Defined the delegate
        public delegate void GreetingsDelegate(string str);//Defined the delegate

        class nonstatic1
        {
            

            static void Main(string[] args)
            {
                numsDelegate p = delegate (int a, int b)
                {
                    Console.WriteLine(a + b);
                };
                numsDelegate m = delegate(int c, int d)
                { 

                    Console.WriteLine(c * d);
                 };
            numsDelegate v = delegate(int e, int f)
                {
                    Console.WriteLine(e + f);
                };

                GreetingsDelegate g = delegate (string name)
                {
                    Console.WriteLine("Hello Hi!!!!!!" + name);

                };
                GreetingsDelegate w = delegate (string wish)
                {
                    Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
                };



                p.Invoke(100, 50);
                m.Invoke(500, 600);
                v.Invoke(800, 9000);
                g.Invoke("Hari");
                w.Invoke("wish you ");

                Console.ReadLine();

            }
        }
    }

}

