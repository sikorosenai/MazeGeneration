using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Generation_3
{
    class BinaryTree : MazeAlgorithms
    {
        Random rnd = new Random();

        public void Generate(cell[,] Board, MazeSetup setup, int mazeHeight, int mazeLength)
        {
            this.Board = Board;
            for (int y = 0; y < mazeHeight; y++) // check cells specificied states below.
            {
                for (int x = 0; x < mazeLength; x++)
                {
                    var dir = NorthOrEast(x, y, mazeLength, mazeHeight);

                    var r = GetRandomDirection(x, y);
                    if (dir != Direction.None)
                    {
                        // add makeDoor method here
                        MakeDoor(x, y, dir);
                    }
                }
            }
        }


        private Direction NorthOrEast(int x, int y, int mazeWidth, int mazeHeight)
        {
            if (x == (mazeWidth - 1))
            {
                if (y == 0)
                {
                    return Direction.None;
                }
                return Direction.North;
            }
            else if (y == 0)
            {
                if (x == (mazeWidth - 1))
                {
                    return Direction.None;
                }
                return Direction.East;
            }

            int northOrEast = rnd.Next(2);
            if (northOrEast == 0)
            {
                return Direction.North;
     
            }
            
            return Direction.East;
        }
        
    }
}
