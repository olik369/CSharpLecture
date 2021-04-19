using System;
using static System.Console;

namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}
namespace chp04.InitOnly
{
    class Transaction
    {
        //init은 readonly와 같은 의미로 쓸수 있음!!
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
            Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
            Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
            Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

            WriteLine(tr1);
            WriteLine(tr2);
            WriteLine(tr3);
        }
    }
}
