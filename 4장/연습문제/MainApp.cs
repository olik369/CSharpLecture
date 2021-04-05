using System;
using static System.Console;

namespace 연습문제
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Write("원하는 삼각형의 높이를 입력하세요 : ");
            var height = int.Parse(ReadLine());

            if (height < 0)
            {
                WriteLine("높이는 양의 정수값만 입력 가능합니다!");
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Write("*");
                    }
                    WriteLine();
                }
            }
        }
    }
}
