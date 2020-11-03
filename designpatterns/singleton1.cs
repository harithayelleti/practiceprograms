using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns1
{
    class singleton1
    {
        private static readonly Singleton instance1;

        public class Mysingleton
        {
            //Private Constructor
            private Mysingleton() { }

            private static Mysingleton instance = null; //Instance getting assigned to null
            public static Mysingleton instan
            {
                get
                {
                    if (instance == null) //if instance found true then singleton design pattern will be thread unsafe         
                    {
                        instance = new Mysingleton();
                    }
                    return instance;
                }
            }
            
            public void check()
            {
                Console.WriteLine("If the instance been null the singleton design pattern will be thread unsafe");
            }
        }
        public sealed class Singleton
        {
            //private constructor
            Singleton() { }

            private static readonly object find = new object(); //Find whethe any of instance
            private static Singleton instance = null;
            public static Singleton instance1
            {
                get
                {
                    lock (find) //
                    {
                        if(instance == null)
                        {
                            { instance = new Singleton(); }
                        }
                        return instance;
                    }
                }
            }
            public void worked()
            {
                Console.WriteLine("We have locked to make sure SDp thread safe");
            }
        }
        static void Main(string[] args)
        {
            Mysingleton obj = Mysingleton.instan;
            obj.check();
            Singleton o = singleton1.instance1;
            o.worked();
            Console.ReadLine();
        }
    }
}
