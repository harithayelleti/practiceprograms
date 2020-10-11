using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous
{
    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate string QuickDelegate(string str);
    public delegate void Addnums2Delegate(int x, float y, double z);
    public delegate void GreetingsDelegate(string str);
    
    class Program
    {
        
        static void Main(string[] args)
        {
            MultiplynumsDelegate obj = delegate (int x, int y)
            {
                return (x * y);
            };
            double result1 = obj.Invoke(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);


            QuickDelegate p = delegate (string name1)
            {
                return "Hello" + name1;
            };
            string name = p.Invoke("Yelleti");
            Console.WriteLine(name);

            Addnums2Delegate obj2 = delegate (int x, float y, double z)
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type

            GreetingsDelegate w = delegate (string wish)
            {
                Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
            };
            w.Invoke("wish you ");
            Console.ReadLine();



        }
    }
}
