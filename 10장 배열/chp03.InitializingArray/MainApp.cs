using System;
using static System.Console;

namespace chp03.InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //배열을 초기화하는 방법 3가지 소개
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            string[] array3 = { "안녕", "Hello", "Halo" };

            WriteLine("array1...");
            foreach (var greeting in array1)
                WriteLine($" {greeting}");
            
            WriteLine("\narray2...");
            foreach (var greeting in array2)
                WriteLine($" {greeting}");
            
            WriteLine("\narray3...");
            foreach (var greeting in array3)
                WriteLine($" {greeting}");
        }
    }
}
