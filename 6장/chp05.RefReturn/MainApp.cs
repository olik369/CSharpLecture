using System;
using static System.Console;

namespace chp05.RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            WriteLine($"Price :{price}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();    //ref 가격에는 carrot가격의 주소값을 줌
            int normal_local_price = carrot.GetPrice();         //normal 가격에는 carrot가격의 값만 줌

            carrot.PrintPrice();                                    //carrot.price = 100
            WriteLine($"Ref Local Price :{ref_local_price}");       //ref = 100
            WriteLine($"Normal Local Price :{normal_local_price}"); //nor = 100

            ref_local_price = 200;  //carrot.price와 ref_local_price는 연결되어있다고 볼수 있어서 같이 변경됨

            carrot.PrintPrice();                                    //carrot.price = 200
            WriteLine($"Local Price :{ref_local_price}");           //ref = 200
            WriteLine($"Normal Local Price :{normal_local_price}"); //nor = 100
        }
    }
}
