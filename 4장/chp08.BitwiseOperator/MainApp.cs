using System;
using static System.Console;

namespace chp08.BitwiseOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 9;  // 1001
            int b = 10; // 1010

            WriteLine($"{a} & {b} : {a & b}");  // 1000 = 8
            WriteLine($"{a} | {b} : {a | b}");  // 1011 = 11
            WriteLine($"{a} ^ {b} : {a ^ b}");  // 0011 = 3

            int c = 255;    // 1111_1111
            WriteLine("~{0} (0x{0:X8}) : {1} (0x{1:X8})", c, ~c);   //~c = 1111_1111_0000_0000 = -256
            WriteLine($"{-c:B}");
        }
    }
}
