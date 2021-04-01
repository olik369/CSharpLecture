using System;

namespace Enum
{
    class MainApp
    {
        //MFC, WinAPI MessageBox
        //UI.Canvas
        enum DialogResult { 
            YES,        //기본값은 YES = 0 
            NO, 
            CANCEL, 
            CONFIRM, 
            OK
        }
        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
