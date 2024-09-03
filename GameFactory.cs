using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public static class GameFactory
    {
        public static Game CreateGame()
        {
            var player = new Player(2, 50);
            var milk = new Milk(28, 109);

            var maze = new Maze(31, 110);

            var game = new Game(maze, player, milk);

            return game;
        }
    }
}
