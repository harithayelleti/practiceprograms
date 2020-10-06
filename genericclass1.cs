using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericclassprac
{
    class sleeping<T>
    {
        T bored;//Type parameter
                //A method for class Example
        public sleeping(T hari)//hari is been assigned to Type parameter

        {
            this.bored = hari;
        }
        public void beactive()
        {
            Console.WriteLine("The elements passed to the intitializer is :" + this.bored);
        }

        public void active()
        {
            Console.WriteLine("The elements passed to the intitializer is :" + this.bored);
        }
    }


    class listening<T>
    {
        T matter;//Type parameter
               //A method for class Example

        public listening(T check)//check is been assigned to Type parameter
        {
            this.matter = check;
        }
        public void Write()
        {
            Console.WriteLine("Theelements passed to the intitializer is :" + this.matter);
        }
        public void read()
        {
            Console.WriteLine("Theelements passed to the intitializer is :" + this.matter);
        }
    }

    class genericclass1
    {
        static void Main(string[] args)
        {
            //to use the generic Type example with an integer/string type parameter
            //Instatiating the class example//create an object

            
            sleeping<string> res = new sleeping<string>("class is intersting");
            sleeping<string> res1 = new sleeping<string>("Iamnotsleeping");
            sleeping<int> re = new sleeping<int>(123);
            sleeping<int> re1 = new sleeping<int>(456);

            listening<string> result = new listening<string>("C#programming");
            listening<string> result1 = new listening<string>(".netProgramming");
            listening<string> result2 = new listening<string>("training program");
            listening<string> result3 = new listening<string>("by sachin sir");


            //Invoking the method beactive with object created res and res1


            res.beactive();
            res1.beactive();

            //Invoking the method active with object created re and re1

            re.active();
            re1.active();
            //Invoking the method Write() with object created result and result1

            result.Write();
            result1.Write();

            //Invoking the method read() with object created result2 and result3

            result2.read();
            result3.read();

            Console.ReadKey();
        }

    }
}


