using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharplistint
{
    class cshaprlist
    {
        static void Main(string[] args)
        {

            //create an object for list

            //Syntax
            //<DataType variable name = new List<Datatype>();

            var user = new List<int>();
            user.Add(10);
            user.Add(11);
            user.Add(12);
            user.Add(13);
            user.Add(14);

            Console.WriteLine("List created");
            foreach (var list in user)
            {

                Console.WriteLine("The elements of the list are:" + list);
                //Console.ReadKey();

            }
            Console.WriteLine("The elements of the list are:" + user.Remove(13));//remove

            //Another type of intialization in c#lists
            var Mobile = new List<int>() { 48,78,68,88,98,108 };
            foreach (var docker in Mobile)
            {
                Console.WriteLine("The elements of the list are:" + docker);
                //Console.ReadKey();
            }
            //Acessing list elements through by its index
            Console.WriteLine("The elements 1stindex of the list are:" + Mobile[0]);
            Console.WriteLine("The elements 2ndindex of the list are:" + Mobile[1]);
            Console.WriteLine("The elements 3rdindex the list are:" + Mobile[2]);
            Console.WriteLine("The elements 4thindex the list are:" + Mobile[3]);
            //Console.WriteLine("The elements 6thindex the list are:" + Mobile[5]);

            //Insert() ??Keeps 2 arguments to be passed in the method
            Mobile.Insert(6, 38);
            Console.WriteLine("The inserted element 7thindex the list with insert method are:" + Mobile[6]);

            //Contains()??REturns the boolean value = True or False
            Console.WriteLine(Mobile.Contains(48));
            Console.WriteLine(Mobile.Contains(38));
            Console.WriteLine(Mobile.Contains(108));
            Console.WriteLine(Mobile.Contains(28));

            Console.ReadKey();

        }


    }
}
    

