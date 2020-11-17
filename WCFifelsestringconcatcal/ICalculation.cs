using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Createservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculation" in both code and config file together.
    [ServiceContract]
    public interface ICalculation
    {
        //[OperationContract]
        //void DoWork();
        [OperationContract]
        int sum(int num1, int num2);

        [OperationContract]
        int Subtract(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        int Divison(int num1, int num2);
    }
}
//Use a data contract to composite types to service operations.
[DataContract] //Declare and Assign the variables
public class CompositeType
{
    bool boolvalue = true; //Boolean 
    String stringvalue = "Hello World";
    [DataMember]
    public bool BoolValue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }
    [DataMember]
    public String StringlValue
    {
        get { return stringvalue; }
        set { stringvalue = value; }
    }
}

