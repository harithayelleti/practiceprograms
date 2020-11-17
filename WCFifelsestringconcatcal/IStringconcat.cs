using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServicestringconcat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStringconcat" in both code and config file together.
    [ServiceContract]
    public interface IStringconcat
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string Concat(string a, string b);
    }
}
