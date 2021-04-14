using System;
using static System.Console;

namespace chp10.Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            WriteLine("Double-Barrel Cannons Armed");
            WriteLine("Micro-Rocket Launcher Aremd");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
