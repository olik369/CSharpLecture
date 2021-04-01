using System;

namespace Decimal
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float   a = 3.1111_2222_3333_4444_5555_6666_7777_88f;
            double  b = 3.1111_2222_3333_4444_5555_6666_7777_88;
            decimal c = 3.1111_2222_3333_4444_5555_6666_7777_88m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
