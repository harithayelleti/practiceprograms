using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace parse
{
    class Parse
    {
        static void Main(string[] args)
        {
          //The program matches and parses a number

            string input = "c# 100 Trainig";
            Match match = Regex.Match(input, @"\d+");
            if (match.Success)
            {
                int.TryParse(match.Value, out int number);
                // Show that we have the numbers.
                Console.WriteLine("NUMBERS: {0}, {1}", number, number + 1);
            }
            Console.ReadKey();
        }
    }
}
