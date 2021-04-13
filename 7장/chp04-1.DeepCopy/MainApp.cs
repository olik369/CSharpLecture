using System;
using static System.Console;

namespace chp04_1.DeepCopy
{
    class MyClass : ICloneable
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }

        public object Clone()
        {
            return DeepCopy();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {source.MyField2}");
            }

            WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                //MyClass target = new MyClass();
                //target = source;
                //MyClass target = source.DeepCopy();
                MyClass target = new MyClass();
                target = (MyClass)source.Clone();
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }

        }
    }
}