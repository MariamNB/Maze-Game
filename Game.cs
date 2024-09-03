using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Maze_Game
{
    public class Game
    {
        private readonly Maze _maze;
        private readonly Player _player;
        private readonly Milk _milk;
        private readonly MazeGuide _mazeGide;


        public Game(Maze maze, Player player, Milk milk)
        {   
            _maze = maze;
            _player = player;
            _milk = milk;

            _maze.AddMazeObjects(player);
            _maze.AddMazeObjects(milk);

            _mazeGide = new MazeGuide();
            _mazeGide.DisplayWelcomeMessage();
        }

        public void Run()
        {
            _maze.Draw();
            while (true)
            {
                var userInput = Console.ReadKey();
                var key = userInput.Key;

                if (key == ConsoleKey.UpArrow)
                {
                    MovePlayer(-1, 0);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    MovePlayer(1, 0);
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    MovePlayer(0, -1);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    MovePlayer(0, 1);
                }
                _maze.Draw();
                if (_player.X == _milk.X && _player.Y == _milk.Y)
                {
                    _mazeGide.DisplayEndMessage();
                    break;
                }
            }
        }

        private void MovePlayer(int dx, int dy)
        {
            int newX = _player.X + dx;
            int newY = _player.Y + dy;

            if (_maze.CanMoveTo(newX, newY))
            {
                _player.X = newX;
                _player.Y = newY;
            }
        }

    }
}
