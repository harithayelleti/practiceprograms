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
            Queue<int> i = new Queue<int>();//
            i.Enqueue(2);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:"+i.Contains(2));//contains
            i.Enqueue(4);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(4));//contains
            i.Enqueue(6);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(6));//contains
            i.Enqueue(8);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(8));//contains
            i.Enqueue(10);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(10));//contains
            i.Enqueue(12);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(12));//contains
            i.Enqueue(14);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(14));//contains
            i.Enqueue(16);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(16));//contains
            i.Enqueue(18);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(18));//contains
            i.Enqueue(20);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" +  i.Contains(20));//contains

            foreach (int x in i)
            {
                Console.WriteLine("The elements of Queue are:" + x);
                Console.ReadKey();
            }

            //Dequeue of 6 elements

            Console.WriteLine("The elements after applying dequue:" + i.Dequeue());//dequeue of last element stack collection
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(2));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(4));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(6));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(8));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(10));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(12));
            //
            i.Enqueue(20);
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue:" + i.Contains(22));//contains

            //dequeue of 5 elements
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(14));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(16));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(18));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(20));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(22));
            // enqueue of elements
            i.Enqueue(24);
            i.Enqueue(26);
            i.Enqueue(28);
            i.Enqueue(30);
            i.Enqueue(32);
            i.Enqueue(34);
            i.Enqueue(36);
            i.Enqueue(38);
            i.Enqueue(40);
            i.Enqueue(42);    
            i.Enqueue(44);
            
            // Dequeue of 4 elements
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(24));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(26));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(28));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(30));
            //dequeue of 3 elements
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(32));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(34));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(36));
            //dequeue of 2 elements
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(38));
            Console.WriteLine("The elements after applying dequeue:" + i.Dequeue());
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count
            Console.WriteLine("The current elements exists in the queue" + i.Contains(40));

            Console.WriteLine("The elements of queue  in peek is:" + i.Peek());//to find the top/peek of my stack
            
            Console.WriteLine("The current elements prsesnt in the queue:" + i.Count());//count

            foreach (int x in i)
            {
                Console.WriteLine("The elements of left data in stack after applying dequeue method is:" + x);//to know left over elements in the stack after pop operation
            }
            Console.ReadKey();
        }
    }
}
    

        
    

