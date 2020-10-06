using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregexreplace
{
    class regexreplace
    {
        static void Main(string[] args)
        {
            // Replace 2 or more digit pattern with a string.
            Regex regex = new Regex(@"\d+");
            string result = regex.Replace("cat 123 456", "bird");
            Console.WriteLine("RESULT: {0}", result);
            Console.ReadKey();
        
    }
    }
}
