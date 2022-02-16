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

    public partial class MazeGeneration : Form
    {
        public cell[,] Board;

        public MazeGeneration()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            initialisationMaze(int.Parse(textboxLength.Text), int.Parse(textboxHeight.Text));
        }
        private void initialisationMaze(int mazeLength, int mazeHeight)
        {
            MazeSetup setup = new MazeSetup();

            Board = new cell[mazeLength, mazeHeight];
            int yCount = mazeHeight;
            int xCount = mazeLength;

            for (int y = 0; y < yCount; y++)
            {
                for (int x = 0; x < xCount; x++) //initialise maze and each cell is a co-ord point
                {
                    Board[x, y] = new cell();
                }
            }

            pictureBoxMazeRender.Width = ((int.Parse(textboxLength.Text) * 30) + 2); //makes the picturebox of the maze to be the exact dimensions needed
            pictureBoxMazeRender.Height = ((int.Parse(textboxHeight.Text) * 30) + 2);

            startingPosition(setup, int.Parse(textboxXStart.Text) - 1, int.Parse(textboxYStart.Text) - 1);

            var recursiveBacktracker = new RecursiveBacktracker();
            var binaryTree = new BinaryTree();
            var masking = new Masking();

            setup.mazeWidth = mazeLength;
            setup.mazeHeight = mazeHeight;
            if (radioButtonRecursiveBacktracker.Checked == true)
            {
                recursiveBacktracker.Generate(Board, setup, mazeHeight, mazeLength);
            }
            else if (radioButtonBinaryTree.Checked == true)
            {
                binaryTree.Generate(Board, setup, mazeHeight, mazeLength);
            }
            else if (radioButtonMasking.Checked == true)
            {
                masking.Generate(Board, setup, mazeHeight, mazeLength);
            }
            Refresh();
        }
        private void startingPosition(MazeSetup setup, int xStart, int yStart)
        {
            if (xStart == 0 && yStart == 0)
            {
                Random rnd = new Random();
                xStart = rnd.Next(int.Parse(textboxLength.Text));
                yStart = rnd.Next(int.Parse(textboxHeight.Text));
            }
            setup.xPos = xStart;
            setup.yPos = yStart;

        }
    }
    public class MazeSetup
    {
        public int xPos;
        public int yPos;
        public int choice;
        public int mazeWidth;
        public int mazeHeight;
    }

}
