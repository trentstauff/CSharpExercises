using System;
using System.Collections;

namespace WorkingWithInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Print();

            stack.Pop();
            stack.Pop();

            stack.Print();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Print();

            stack.Clear();

        }
    }
}
