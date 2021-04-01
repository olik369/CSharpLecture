using System;

namespace Nullable
{
    class MainApp
    {
        /*
         * Nullable 형식 ('널러블')
         * Null 을 가질 수 없는 데이터 타입을 Null을 가질 수 있는 타입으로 선언한다.
         * 참조타입은 이미 Null 체크가 가능하다
         */
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}
