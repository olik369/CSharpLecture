using System;
using static System.Console;

namespace chp11.Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write("계속할까요?(예/아니오) : ");
                string answer = ReadLine();

                if (answer == "아니오")
                    break;
            }

        }
    }
}
