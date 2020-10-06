using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace genericconstraints1
{
    
    //we have created a generic class with the type prameter and assigned the constraint Exception

    class Csharp<T> where T : IDisposable
    {
        public void data()
        {
            Console.WriteLine("It gives the data table");
        }

    }
    //we have created a generic class with the type prameter and assigned the constraint struct

    class dotNet<T> where T : Exception
    {
        public void test()
        {
            Console.WriteLine("It gives the Exception ");
        }
    }



    //Refrence type with constructor

    class write<p> where p : class, new()//take any value as type parameter //new always checks with the class
    {
        public void check()
        {
            Console.WriteLine("It gives constraints example");
        }

    }




    class constraints
    {
        static void Main(string[] args)
        {
            Csharp<DataTable> programming = new Csharp<DataTable>();//To store the data with class ruby
            dotNet<Exception> net = new dotNet<Exception>();
            write<constraints> main = new write<constraints>();

            programming.data();
            net.test();
            main.check();

            Console.ReadKey();

        }
    }
}

