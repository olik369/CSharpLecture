using System;
using static System.Console;

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}

namespace chp06.WithExp
{
    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10}->{To,-10}:${Amount}";
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            //with를 이용해서 DeepCopy를 할 수 있음
            RTransaction tr2 = tr1 with { To = "Charlie" };
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine(tr3);
        }
    }
}
