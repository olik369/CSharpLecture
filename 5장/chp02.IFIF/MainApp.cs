using System;
using static System.Console;

namespace chp02.IFIF
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("숫자를 입력하세요 : ");

            string input = ReadLine();
            int number = Convert.ToInt32(input);

            //그러나 중첩 if문은 정말 보기 안좋은 코딩이 될 확률이 너무 높음
            if (number > 0)
            {
                if (number % 2 == 0)
                    WriteLine("0보다 큰 짝수");
                else
                    WriteLine("0보다 큰 홀수");
            }
            else
            {
                WriteLine("0보다 작거나 같은 수");
            }
        }
    }
}
