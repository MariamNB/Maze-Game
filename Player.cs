using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net;

namespace Maze_Game
{
    public class Player : IMazeObject
    {

        public char icon
        {
            get => 'H';
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Player(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
