using System;

namespace BaseProject
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {

            using var game = new Caved_in();

            game.Run();
        }
    }
}
