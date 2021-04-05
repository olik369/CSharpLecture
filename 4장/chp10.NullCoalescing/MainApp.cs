﻿using System;
using static System.Console;

namespace chp10.NullCoalescing
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }
    }
}
