using System;
using static System.Console;

namespace chp10.PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format($"{serial++:d5}"); }
        }

        //추상메소드이기 때문에 구현이 안되어있는것과 마찬가지임
        abstract public DateTime ProductDate
        {
            get;
            set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2010, 1, 10)
            };

            WriteLine($"Product : {product_1.SerialID}, Product Date : {product_1.ProductDate}");

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2010, 2, 3)
            };
            WriteLine($"Product : {product_2.SerialID}, Product Date : {product_2.ProductDate}");
        }
    }
}
