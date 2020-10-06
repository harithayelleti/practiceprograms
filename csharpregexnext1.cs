using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregex3
{
    class csharpregexnext
    {
        static void Main(string[] args)
        {
            /*this is the example for regex by using nextmatch for metacharcaters*/

            string value = "10 and 20 and 30 and 40 crazy 50 beautiful 60 programming 70 is fun 80";

            // Step 1: get first match.
            Match match = Regex.Match(value, @"\d+");
            if (match.Success)
            {
                Console.WriteLine("Pattern Matched and the digits are: " + match.Value);
            }

            // Step 2: get second match.
            match = match.NextMatch();
            if (match.Success)
            {
                Console.WriteLine("The Second Executed and the digits are:" + match.Value);
            }


            Console.ReadKey();
        }
    }
}
