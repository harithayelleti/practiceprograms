using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //add()- to enter or inert the elements to the dictionaary.
            dictionary.Add(1,"Banglore");
            dictionary.Add(2, "Mumbai");
            dictionary.Add(3, "Pune");
            dictionary.Add(4, "Hyderabad");
            dictionary.Add(5, "chennai");
            dictionary.Add(6, "Delhi");
            dictionary.Add(7, "Kolatta");
           
            /*foreach(KeyValuePair < int,string> check in dictionary)
            {
                Console.WriteLine("The Elements of Dictionary are:" + check.Key + " : " + check.Value);
                Console.ReadKey();
            }*/
            //count()

            
            /*Another way of assisgning value to the key by index value
            /
            */
            dictionary[7] = "Ahmedabad";
            dictionary[8] = "Gujarat";
            dictionary[9] = "Noida";
            dictionary[10] = "Thiruvatapuram";
            foreach(KeyValuePair < int,string> check in dictionary)
            {
                Console.WriteLine("The Elements of Dictionary are:" + check.Key + " : " + check.Value);
                Console.ReadKey();
            }
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

            dictionary[11] = "Banglore";
            dictionary[12] = "Mumbai";
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


            dictionary[13] = "Pune";
            dictionary.Add(14, "Hyderabad");
            dictionary.Add(15, "chennai");
            dictionary.Add(16, "Delhi");
            dictionary.Add(17, "Kolatta");
            dictionary[18] = "Ahmedabad";
            dictionary[19] = "Gujarat";
            dictionary[20] = "Noida";
            dictionary[21] = "Thiruvatapuram";
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(11));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(12));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(13));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(14));


            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(15));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(16));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(17));

            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(18));
            Console.WriteLine("The Elements left in the Dictionary after removed are:" + dictionary.Remove(19));


            Console.WriteLine("Number of elements present in the dictionary" + dictionary.Count());
            Console.ReadKey();




            Console.ReadKey();

        }
    }
}
