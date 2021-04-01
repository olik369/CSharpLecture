using System;

namespace CTS
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //공용형식 시스템
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);

            /*
             * C#에서는         (C#)        (C++)
             * System.Int64     long        __int64       (이것도 기억해두기)
             * System.Int32     int         int 또는 long (이것은 기억해두기)
             * System.Int16     short       short
             * System.SByte     sbyte       char
             * System.Byte      byte        unsigned char
             * System.Char      char        wchar_t       (이것도 기억해두기)
             */
        }
    }
}
