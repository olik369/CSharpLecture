using System;
using static System.Console;

namespace chp05.ConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            //위의 코드를 if~else를 쓰면 이렇게 길어짐
            //int a = 10;
            //if (a % 2 == 0)
            //    WriteLine("짝수");
            //else
            //    WriteLine("홀수");

            WriteLine(result);
        }
    }
}
