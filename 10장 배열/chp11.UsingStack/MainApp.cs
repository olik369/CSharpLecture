using System;
using static System.Console;
using System.Collections;

namespace chp11.UsingStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                WriteLine(stack.Pop());
        }
    }
}
