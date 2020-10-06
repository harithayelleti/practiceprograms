using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace csharpregex1
{
    class csharpregex2
    {
        static void Main(string[] args)
        {

            // Step 1: create new Regex.
            Regex regex = new Regex(@"\D+");
            
            

            // Step 2: call Match on Regex instance.
            Match match = regex.Match("harithaharitha");

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("MATCH VALUE: " + match.Value);
                Console.ReadKey();
            }
        }
    }
}
