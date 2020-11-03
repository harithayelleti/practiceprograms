using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterpatterns1
{
    class adapter1
    {
        class Sleeping// The 'Target' class
        {
            public void Request()
            {
                Console.WriteLine("I am going to sleep now!!!!!!!!");
            }
            class DoSomething// The 'Adaptee' class
            {
                public void SpecificRequest()
                {
                    Console.WriteLine("I am going to sleep now!!!!!!!!!Can u do something to make me awake");
                }
            }
            class Adapter : Sleeping// The 'Adapter' class
            {
                private DoSomething adaptee = new DoSomething();
                public void Request1()
                {
                    adaptee.SpecificRequest();
                }
            }

            class MainApp
            {
                static void Main(string[] args)
                {
                    // Create adapter and place a request
                    Sleeping obj = new Adapter();
                    Adapter o = new Adapter();
                    obj.Request();
                    o.Request1();
                    Console.ReadKey();
                }
            }
        }
    }
}


