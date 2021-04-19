using System;
using static System.Console;

namespace chp01.Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        //읽기전용 프로퍼티임!!!(프로퍼티를 응용한것임,아니면 private으로 설정해서 막아놓음)
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
            //name필드를 Name으로 public처럼 쓸 수 있음!!
            birth.Name = "서현";
            birth.Birthday = new DateTime(1991, 6, 28);

            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
        }
    }
}