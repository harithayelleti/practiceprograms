﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //add()- to enter or inert the elements to the dictionaary.
            dictionary.Add(1, "Banglore");
            dictionary.Add(2, "Mumbai");
            dictionary.Add(3, "Pune");
            dictionary.Add(4, "Hyderabad");
            dictionary.Add(5, "chennai");
            dictionary.Add(6, "Delhi");
            dictionary.Add(7, "Kolatta");
            //Another way of assisgning value to the key by index value
            dictionary[7] = "Ahmedabad";
            dictionary[8] = "Gujarat";
            dictionary[9] = "Noida";
            dictionary[10] = "Thiruvatapuram";

            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("The Elements of Dictionary are:" + check.Key + " : " + check.Value);
                Console.ReadKey();
            }
            //count()
            dictionary.Remove(1);
            dictionary.Remove(2);
            dictionary.Remove(3);
            dictionary.Remove(4);
            dictionary.Remove(5);
            dictionary.Remove(6);

            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(1));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(2));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(3));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(4));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(5));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(6));


            dictionary.Remove(7);
            dictionary.Remove(8);
            dictionary.Remove(9);
            dictionary.Remove(10);
            dictionary.Remove(11);
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(7));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(8));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(9));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(10));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(11));




            Console.WriteLine("Number of elements present in the dictionary" + dictionary.Count());
            Console.ReadKey();




            Console.ReadKey();

        }
    }
}
