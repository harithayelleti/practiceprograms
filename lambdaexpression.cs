using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class lambdaexpression
    {
        static void Main(string[] Args)
        {
            //List to store numbers

            List<int> numbers = new List<int>() { 12, 24, 36, 48, 567, 72, 78, 96, 32, 120,567,678 };
            Console.WriteLine("The elements of List are:");
            //using Lambda expressions to calculate sum of each number in the list(z =>z + z+ z)
            var sum = numbers.Select(z => z + z + z);
            foreach (var num in numbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
            //using Lambda expressions to calculate square of each number in the list(x => x*x)

            var square = numbers.Select(x => x * x);

            foreach (var value in square)
            {
                Console.WriteLine("{0}", value);
            }
            Console.ReadKey();
            //using Lambda expressions to calculate cube of each number in the list(x => x*x*x)
            var qube = numbers.Select(y => y * y *y);

            foreach (var number in qube)
            {
                Console.WriteLine("{0}",number);
            }
            Console.ReadKey();



        }
    }
}
