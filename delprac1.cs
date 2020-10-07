using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateprac2
{
    public delegate void Delegateprac(string msg);
    public delegate string Delegateprac1(string msg);

    class delprac
    {
        public class wishem
        {
            public static string Wishme(string message)
            {
                Console.WriteLine("Hello" + message+ "Happy Birthday");
                return message;
            }
        }

        public class Birthday
        {
            public static void Hari(string message)
            {
                Console.WriteLine("Hello" + message + "Hari" + message);
            }
        }
        static void Main(string[] args)
        {
            delprac proc = new delprac();
            Delegateprac1 del = wishem.Wishme;
            del("Hello this is hari");

            Delegateprac del1 = Birthday.Hari;
            del("Save the day");

            Delegateprac del2 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Smile");
            Console.ReadKey();

        }
    }

}
    

