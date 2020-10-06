using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace greedy
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "/bird/cat/";
            // Version 1: use lazy (or non-greedy) metacharacter.
            var result1 = Regex.Match(test, "^/.*?/");
            if (result1.Success)
            {
                Console.WriteLine("The non greedy value is"+": " + "NON-GREEDY: {0}", result1.Value);
            }
            // Version 2: default Regex.
            var result2 = Regex.Match(test, "^/.*/");
            if (result2.Success)
            {
                Console.WriteLine("The greedy value is" + ":" + "GREEDY:     {0}", result2.Value);
            }
            Console.ReadKey();
        }
    }
}
