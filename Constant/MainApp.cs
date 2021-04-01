using System;

namespace Constant
{
    class MainApp
    {
        //유니티 DOTS 2019 NDC, 쓰레드

        //Effect C# const 보다는 readonly가 좋다
        //그리고 보통 상수는 지역변수로 절대 안씀, 전역변수로 사용함
        static void Main(string[] args)
        {
            const int MAX_INT = 1234567890;     //상수라 대문자로 씀
            const int MIN_INT = -1234567890;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}
