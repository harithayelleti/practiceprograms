using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_act_prec
{
   
    class Program
    {
        static void Main(string[] args)
        {
 
            Func<string, string> p = name1 => "Hello" + name1;

            string name = p.Invoke("Yelleti");
            Console.WriteLine(name);

            Action<int, float, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z);

            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type
            Predicate<string> o = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name1.Length < 10)
                    return true;
                return false;
            };//New variable to store the value -return type

            bool ch = o.Invoke("Maredapaaly");
            Console.WriteLine(ch);


            Console.ReadLine();


        }
    }
}

