using System;
using static System.Console;

namespace chp02.Return
{
    class MainApp
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string Phone)
        {
            if(name == "")
            {
                WriteLine("이름을 입력해주세요");
                return;
            }
            WriteLine($"Name:{name}, Phone:{Phone}");
        }
        static void Main(string[] args)
        {
            WriteLine($"10번째 피보나치 수 : {Fibonacci(10)}");

            PrintProfile("", "123-4567");
            PrintProfile("아텐츠", "456-7890");
        }
    }
}
