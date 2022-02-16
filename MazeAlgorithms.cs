﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Generation_3
{
    class MazeAlgorithms
    {
        public cell[,] Board;
        private Random rnd = new Random();

        public enum Direction
        {
            East,
            North,
            West,
            South,
            None
        };

        public List<Direction> GetDirections(int x, int y)
        {
            int length= Board.GetLength(0);
            int height = Board.GetLength(1);
            var validDirections = new List<Direction>();
            if (x < (length- 1))
            {
                validDirections.Add(Direction.East);
            }
            if (y > 0)
            {
                validDirections.Add(Direction.North);
            }
            if (y < (height - 1))
            {
                validDirections.Add(Direction.South);
            }
            if (x > 0)
            {
                validDirections.Add(Direction.West);
            }
            return validDirections;
        }

        public Direction GetRandomDirection(int x, int y)
        {
            var dirs = GetDirections(x, y);
            int index = rnd.Next(dirs.Count);
            return dirs[index];
        }

        public void MakeDoor(int xPos, int yPos, Direction direction)
        {
            //take direction and assign corresponding walls
            GetOpposite(direction);
            if (direction == Direction.North)
            {
                Board[xPos, yPos].northWall = false;             // and that cell changes its state to visited as well.  
                Board[xPos, yPos - 1].southWall = false;
            }
            else if (direction == Direction.East)
            {
                Board[xPos, yPos].eastWall = false;             // and that cell changes its state to visited as well.  
                Board[xPos + 1, yPos].westWall = false;
            }
            else if (direction == Direction.South)
            {
                Board[xPos, yPos].southWall = false;             // and that cell changes its state to visited as well.  
                Board[xPos, yPos + 1].northWall = false;
            }
            else if (direction == Direction.West)
            {
                Board[xPos, yPos].westWall = false;             // and that cell changes its state to visited as well.  
                Board[xPos - 1, yPos].eastWall = false;
            }
        }
        public Direction GetOpposite(Direction direction)
        {
            if (direction == Direction.North)
            {
                return Direction.South;
            }
            else if (direction == Direction.East)
            {
                return Direction.West;
            }
            else if (direction == Direction.South)
            {
                return Direction.North;
            }
            return Direction.East;
        }
    }
}
