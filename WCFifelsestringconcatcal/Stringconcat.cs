using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Stringconcat" in both code and config file together.
    public class Stringconcat : IStringconcat
    {
        public void DoWork()
        {
        }
        public string Concat(string a, string b)
        {
            return a + b;
        }
    }
}
