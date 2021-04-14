using System;
using static System.Console;

namespace chp15.Structure
{
    struct Vector3D
    {
        public int X;
        public int Y;
        public int Z;

        public Vector3D(int X,int Y,int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {
            return string.Format($"{X}, {Y}, {Z}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Vector3D v3d1;
            v3d1.X = 10;
            v3d1.Y = 20;
            v3d1.Z = 40;

            WriteLine(v3d1.ToString());

            Vector3D v3d2 = new Vector3D(100, 200, 300);
            Vector3D v3d3 = v3d2;
            v3d3.Z = 400;

            WriteLine(v3d2.ToString());
            WriteLine(v3d3.ToString());
        }
    }
}
