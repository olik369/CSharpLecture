using System;
using static System.Console;

namespace chp05.Record
{
    //record 형식임!(새로운 형식)
    //불변 참조 형식(참조타입을 값타입처럼?? 쓰고 한번 선언후 내부를 변경 할 수 없음)
    //참조형식에서?? Deep Copy를 쓰기위해서
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
            RTransaction tr1 = new RTransaction
            {
                From = "Alice",
                To = "Bob",
                Amount = 100
            };
            
            RTransaction tr2 = new RTransaction
            {
                From = "Alice",
                To = "Charlie",
                Amount = 100
            };

            WriteLine(tr1);
            WriteLine(tr2);

        }
    }
}
