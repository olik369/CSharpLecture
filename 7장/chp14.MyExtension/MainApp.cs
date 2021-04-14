using System;
using static System.Console;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt,int exponent)
        {
            int result = myInt;
            for(int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }

            return result;
        }
    }
}

namespace chp14.MyExtension
{
    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine($"{3}^2 : {3.Square()}");
            WriteLine($"{3}^{4} : {3.Power(4)}");
            WriteLine($"{2}^{10} : {2.Power(10)}");
        }
    }
}
