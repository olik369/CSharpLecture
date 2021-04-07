using System;
using static System.Console;

namespace chp09.ForEach
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (var e in arr)
            {
                WriteLine(e);
            }
        }
    }
}
