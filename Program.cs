using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_int
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> MyStack = new Stack<int>();//
            MyStack.Push(2);
            MyStack.Push(4);
            MyStack.Push(6);
            MyStack.Push(8);
            MyStack.Push(10);
            MyStack.Push(12);
            MyStack.Push(14);
            MyStack.Push(16);
            MyStack.Push(18);
            MyStack.Push(20);

            foreach (int stack in MyStack)
            {
                Console.WriteLine("The elements of MyStack are:" + stack);
                Console.ReadKey();
            }

            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());//pop of last element stack collection
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());


            Console.WriteLine("The elements of MyStack is:" + MyStack.Peek());//to find the top/peek of my stack
            foreach (int stack in MyStack)
            { 
            Console.WriteLine("The elements of left data in stack after applying pop method is:" + stack);//to know left over elements in the stack after pop operation
             }
            Console.ReadKey();
        }
    }
}
    

