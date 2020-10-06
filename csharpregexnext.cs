using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregex3
{
    class csharpregex5
    {
        static void Main(string[] args)
        {
            /*this is the example for regex by using nextmatch for metacharcaters*/

            string value = "4 AND 5";

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
