using System;
using System.Collections;
using static System.Console;

namespace chp09.UsingList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            WriteLine("ArrayList...");
            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            WriteLine("\nRemoveAt(2)...\n");
            list.RemoveAt(2);

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            WriteLine("\nInsert(2,2)...\n");
            list.Insert(2, 2);

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();

            WriteLine("\nAdd(str)...\n");
            list.Add("abc");
            list.Add("def");

            foreach (object obj in list)
                Write($"{obj} ");
            WriteLine();
        }
    }
}
