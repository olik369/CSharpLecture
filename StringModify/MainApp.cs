using System;
using static System.Console;
namespace StringModify
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 명시적인 코딩
            string a = string.Empty;    //string을 초기화할때

            //이 두개 용법 읽히기
            //a.Equals("abcdef") == true;
            //a.Contains("ab") == ture;

            // image000.png
            // image001.png
            // image002.png

            WriteLine("Lower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "ABC".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, "Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't Love you.".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
        }
    }
}
