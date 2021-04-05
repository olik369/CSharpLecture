using System;

namespace chp2.IncDecOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); //10
            Console.WriteLine(++a); //12

            Console.WriteLine(a--); //12
            Console.WriteLine(--a); //10

            //StringConcatenate 내용
            string result = "123" + "456";  //"123" 가비지 생김
            Console.WriteLine(result);

            result = "Hello" + " " + "World!";  //마찬가지로 가비지 생김
            Console.WriteLine(result);

            //string? str = default;
            
            //string.IsNullOrEmpty
        }
    }
}
