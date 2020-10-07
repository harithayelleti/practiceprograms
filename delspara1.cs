using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateprac2
{
    public delegate void MyDelegate(string msg); //declaring a delegate
    public delegate void MultiplyDelegate(int a, int b);


    class staticpara
    {
       class Multiplication
        {
     public static void Multiply(string result)
        {
            Console.WriteLine("The result of Multiplication is: " + result);
        }
    }

    //class Multiplicationnum
    //{
        public  void Multiplynums(int a, int b)
        {
                Console.WriteLine(a + b);
        }
    //}
    static void Main(string[] args)
        {
            staticpara d = new staticpara();

        MyDelegate del = Multiplication.Multiply;
        InvokeDelegate(del);

      MultiplyDelegate del1= new MultiplyDelegate(d.Multiplynums);
        
            del1(100, 50);
            d.Multiplynums(100, 50);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
        InvokeDelegate(del);
    }

    static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
    {
        del("Multiply");
            Console.ReadKey();
        }
        
        //Console.ReadKey();
}

        }
    


    

