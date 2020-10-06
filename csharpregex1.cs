﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregex1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Step 1: create new Regex.
            Regex regex = new Regex(@"\d+");

            // Step 2: call Match on Regex instance.
            Match match = regex.Match("a55a");

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("MATCH VALUE: " + match.Value);
                Console.ReadKey();
            }
        }
    }
}