using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_property
{
    class Person
    {
        private string name;// Field - variable Field

        public string Name //Class property

        {
            get { return name; }
            set { name = value; }
        }

        private double mobileno;// Field - variable Field

        public double Mobileno //Class property

        {
            get { return mobileno; }
            set { mobileno = value; }
        }

        private string address;// Field - variable Field

        public string Address //Class property

        {
            get { return address; }
            set { address = value; }
        }




    }
    //Main Method -- Driver code -- Execution  

    class Program
    {
        static void Main(string[] args)
        {


            //instaiating the class Person
            Person inst = new Person();
            //Syntax of creating an object class name "Object-name" = new(Operator) class name();
            //Invoke the methods - Get and Set ==> Accurate result  
            //Assign the values to the class Property
            Console.WriteLine("The details are:");
            inst.Name = "Haritha";
            inst.Mobileno = Convert.ToDouble(999932746);
            inst.Address = "visakhaptnam";

            Console.WriteLine(inst.Name);
            Console.WriteLine(inst.Mobileno);
            Console.WriteLine(inst.Address);

            Console.ReadKey();
        }
    }
}