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
    class RecursiveBacktracker : MazeAlgorithms
    {
        public int count = 0;
        Stack<Coord> history = new Stack<Coord>();
        Random rnd = new Random();
        public void Generate(cell[,] Board, MazeSetup setup, int mazeHeight, int mazeLength)
        {
            this.Board = Board;
            int xPos = setup.xPos;
            int yPos = setup.yPos;
            

            List<string> choices = new List<string>();
            Board[xPos, yPos].visited = true;
            history.Push(new Coord(xPos, yPos));

            while (count < mazeHeight * mazeLength)
            {
                List<Direction> validDirections = GetDirections(xPos, yPos);
                GetValidNeighbour(xPos, yPos, ref validDirections);
                Board[xPos, yPos].visited = true;

                if (validDirections.Count == 0)
                {
                    history.Pop();
                    var coord = history.Peek();
                    xPos = coord.x;
                    yPos = coord.y;
                }
                else
                {
                    int choice = rnd.Next(validDirections.Count);
                    MakeDoor(xPos, yPos, validDirections[choice]);
                    MovePos(validDirections, choice, ref xPos, ref yPos);
                    history.Push(new Coord(xPos, yPos));
                }

                validDirections.Clear();

                count = 0;
                for (int i = 0; i < mazeLength; i++)
                {
                    for (int j = 0; j < mazeHeight; j++)
                    {
                        if (Board[i, j].visited == true)
                        {
                            count++;
                        }
                    }
                }
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

        public void GetValidNeighbour(int xPos, int yPos, ref List<Direction> validDirections) // use get direction from maze algorithms to get all valid directions based from borders
        {
            bool removeNorth = false;
            bool removeEast = false;
            bool removeSouth = false;
            bool removeWest = false;
            for (int i = 0; i < validDirections.Count; i++)
            {
                if (validDirections[i] == Direction.North && yPos != 0)
                {
                    if (Board[xPos, yPos - 1].visited == true)
                    {
                        removeNorth = true;                          //validDirections.Remove(Direction.North);
                    }
                }

                if (validDirections[i] == Direction.East && xPos != 9)
                {
                    if (Board[xPos + 1, yPos].visited == true)
                    {
                        removeEast = true;                          //validDirections.Remove(Direction.East);
                    }
                }

                if (validDirections[i] == Direction.South)
                {
                    if (Board[xPos, yPos + 1].visited == true && yPos != 9)
                    {
                        removeSouth = true;                           //validDirections.Remove(Direction.South);
                    }
                }

                if (validDirections[i] == Direction.West)
                {
                    if (Board[xPos - 1, yPos].visited == true && xPos != 0)
                    {
                        removeWest = true;                          //validDirections.Remove(Direction.West);
                    }
                }
            }
            if (removeNorth == true)
            {
                validDirections.Remove(Direction.North);
            }

            if (removeEast == true)
            {
                validDirections.Remove(Direction.East);
            }

            if (removeSouth == true)
            {
                validDirections.Remove(Direction.South);
            }

            if (removeWest == true)
            {
                validDirections.Remove(Direction.West);
            }
        }
        public void MovePos(List<Direction> validDirections, int choice, ref int xPos, ref int yPos)
        {
            if (validDirections[choice] == Direction.North)
            {
                yPos = yPos - 1;
            }
            else if (validDirections[choice] == Direction.East)
            {
                xPos = xPos + 1;
            }
            else if (validDirections[choice] == Direction.South)
            {
                yPos = yPos + 1;
            }
            else
            {
                xPos = xPos - 1;
            }
        }
    }
}