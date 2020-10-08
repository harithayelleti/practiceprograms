using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda6m
{
    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate string QuickDelegate(string str);
    public delegate void Addnums2Delegate(int x, float y, double z);
    public delegate void GreetingsDelegate(string str);
    public delegate bool CheckLengthDelegate(String str);
    class Program
    {
        static void Main(string[] args)
        {
            MultiplynumsDelegate obj = (x,y) =>
            {
                return (x * y);
            };
            double result1 = obj.Invoke(10, 20);//New variable to store the value -return type
            Console.WriteLine(result1);


            QuickDelegate p = (name1) =>
            {
                return "Hello" + name1;
            };
            string name = p.Invoke("Yelleti");
            Console.WriteLine(name);

            Addnums2Delegate obj2 = (x,y,z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(10, 3.142f, 123456.7809738);//Non return type

            GreetingsDelegate w = (wish) =>
            {
                Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
            };
            w.Invoke("wish you ");


            CheckLengthDelegate obj3 = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name.Length > 4)
                    return true;
                return false;
            };


            bool check = obj3.Invoke("Haritha");
            Console.WriteLine(check);

            CheckLengthDelegate o = (name1) =>
            {
                //check the string whose length is greater than 4 should print true else false;
                if (name1.Length < 10)
                    return true;
                return false;
            };//New variable to store the value -return type

            bool ch = o.Invoke("Maredapaaly");
            Console.WriteLine(ch);


            Console.ReadLine();



        }
    }
    }

