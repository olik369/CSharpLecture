using System;
using static System.Console;

//프로퍼티와 생성자
namespace chp03.ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name
        {
            get;
            set;
        }

        public DateTime Birthday
        {
            get;
            set;
        }

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
            //디폴트생성자로 선언하고 바로 원하는 값으로 초기화
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };

            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
        }
    }
}
