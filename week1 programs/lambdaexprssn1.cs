using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class lambdaexpression
    {
        public delegate void Addnums2Delegate(int x, float y, double z);
        public delegate void GreetingsDelegate(string str);
        static void Main(string[] Args)
        {
            //List to store numbers

            List<int> numbers = new List<int>() { 12, 24, 36, 48, 567, 72, 78, 96, 32, 120, 567, 678 };
            Console.WriteLine("The elements of List are:");
            //using Lambda expressions to calculate sum of each number in the list(z =>z + z+ z)
            var sum = numbers.Select(z => z + z + z);
            foreach (var num in numbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
            //using Lambda expressions to calculate square of each number in the list(x => x*x)

            Addnums2Delegate obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type

            GreetingsDelegate w = (wish) =>
            {
                Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
            };
            Console.ReadKey();
            //using Lambda expressions to calculate cube of each number in the list(x => x*x*x)
            var qube = numbers.Select(y => y * y * y);

            foreach (var number in qube)
            {
                Console.WriteLine("{0}", number);
            }
            Console.ReadKey();



        }
    }
}
