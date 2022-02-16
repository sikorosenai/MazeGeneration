using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Generation_3
{
    class Masking : MazeAlgorithms
    {
        public int count = 0;
        Stack<Coord> history = new Stack<Coord>();
        Random rnd = new Random();
        public void Generate(cell[,] Board, MazeSetup setup, int mazeHeight, int mazeLength)
        {
            this.Board = Board;
            int xPos = setup.xPos;
            int yPos = setup.yPos;
            for(int i = 0; i< mazeHeight; i++)
            {
                Board[i, i].valid = false;
            }
            
        }
        public struct Coord
        {
            public int x;
            public int y;

            public Coord(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
