using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_int
{
    class queue_int
    {
        static void Main(string[] args)
        {
            Queue<string> i = new Queue<string>();//
            i.Enqueue("bracelets");

            i.Enqueue("earrings");

            i.Enqueue("anklets");

            i.Enqueue("rings");
            i.Enqueue("chains");

            i.Enqueue("blackbeads);


            i.Enqueue("vadanam");

            foreach (string x in i)
            {
                Console.WriteLine("The elements of Queue are:" + x);
                Console.ReadKey();
            }
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("bracelets"));//contains
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("earrings"));//contains
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("anklets"));//contains
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("rings"));//contains
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("chains"));//contains
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("blackbeads"));//contais 
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("vadanam"));//contains

            //Dequeue of 6 elements

            Console.WriteLine("The elements after applying dequue:" + i.Dequeue());//dequeue of last element stack collection
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains("bracelets"));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains("earrings"));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains("anklets"));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains("rings"));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains("chains"));

            //
            i.Enqueue("jhumkas");
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains("jhumkas"));//contains

            Console.WriteLine("The elements of queue  in peek is:" + i.Peek());//to find the top/peek of my stack

            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count

            foreach (string x in i)
            {
                Console.WriteLine("The elements of left data in stack after applying dequeue method is:" + x);//to know left over elements in the queue after pop operation
            }
            Console.ReadKey();
        }
    }
}




