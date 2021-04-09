using System;
using static System.Console;

namespace chp09.NamedParameter
{
    class MainApp
    {
        static void PrintProfile(string name, string phone)
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name: "박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("김동호",phone:"010-567-5678");
        }
    }
}
