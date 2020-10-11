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
        static bool IsValid(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z0-9]*$");
        }
        static void Main(string[] args)
        {

            // Step 1: create new Regex.
            Regex regex = new Regex(@"\D+");



            // Step 2: call Match on Regex instance.
            Match match1 = regex.Match("harithaharitha");

            // Step 3: test for Success.
            if (match1.Success)
            {
                Console.WriteLine("MATCH VALUE: " + match1.Value);
                // Test the strings with the IsValid method.
                Console.WriteLine(IsValid("NetFrameWork123"));
                Console.WriteLine(IsValid("NetFrameWork"));
                Console.WriteLine(IsValid(":-)))"));
            }


            // Replace 2 or more digit pattern with a string.
            Regex regex1 = new Regex(@"\D+");
            string result = regex.Replace("cat and Dog", "789");
            Console.WriteLine("The replacement of cat and dog is is {0}", result);


            string test = "/bird/cat/";
            // Version 1: use lazy (or non-greedy) metacharacter.
            var result1 = Regex.Match(test, "^/.*?/");
            if (result1.Success)
            {
                Console.WriteLine("The non greedy value is" + ": " + "NON-GREEDY: {0}", result1.Value);
            }
            // Version 2: default Regex.
            var result2 = Regex.Match(test, "^/.*/");
            if (result2.Success)
            {
                Console.WriteLine("The greedy value is" + ":" + "GREEDY:     {0}", result2.Value);
            }


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


            /*this is the example for regex by using ismatch with start and ennd for metacharcaters*/
            string sync = "xxyy";

            // Match the start of a string.
            string text = "hari";
            //Match the start of the string
            if (Regex.IsMatch(text, ("ha|ri")))
            {
                Console.WriteLine("Pattern match,where string is starting with" + " " + text);
            }

            // Match the end of a string.
            /*if (Regex.IsMatch(test, "yy$"))
            {
                Console.WriteLine("END MATCHES");
            }*/

            /*this is the example for regex without using instance of regex*/
            // Part 1: the input string.
            string input = "/content/alternate-1.aspx";

            // Part 2: call Regex.Match.
            Match god = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
                RegexOptions.IgnoreCase);

            // Part 3: check the Match for Success.
            if (god.Success)
            {
                // Part 4: get the Group value and display it.
                string key = god.Groups[1].Value;
                Console.WriteLine(key);
                Console.ReadKey();

            }
        }
    }
}
