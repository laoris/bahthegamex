using System;

namespace BahTheGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            /// System.Console.WriteLine("Hello World.");
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
}

