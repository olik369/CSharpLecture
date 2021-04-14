using System;
using System.Collections.Generic;
using static System.Console;

/*
namespace chp16.ReadonlyStruct
{
    readonly struct Transaction
    {
        public Transaction(string from, string to, int amount)
        {
            transactionId = Guid.NewGuid();
            this.from = from;
            this.to = to;
            this.amount = amount;
        }

        public readonly Guid transactionId;
        public readonly string from;
        public readonly string to;
        public readonly int amount;
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction("Alice", "Bob", 100));
            transactions.Add(new Transaction("Alice", "Charlie", 50));
            transactions.Add(new Transaction("Bob", "Charlie", 20));
            transactions.Add(new Transaction("Dave", "Alice", 40));

            int revenue = 0;
            int expense = 0;
            foreach(var t in transactions)
            {
                if (t.from == "Alice")
                    revenue += t.amount;
                else if (t.to == "Alice")
                    expense += t.amount;
            }

            WriteLine($"Alice`s profit : {revenue - expense}");
        }
    }
}
 */

namespace chp16.ReadonlyStruct
{
    readonly struct RGBColor
    {
        //구조체가 readonly 이면 모든 필드값은 readonly로
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public RGBColor(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RGBColor Red = new RGBColor(255, 0, 0);
            //Red.G = 100;
        }
    }
}