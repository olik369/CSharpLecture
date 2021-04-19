using System;
using static System.Console;

namespace chp06.AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            WriteLine("AbstractBase.PublicMethodA()");
        }

        //추상 메소드(반드시 구현해야됨)
        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}
