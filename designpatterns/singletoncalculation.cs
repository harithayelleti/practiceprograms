using System;

namespace ConsoleAppds
{
    class Program
    {
        public sealed class Calculate
        {
            private Calculate() { } //PRivate Constructor

            private static Calculate instance = null;

            public static Calculate Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Calculate();
                    }
                    return instance;
                }

            }
            public double valueOne { get; set; }
            public double valueTwo { get; set; }
            public double Addition()
            {
                return valueOne + valueTwo;
            }
            public double Subtraction()
            {
                return valueOne + valueTwo;
            }
            public double Multiplication()
            {
                return valueOne + valueTwo;
            }
            public double Divison()
            {
                return valueOne + valueTwo;
            }

        }

        static void Main(string[] args)
        { 
            Console.WriteLine("Hello World!");
            Calculate.Instance.valueOne = 10.0;
            Calculate.Instance.valueTwo = 10.573;


            Console.WriteLine("Addition"+Calculate.Instance.Addition());
            Console.WriteLine("Subtraction" + Calculate.Instance.Subtraction());
            Console.WriteLine("Multiplication" + Calculate.Instance.Multiplication());
            Console.WriteLine("Divison" + Calculate.Instance.Divison());
            Console.ReadKey();
        }
    }
}
