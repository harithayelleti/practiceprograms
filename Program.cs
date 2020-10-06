using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Generic_class
{
    class sleeping<T>
    {
        T bored;

        public sleeping(T hari)
        {
            this.bored = hari;
        }
        public void beactive()
        {
            Console.WriteLine("The passed to the intitializer is :" + this.bored);
        }
    }


        class example<T>
    {
        T data;//Type parameter
               //A method for class Example

        public example(T check)//check is been assigned to Type parameter
        {
            this.data = check;
        }
        public void Write()
        {
            Console.WriteLine("The passed to the intitializer is :" + this.data);
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
                //to use the generic Type example with an integer/string type parameter
                //Instatiating the class example//create an object

                example<int> result = new example<int>(100);
                example<string> result1 = new example<string>("hari");
            sleeping<int> res = new sleeping<int>(120);
            sleeping<string> res1 = new sleeping<string>("Iamnotsleeping");

                //Invoking the method Write() with object created result and result1
                result.Write();
                result1.Write();

            res.beactive();
            res1.beactive();

            Console.ReadKey();
            }
            
        }
    }

