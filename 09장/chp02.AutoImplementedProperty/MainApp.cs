using System;
using static System.Console;

namespace chp02.AutoImplementedProperty
{
    class BirthdayInfo
    {
        //public string Name; 이 생략되게 쓴것임
        public string Name { get; set; } = "Unknown";   //C# 7.0부터는 선언과 동시에 초기화 가능
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");

            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
        }
    }
}
