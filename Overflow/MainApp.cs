//using System;

//namespace _2021_03_30
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            byte a = 255;       //byte에서 255 = 1111_1111임
//            sbyte b = (sbyte)a; //sbyte(short byte)에서 -1 = 1111_1111 (2의 보수법을 통해 -1을 구함)

//            Console.WriteLine(a);
//            Console.WriteLine(b);
//        }
//    }
//}

using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue; //uint 의 최대값 4294967295
            // MaxValue라는 명령어가 없을때는 최대값을 할당할때 uint a = -1로 해서 최대값으로 만듬!
            // 굉장히 센스있는 코딩

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);

            byte b = byte.MinValue; //b = 0 (0000_0000)

            Console.WriteLine(b);

            b = (byte)(b - 1);      //b = 0000_0000 + (1111_1111) = 255
                                    //why? -1 => 0000_0001 => 1111_1110 => 1111_1111
                                    //양수 1을 음수 1로 만드는것

            Console.WriteLine(b);
        }
    }
}