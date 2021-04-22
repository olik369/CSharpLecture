using System;
using static System.Console;

namespace chp02.ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            System.Index last = ^1;

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;    //배열의 마지막과 같음
            //scores[last] = 34;(scores[^1]과 똑같이됨)

            foreach (var score in scores)
                WriteLine(score);

            int sum = 0;
            foreach (var score in scores)
                sum += score;

            int average = sum / scores.Length;

            WriteLine($"Average Score : {average}");
        }
    }
}
