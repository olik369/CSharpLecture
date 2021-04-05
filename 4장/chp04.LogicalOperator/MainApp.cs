using System;
using static System.Console;

namespace chp04.LogicalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Testing && ...");
            WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");    //true
            WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");    //false
            WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");  //false
            WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");  //false

            WriteLine("\nTesting || ...");
            WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");    //true
            WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");    //true
            WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");  //false
            WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");  //true

            WriteLine("\nTesting !...");
            WriteLine($"!True : {!true}");      //false
            WriteLine($"!False : {!false}");    //true
        }
    }
}
