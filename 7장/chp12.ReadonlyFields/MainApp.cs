using System;
using static System.Console;

namespace chp12.ReadonlyFields
{
    class Configuration
    {
        readonly int min;
        readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
        }

        public void ChangeMax(int newMax)
        {
            //max = newMax;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(100, 10);
        }
    }
}
