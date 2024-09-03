using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Maze_Game
{
    public interface IMazeObject
    {
        char icon { get; }

        int X { get; set; }
        int Y { get; set; }
    }
}
