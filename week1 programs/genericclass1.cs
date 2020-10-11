using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericclassprac
{
    
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
            Console.WriteLine("listening to class or:" + this.matter);
        }
        public void read()
        {
            Console.WriteLine("listening or just dumbly writing :" + this.matter);
        }
    }

    class genericclass1
    {
        static void Main(string[] args)
        {
            //to use the generic Type example with an integer/string type parameter
            //Instatiating the class example//create an object
            listening<string> result = new listening<string>("C#programming");
            listening<string> result1 = new listening<string>(".netProgramming");
            listening<int> result2 = new listening<int>(12345);
            listening<int> result3 = new listening<int>(78978);
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
