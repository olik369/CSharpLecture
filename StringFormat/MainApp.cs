using System;
using static System.Console;

namespace StringFormat
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //생산성
            {
                string format = "이름 : {0}, 이메일주소 : {1}";
                string[] arr = new string[3];

                arr[0] = string.Format(format, "BTS", "seanlab@gamil.com");
                arr[1] = string.Format(format, "나훈아", "junpark@jmail.com");
                arr[2] = string.Format(format, "장상범", "beompark@bmail.com");

                foreach (var s in arr)
                {
                    WriteLine(s);
                }
            }

            //숫자에 콤마 표시하기
            {
                string s = string.Format("{0:N0}", 12345); //알파벳 N과 숫자0
                WriteLine(s);
            }

            //날짜와 시간 표시하기
            {
                string s = string.Format("{0:yyyy-MM-dd hh:mm:ss}", System.DateTime.Now);
                WriteLine(s);

                string[] cultureNames = new string[] { "en-US", "ko-KR", "zh-CN", "ja-JP" };
                foreach(string cultureName in cultureNames)
                {
                    var ci = new System.Globalization.CultureInfo(cultureName);
                    s = string.Format(ci, "{0:D} {0:T}", System.DateTime.Now);
                    WriteLine(s);
                }
            }
        }
    }
}
