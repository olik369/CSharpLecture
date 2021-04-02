using System;
using static System.Console;
namespace StringInterpolation
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /*
            Effective C#의 내용중
            int a = 5;
            int b = 13;
            string str1, str2;

            //.Net3.5
            str1 = string.Format("{0} + {1} = {2}", a, b, a + b);
            WriteLine(str1);

            //.Net 4.x
            str2 = $"{a} + {b} = {a + b}";
            WriteLine(str2);
            // 위 두개의 차이점은 index에 바로 변수가 들어갈 수 있음    
             */
            
            //StringFormat 과 비교해서 보기
            string name = "김튼튼";
            int age = 23;
            WriteLine($"{name,-10}, {age:D3}");
            name = "박날씬";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");

            name = "이비실";
            age = 17;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
        }
    }
}
