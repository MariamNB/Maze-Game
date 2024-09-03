using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    public class Maze
    {
        private readonly int _row;
        private readonly int _column;
        private char [,] _form;
        private readonly List<IMazeObject> _mazeObjects;

        public Maze(int row, int column)
        {
            _row = row;
            _column = column;
            _form = new char[_row, _column];
            _mazeObjects = new List<IMazeObject>();
            InitializeMaze();

        }

        private void InitializeMaze()
        {
            var mazeBuilder = new MazeBuilder(_row, _column);
            _form = mazeBuilder.GenerateMazeLayout();
        }

        public void AddMazeObjects(IMazeObject mazeObject)
        {
            _mazeObjects.Add(mazeObject);
        }


        public void Draw()
        {
            Console.Clear();
            for (int i = 0; i < _row; i++)
            {
                for (int j = 0; j < _column; j++)
                {
                    bool not_found = true;
                    foreach (var obj in _mazeObjects)
                    {
                        if (i == obj.X && j == obj.Y)
                        {
                            not_found = false;
                            Console.Write(obj.icon);
                        }   
                    }
                    if(not_found){
                        Console.Write(_form[i, j]);
                    }
                }
                Console.WriteLine();
            }
            
        }

        public bool CanMoveTo(int x, int y)
        {
             return x >= 0 && x < _row && y >= 0 && y < _column && _form[x, y] == ' ';
        }


    }
}
