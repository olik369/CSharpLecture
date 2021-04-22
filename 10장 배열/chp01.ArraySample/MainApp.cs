using System;
using static System.Console;

namespace chp01.ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

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
