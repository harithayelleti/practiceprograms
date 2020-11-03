using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mysingleton obj = Mysingleton.Haritha;
            Mysingleton o = Mysingleton.Vamsi;
            mytext b = mytext.ex;
            obj.Sleeping();
            o.DoSomething();
            b.Awake();

        }
        public class mytext //signature for singleton
        {
            private static mytext haritha = new mytext(); //signature for singleton
            private mytext() { } //Private constructor //Method for instance and method name should be of class  name whereas instance name can be of any kind


            public static mytext ex
            {
                get { return haritha; }
            }
            public void Awake() //Method checking instance working or not
            {
                Console.WriteLine("I am going to Awake");
                Console.ReadKey();
            }

        }

        public class Mysingleton //Mysingleton class==>This class has only one instance 
    {
        private static Mysingleton instance = new Mysingleton(); //Single instance created for the class:Mysingleton
        private Mysingleton() //Method instance to the class mysingleton
        { }
        public static Mysingleton Haritha //Trying to find whether instance is created or not
        {
            
            get { return instance; }
        }
        public static Mysingleton Vamsi //Trying to find whether instance is created or not
        {
            get { return instance; }
        }

        public void Sleeping() //Method checking instance working or not
        {
            Console.WriteLine("I am going to sleep");
        }
        public void DoSomething() //Method checking instance working or not
        {
            Console.WriteLine("I am goingto sleep!!!Do Something to stay focuesd");
            Console.ReadLine();


        }
        
    }

    
        
    }
}


