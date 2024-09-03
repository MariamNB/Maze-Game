using System;
using System.Collections.Specialized;

namespace Maze_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = GameFactory.CreateGame();
            game.Run();

        }
    }
}