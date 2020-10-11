using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{

    public delegate int MultiplynumsDelegate(int x, int y);
    public delegate void GreetingsDelegate(string str);
    public delegate bool CheckLengthDelegate(String str);
    class delegatesexm
    {

         
        //Method with return value
        public static int Multiplynums(int x, int y)
    {
        return (x * y);
    }

    

    //method without return value
    public static void Wishes(string wish)
    {
        Console.WriteLine(wish + " " + "Happy Birthday!!!!!!");
    }


    public static bool CheckLength(string name)
    {
        //check the string whose length is greater than 4 should print true else false;
        if (name.Length > 4)
            return true;
        return false;
    }
    static void Main(string[] args)
    {



        MultiplynumsDelegate obj = new MultiplynumsDelegate(Multiplynums);
        double result1 = obj.Invoke(10, 20);//New variable to store the value -return type
        Console.WriteLine(result1);
        

        

        GreetingsDelegate w = new GreetingsDelegate(Wishes);
        w.Invoke("happy grduation ");


        CheckLengthDelegate obj1 = new CheckLengthDelegate(CheckLength);//New variable to store the value -return type

        bool check = obj1.Invoke("dhronacharya");
        Console.WriteLine(check);
        

        Console.ReadLine();



    }
}
}

