using System;

namespace XnaSanityCheck
{
    static class Program
    {
        [STAThread]          // WinForms 线程模型
        static void Main(string[] args)
        {
            using (var game = new Game1())
                game.Run();
        }
    }
}