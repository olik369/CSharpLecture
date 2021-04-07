using System;
using static System.Console;

namespace chp07.DoWhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                WriteLine($"a) i : {i--}"); //10~1출력
            }
            while (i > 0);

            do
            {
                WriteLine($"b) i : {i--}");  //0출력
            }
            while (i > 0);
        }
    }
}
