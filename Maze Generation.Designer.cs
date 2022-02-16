
namespace Maze_Generation_3
{
    partial class MazeGeneration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textboxLength = new System.Windows.Forms.TextBox();
            this.textboxHeight = new System.Windows.Forms.TextBox();
            this.textboxYStart = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radioButtonRecursiveBacktracker = new System.Windows.Forms.RadioButton();
            this.radioButtonBinaryTree = new System.Windows.Forms.RadioButton();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelXStart = new System.Windows.Forms.Label();
            this.labelYStart = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBoxMazeRender = new System.Windows.Forms.PictureBox();
            this.textboxXStart = new System.Windows.Forms.TextBox();
            this.radioButtonMasking = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazeRender)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxLength
            // 
            this.textboxLength.Location = new System.Drawing.Point(18, 37);
            this.textboxLength.Name = "textboxLength";
            this.textboxLength.Size = new System.Drawing.Size(114, 20);
            this.textboxLength.TabIndex = 0;
            this.textboxLength.Text = "10";
            // 
            // textboxHeight
            // 
            this.textboxHeight.Location = new System.Drawing.Point(166, 37);
            this.textboxHeight.Name = "textboxHeight";
            this.textboxHeight.Size = new System.Drawing.Size(114, 20);
            this.textboxHeight.TabIndex = 1;
            this.textboxHeight.Text = "10";
            // 
            // textboxYStart
            // 
            this.textboxYStart.Location = new System.Drawing.Point(166, 76);
            this.textboxYStart.Name = "textboxYStart";
            this.textboxYStart.Size = new System.Drawing.Size(114, 20);
            this.textboxYStart.TabIndex = 3;
            this.textboxYStart.Text = "1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // radioButtonRecursiveBacktracker
            // 
            this.radioButtonRecursiveBacktracker.AutoSize = true;
            this.radioButtonRecursiveBacktracker.Location = new System.Drawing.Point(19, 125);
            this.radioButtonRecursiveBacktracker.Name = "radioButtonRecursiveBacktracker";
            this.radioButtonRecursiveBacktracker.Size = new System.Drawing.Size(134, 17);
            this.radioButtonRecursiveBacktracker.TabIndex = 7;
            this.radioButtonRecursiveBacktracker.TabStop = true;
            this.radioButtonRecursiveBacktracker.Text = "Recursive Backtracker";
            this.radioButtonRecursiveBacktracker.UseVisualStyleBackColor = true;
            // 
            // radioButtonBinaryTree
            // 
            this.radioButtonBinaryTree.AutoSize = true;
            this.radioButtonBinaryTree.Location = new System.Drawing.Point(159, 125);
            this.radioButtonBinaryTree.Name = "radioButtonBinaryTree";
            this.radioButtonBinaryTree.Size = new System.Drawing.Size(125, 17);
            this.radioButtonBinaryTree.TabIndex = 10;
            this.radioButtonBinaryTree.TabStop = true;
            this.radioButtonBinaryTree.Text = "Binary Tree Algorithm";
            this.radioButtonBinaryTree.UseVisualStyleBackColor = true;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(15, 21);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "Length:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(163, 21);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 12;
            this.labelHeight.Text = "Height:";
            // 
            // labelXStart
            // 
            this.labelXStart.AutoSize = true;
            this.labelXStart.Location = new System.Drawing.Point(15, 60);
            this.labelXStart.Name = "labelXStart";
            this.labelXStart.Size = new System.Drawing.Size(79, 13);
            this.labelXStart.TabIndex = 13;
            this.labelXStart.Text = "X start position:";
            // 
            // labelYStart
            // 
            this.labelYStart.AutoSize = true;
            this.labelYStart.Location = new System.Drawing.Point(163, 60);
            this.labelYStart.Name = "labelYStart";
            this.labelYStart.Size = new System.Drawing.Size(79, 13);
            this.labelYStart.TabIndex = 14;
            this.labelYStart.Text = "Y start position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Algorithms:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(88, 171);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(101, 49);
            this.buttonGenerate.TabIndex = 18;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pictureBoxMazeRender
            // 
            this.pictureBoxMazeRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMazeRender.Location = new System.Drawing.Point(294, 12);
            this.pictureBoxMazeRender.Name = "pictureBoxMazeRender";
            this.pictureBoxMazeRender.Size = new System.Drawing.Size(267, 238);
            this.pictureBoxMazeRender.TabIndex = 19;
            this.pictureBoxMazeRender.TabStop = false;
            this.pictureBoxMazeRender.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMazePaint);
            // 
            // textboxXStart
            // 
            this.textboxXStart.Location = new System.Drawing.Point(18, 76);
            this.textboxXStart.Name = "textboxXStart";
            this.textboxXStart.Size = new System.Drawing.Size(114, 20);
            this.textboxXStart.TabIndex = 2;
            this.textboxXStart.Text = "1";
            // 
            // radioButtonMasking
            // 
            this.radioButtonMasking.AutoSize = true;
            this.radioButtonMasking.Location = new System.Drawing.Point(111, 148);
            this.radioButtonMasking.Name = "radioButtonMasking";
            this.radioButtonMasking.Size = new System.Drawing.Size(65, 17);
            this.radioButtonMasking.TabIndex = 8;
            this.radioButtonMasking.TabStop = true;
            this.radioButtonMasking.Text = "Masking";
            this.radioButtonMasking.UseVisualStyleBackColor = true;
            // 
            // MazeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 459);
            this.Controls.Add(this.pictureBoxMazeRender);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelYStart);
            this.Controls.Add(this.labelXStart);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.radioButtonBinaryTree);
            this.Controls.Add(this.radioButtonMasking);
            this.Controls.Add(this.radioButtonRecursiveBacktracker);
            this.Controls.Add(this.textboxYStart);
            this.Controls.Add(this.textboxXStart);
            this.Controls.Add(this.textboxHeight);
            this.Controls.Add(this.textboxLength);
            this.Name = "MazeGeneration";
            this.Text = "Maze Generation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazeRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelXStart;
        private System.Windows.Forms.Label labelYStart;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textboxLength;
        public System.Windows.Forms.TextBox textboxHeight;
        public System.Windows.Forms.TextBox textboxYStart;
        public System.Windows.Forms.RadioButton radioButtonRecursiveBacktracker;
        public System.Windows.Forms.RadioButton radioButtonBinaryTree;
        public System.Windows.Forms.PictureBox pictureBoxMazeRender;
        public System.Windows.Forms.Button buttonGenerate;
        public System.Windows.Forms.TextBox textboxXStart;
        public System.Windows.Forms.RadioButton radioButtonMasking;
    }
}

