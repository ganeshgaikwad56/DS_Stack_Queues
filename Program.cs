using System;
using System.Collections.Generic;
namespace DataStructureGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********After pop********");
            //poping
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            //peek operation
            Console.WriteLine("****After Peek*****");
            stack.Peek();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            //poping

            Console.WriteLine("****After Peek*****");
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            stack.Pop();
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            //Count

            stack.Peek();
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

        }
    }
}