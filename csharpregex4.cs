﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregex3
{
    class csharpregex3
    {
        static void Main(string[] args)
        {
            /*this is the example for regex by using ismatch with start and ennd for metacharcaters*/
            string test = "xxyy";

            // Match the start of a string.
            if (Regex.IsMatch(test, "^xx"))
            {
                Console.WriteLine("START MATCHES");
            }

            // Match the end of a string.
            if (Regex.IsMatch(test, "yy$"))
            {
                Console.WriteLine("END MATCHES");
            }
            Console.ReadKey();
        }
    }
}