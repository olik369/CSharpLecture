using System;
using static System.Console;

namespace chp06.ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        //this() [this생성자는 생성자한테만 쓸수있음]
        public MyClass()
        {
            this.a = 5425;
            WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            WriteLine($"MyClass({b})");
        }

        public MyClass(int b,int c) : this(b)
        {
            this.c = c;
            WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields()
        {
            WriteLine($"a:{a},b:{b},c:{c}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
