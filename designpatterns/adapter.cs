﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapterpatterns1
{
    class adapter
    {
        
        class Target// The 'Target' class
        {
            public virtual void Request()
            {
                Console.WriteLine("Called Target Request()");
            }
        }
        class Adaptee// The 'Adaptee' class
        {
            public void SpecificRequest()
            {
                Console.WriteLine("Called SpecificRequest()");
            }
        }
        class Adapter : Target// The 'Adapter' class
        {
            private Adaptee adaptee = new Adaptee();
            public override void Request()
            {
                adaptee.SpecificRequest();
            }
        }
        
        class MainApp
        {
            static void Main(string[] args)
            {
                // Create adapter and place a request
                Target obj = new Adapter();
                Adapter o = new Adapter();
                obj.Request();
                o.Request();
                Console.ReadKey();
            }
        } 
    }
}

