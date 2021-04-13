using System;
using static System.Console;

namespace chp08_1.Inheritance_Sealed_
{
    sealed class Base
    {
        public string Name;
        public Base(string Name)
        {
            this.Name = Name;
            WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            WriteLine($"{Name}.BaseMethod()");
        }
    }

    //당연히 상속 안됨! sealed로 된 클래스는 상속할수 없음
    //class Derived : Base
    //{
    //    public Derived(string Name) : base(Name)
    //    {
    //        WriteLine($"{this.Name}.Derived()");
    //    }

    //    ~Derived()
    //    {
    //        WriteLine($"{this.Name}.~Derived()");
    //    }

    //    public void DerivedMethod()
    //    {
    //        WriteLine($"{Name}.DerivedMethod()");
    //    }
    //}

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            //Derived b = new Derived("b");
            //b.BaseMethod();
            //b.DerivedMethod();
        }
    }
}
