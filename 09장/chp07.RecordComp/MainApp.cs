using System;
using static System.Console;

namespace chp07.RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10}->{To,-10} : ${Amount}";
        }
    }

    record RTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10}->{To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            WriteLine(trA);
            WriteLine(trB);
            WriteLine($"trA equals to trB : {trA.Equals(trB)}");

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            WriteLine(tr1);
            WriteLine(tr2);
            //참조형식이지만 값형식처럼 Equals 따로 정의 안해도 메소드를 쓸 수 있음
            WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");

        }
    }
}
