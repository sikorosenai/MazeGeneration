using System.Windows.Forms;
using System.Drawing;
using System;

namespace Maze_Generation_3
{
    public partial class MazeGeneration : Form
    {
        private void pictureBoxMazePaint(object sender, PaintEventArgs e)
        {
            if (Board == null)
                return;
            Graphics mazeRender = e.Graphics;

            Pen gridPen = new Pen(Color.Black);
            gridPen.Width = 4.0F;

            const int roomSize = 30;
            for (int x = 0; x < int.Parse(textboxLength.Text); x++)
            {
                for (int y = 0; y < int.Parse(textboxHeight.Text); y++)
                {
                    var yCoord = y * roomSize;
                    var xCoord = x * roomSize;

                    if (Board[x, y].valid == true)
                    {
                        if (Board[x, y].northWall == true)
                        {
                            mazeRender.DrawLine(gridPen, xCoord, yCoord, xCoord + roomSize, yCoord);
                        }
                        if (Board[x, y].southWall == true)
                        {
                            mazeRender.DrawLine(gridPen, xCoord, yCoord + roomSize, xCoord + roomSize, yCoord + roomSize);
                        }
                        if (Board[x, y].eastWall == true)
                        {
                            mazeRender.DrawLine(gridPen, xCoord + roomSize, yCoord, xCoord + roomSize, yCoord + roomSize);
                        }
                        if (Board[x, y].westWall == true)
                        {
                            mazeRender.DrawLine(gridPen, xCoord, yCoord, xCoord, yCoord + roomSize);
                        }
                    }
                }
            }
        }
    }
}