using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_pred_actex
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float,double> obj1 = (x, y) => (x * y);

            double res1 = obj1.Invoke(1100, 24000);
            Console.WriteLine(res1);


            Func<string, string> p = name1 => "Hello" + name1;

            string name = p.Invoke("Yelleti");
            Console.WriteLine(name);

            Action<float, float, float> obj2 = (x, y, z) => Console.WriteLine(x + y + z);

            obj2.Invoke(10.243f, 3.142f, 66742.896f );//Non return type

            Action<string> w = (wish) => Console.WriteLine( "Happy Birthday!!!!!!" + " " + wish +"staybleesed!!!!");

            w.Invoke("Haritha");


            Predicate<int> j = value =>
            {
                
                if ( value > 20808)
                    return true;
                return false;
            };


            bool check = j.Invoke(56790);
            Console.WriteLine(check);

            Predicate<string> o = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name1.Length < 10)
                    return true;
                return false;
            };//New variable to store the value -return type

            bool ch = o.Invoke("Maredapaally");
            Console.WriteLine(ch);


            Console.ReadLine();


        }
    }
}

        }
    }
}
