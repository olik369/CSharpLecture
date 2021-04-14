using System;
using static System.Console;

namespace chp11.MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            WriteLine("Derived.MyMethod()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}
