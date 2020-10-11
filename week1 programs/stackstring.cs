using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> MyStack = new Stack<string>();//
            MyStack.Push("jeans");
            MyStack.Push("skirt");
            MyStack.Push("shirts");
            MyStack.Push("kurtas");
            MyStack.Push("Pyjamas");

            foreach (string stack in MyStack)
            {
                Console.WriteLine("The elements of MyStack are:" + stack);
                Console.ReadKey();
            }

            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());//pop of last element stack collection
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());
            Console.WriteLine("The elements after applying pop:" + MyStack.Pop());

            Console.WriteLine("The elements of MyStack is:" + MyStack.Peek());//to find the top/peek of my stack
            Console.WriteLine(MyStack.Contains("jeans"));//contains
            Console.WriteLine(MyStack.Contains("shirts"));//contains
            Console.WriteLine(MyStack.Contains("skirts"));//contains
            Console.WriteLine(MyStack.Contains("Pyjamas"));

            Console.WriteLine("The current elements present in the queue" + MyStack.Count());//count

            foreach (string stack in MyStack)
            {
                Console.WriteLine("The elements of left data in stack after applying pop method is:" + stack);//to know left over elements in the stack after pop operation
            }
            Console.ReadKey();
        }
    }
}
