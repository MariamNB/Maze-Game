using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Milk : IMazeObject
    {
        public char icon
        {
            get => 'M';
        }

        public int X { get; set; }
        public int Y { get; set; }

        public Milk(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
