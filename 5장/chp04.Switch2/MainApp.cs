using System;
using static System.Console;

namespace chp04.Switch2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = ReadLine();
            if (int.TryParse(s, out int out_i)) //TryParse 예외처리를 할 수 있음
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;
            //데이터 형식을 스위치문으로 받을 수 있음
            switch (obj)
            {
                case int i:
                    WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f:
                    WriteLine($"{f}는 float 형식입니다.");
                    break;
                default:
                    Write($"{obj}(은)는 모르는 형식입니다.");
                    break;
            }
            //출력 전용 매개변수 out , ref
            //TryParse의 결과값은 bool타입임!
        }
    }
}
