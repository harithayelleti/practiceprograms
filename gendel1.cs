using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericdel
{
    public delegate T multiply<T>(T m1, T m2); // generic delegate

    class gendel
    {
        public static int Multiply(int pro1, int pro2)
        {
            return pro1 + pro2;
        }

        public static string Concat(string name1, string name2)
        {
            return name1 + name2;
        }
        static void Main(string[] args)
        {
            multiply<int> result = Multiply;
            Console.WriteLine(result(400, 600));

            multiply<string> value = Concat;
            Console.WriteLine(value("This is ", "Result!!"));
            Console.ReadLine();
        }
    }
}
