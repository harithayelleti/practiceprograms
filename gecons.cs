using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace genericconstraints
{

    //we have created a generic class with the type prameter and assigned the constraint Exception

    class Ruby<T> where T : IDisposable
    {
        public void test1()
        {
            Console.WriteLine("Its an Example of data constraints ");
        }
    
}
    //we have created a generic class with the type prameter and assigned the constraint struct

    class C<T> where T : struct
    {
        public void test2()
        {
            Console.WriteLine("Its an Example of data constraints ");
        }
    }



    //Refrence type with constructor

    class read<v> where v : class, new()//take any value as type parameter //new always checks with the class
    {
    public void test3()
    {
        Console.WriteLine("Its an Example of data constraints ");
    }

    }




    class gecons
    {
        static void Main(string[] args)
        {
            Ruby<DataTable> ruby =  new Ruby<DataTable>();//To store the data with class ruby
            C<int> java = new C<int>();
            read<gecons> main = new read<gecons>();

            ruby.test1();
            java.test2();
            main.test3();

            Console.ReadKey();

        }
    }
}
