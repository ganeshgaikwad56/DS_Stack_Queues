using System;
using System.Collections.Generic;
namespace DataStructureGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> stack = new Stack<int>();

            //stack.Push(70);
            //stack.Push(30);
            //stack.Push(56);

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("*********After pop********");
            ////poping
            //stack.Pop();
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            ////peek operation
            //Console.WriteLine("****After Peek*****");
            //stack.Peek();
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            ////poping

            //Console.WriteLine("****After Peek*****");
            //stack.Pop();
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //stack.Pop();
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            ////Count

            //stack.Peek();
            //foreach(int i in stack)
            //{
            //    Console.WriteLine(i);
            //}



            //Enqueue adding int
            Queue<int> vs = new Queue<int>();
            vs.Enqueue(56);
            vs.Enqueue(30);
            vs.Enqueue(70);

            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******after Dequeue*****");

            vs.Dequeue();

            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("******after Dequeue*****");

            vs.Dequeue();

            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("******after Dequeue*****");

            vs.Dequeue();

            foreach (int i in vs)
            {
                Console.WriteLine(i);
            }
        }
    }
}