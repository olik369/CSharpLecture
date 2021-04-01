using System;

namespace UsingVar
{
    class MainApp
    {
        // 전역변수 선언지역(정확한 표현은 아님)
        static void Main(string[] args)
        {
            //지역변수 선언지역(정확한 표현은 아님)
            // Effect C# : 지역변수를 사용할때는 var를 사용해라!
            // 절대로 var는 자료형이 아님 컴파일러가 알아서 데이터를 이해하고 적절한 데이터 타입으로 치환함
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello ,World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            //var는 배열도 받아버림 ㅋㅋ
            var d = new int[] { 10, 20, 30 };
            Console.Write("Type: {0}, Value: ", d.GetType());
            foreach (var e in d)    //e는 int배열안에 있는 요소값(?)
                Console.Write("{0} ", e);

            Console.WriteLine();
        }
    }
}
