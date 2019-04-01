namespace golfScores
{
    partial class GolfScoresForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numGolferOneHole = new System.Windows.Forms.NumericUpDown();
            this.lblHoleNumberPlayerOne = new System.Windows.Forms.Label();
            this.lstScoresPlayerOne = new System.Windows.Forms.ListBox();
            this.txtNameGolferOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNextPlayerOne = new System.Windows.Forms.Button();
            this.lblPlayerOneHole = new System.Windows.Forms.Label();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.lblTotalScorePlayerOne = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numGolferTwoHole = new System.Windows.Forms.NumericUpDown();
            this.lblHoleNumberPlayerTwo = new System.Windows.Forms.Label();
            this.lstScoresPlayerTwo = new System.Windows.Forms.ListBox();
            this.txtNameGolferTwo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNextPlayerTwo = new System.Windows.Forms.Button();
            this.lblPlayerTwoHole = new System.Windows.Forms.Label();
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.lblTotalScorePlayerTwo = new System.Windows.Forms.Label();
            this.btnDetermineWinner = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWinnerResults = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferOneHole)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferTwoHole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGolferOneHole);
            this.groupBox1.Controls.Add(this.lblHoleNumberPlayerOne);
            this.groupBox1.Controls.Add(this.lstScoresPlayerOne);
            this.groupBox1.Controls.Add(this.txtNameGolferOne);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNextPlayerOne);
            this.groupBox1.Controls.Add(this.lblPlayerOneHole);
            this.groupBox1.Controls.Add(this.lblPlayerOneScore);
            this.groupBox1.Controls.Add(this.lblTotalScorePlayerOne);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Golfer #1";
            // 
            // numGolferOneHole
            // 
            this.numGolferOneHole.Location = new System.Drawing.Point(115, 83);
            this.numGolferOneHole.Name = "numGolferOneHole";
            this.numGolferOneHole.Size = new System.Drawing.Size(45, 20);
            this.numGolferOneHole.TabIndex = 33;
            // 
            // lblHoleNumberPlayerOne
            // 
            this.lblHoleNumberPlayerOne.AutoSize = true;
            this.lblHoleNumberPlayerOne.Location = new System.Drawing.Point(52, 90);
            this.lblHoleNumberPlayerOne.Name = "lblHoleNumberPlayerOne";
            this.lblHoleNumberPlayerOne.Size = new System.Drawing.Size(0, 13);
            this.lblHoleNumberPlayerOne.TabIndex = 32;
            // 
            // lstScoresPlayerOne
            // 
            this.lstScoresPlayerOne.FormattingEnabled = true;
            this.lstScoresPlayerOne.Location = new System.Drawing.Point(55, 117);
            this.lstScoresPlayerOne.Name = "lstScoresPlayerOne";
            this.lstScoresPlayerOne.Size = new System.Drawing.Size(120, 160);
            this.lstScoresPlayerOne.TabIndex = 30;
            // 
            // txtNameGolferOne
            // 
            this.txtNameGolferOne.Location = new System.Drawing.Point(52, 51);
            this.txtNameGolferOne.Name = "txtNameGolferOne";
            this.txtNameGolferOne.Size = new System.Drawing.Size(100, 20);
            this.txtNameGolferOne.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(52, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Name";
            // 
            // btnNextPlayerOne
            // 
            this.btnNextPlayerOne.Location = new System.Drawing.Point(166, 83);
            this.btnNextPlayerOne.Name = "btnNextPlayerOne";
            this.btnNextPlayerOne.Size = new System.Drawing.Size(45, 20);
            this.btnNextPlayerOne.TabIndex = 26;
            this.btnNextPlayerOne.Text = "next";
            this.btnNextPlayerOne.UseVisualStyleBackColor = true;
            this.btnNextPlayerOne.Click += new System.EventHandler(this.btnNextPlayerOne_Click);
            // 
            // lblPlayerOneHole
            // 
            this.lblPlayerOneHole.AutoSize = true;
            this.lblPlayerOneHole.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPlayerOneHole.Location = new System.Drawing.Point(49, 83);
            this.lblPlayerOneHole.Name = "lblPlayerOneHole";
            this.lblPlayerOneHole.Size = new System.Drawing.Size(45, 13);
            this.lblPlayerOneHole.TabIndex = 24;
            this.lblPlayerOneHole.Text = "Hole #1";
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(120, 297);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerOneScore.TabIndex = 23;
            // 
            // lblTotalScorePlayerOne
            // 
            this.lblTotalScorePlayerOne.AutoSize = true;
            this.lblTotalScorePlayerOne.Location = new System.Drawing.Point(49, 298);
            this.lblTotalScorePlayerOne.Name = "lblTotalScorePlayerOne";
            this.lblTotalScorePlayerOne.Size = new System.Drawing.Size(65, 13);
            this.lblTotalScorePlayerOne.TabIndex = 22;
            this.lblTotalScorePlayerOne.Text = "Total Score:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numGolferTwoHole);
            this.groupBox2.Controls.Add(this.lblHoleNumberPlayerTwo);
            this.groupBox2.Controls.Add(this.lstScoresPlayerTwo);
            this.groupBox2.Controls.Add(this.txtNameGolferTwo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnNextPlayerTwo);
            this.groupBox2.Controls.Add(this.lblPlayerTwoHole);
            this.groupBox2.Controls.Add(this.lblPlayerTwoScore);
            this.groupBox2.Controls.Add(this.lblTotalScorePlayerTwo);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 354);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Golfer #2";
            // 
            // numGolferTwoHole
            // 
            this.numGolferTwoHole.Location = new System.Drawing.Point(118, 66);
            this.numGolferTwoHole.Name = "numGolferTwoHole";
            this.numGolferTwoHole.Size = new System.Drawing.Size(45, 20);
            this.numGolferTwoHole.TabIndex = 33;
            // 
            // lblHoleNumberPlayerTwo
            // 
            this.lblHoleNumberPlayerTwo.AutoSize = true;
            this.lblHoleNumberPlayerTwo.Location = new System.Drawing.Point(76, 66);
            this.lblHoleNumberPlayerTwo.Name = "lblHoleNumberPlayerTwo";
            this.lblHoleNumberPlayerTwo.Size = new System.Drawing.Size(0, 13);
            this.lblHoleNumberPlayerTwo.TabIndex = 32;
            // 
            // lstScoresPlayerTwo
            // 
            this.lstScoresPlayerTwo.FormattingEnabled = true;
            this.lstScoresPlayerTwo.Location = new System.Drawing.Point(62, 116);
            this.lstScoresPlayerTwo.Name = "lstScoresPlayerTwo";
            this.lstScoresPlayerTwo.Size = new System.Drawing.Size(120, 160);
            this.lstScoresPlayerTwo.TabIndex = 30;
            // 
            // txtNameGolferTwo
            // 
            this.txtNameGolferTwo.Location = new System.Drawing.Point(50, 34);
            this.txtNameGolferTwo.Name = "txtNameGolferTwo";
            this.txtNameGolferTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNameGolferTwo.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Cornsilk;
            this.label8.Location = new System.Drawing.Point(50, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Name";
            // 
            // btnNextPlayerTwo
            // 
            this.btnNextPlayerTwo.Location = new System.Drawing.Point(169, 66);
            this.btnNextPlayerTwo.Name = "btnNextPlayerTwo";
            this.btnNextPlayerTwo.Size = new System.Drawing.Size(45, 20);
            this.btnNextPlayerTwo.TabIndex = 27;
            this.btnNextPlayerTwo.Text = "next";
            this.btnNextPlayerTwo.UseVisualStyleBackColor = true;
            this.btnNextPlayerTwo.Click += new System.EventHandler(this.btnNextPlayerTwo_Click);
            // 
            // lblPlayerTwoHole
            // 
            this.lblPlayerTwoHole.AutoSize = true;
            this.lblPlayerTwoHole.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPlayerTwoHole.Location = new System.Drawing.Point(50, 66);
            this.lblPlayerTwoHole.Name = "lblPlayerTwoHole";
            this.lblPlayerTwoHole.Size = new System.Drawing.Size(45, 13);
            this.lblPlayerTwoHole.TabIndex = 25;
            this.lblPlayerTwoHole.Text = "Hole #1";
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(119, 279);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerTwoScore.TabIndex = 24;
            // 
            // lblTotalScorePlayerTwo
            // 
            this.lblTotalScorePlayerTwo.AutoSize = true;
            this.lblTotalScorePlayerTwo.Location = new System.Drawing.Point(47, 280);
            this.lblTotalScorePlayerTwo.Name = "lblTotalScorePlayerTwo";
            this.lblTotalScorePlayerTwo.Size = new System.Drawing.Size(65, 13);
            this.lblTotalScorePlayerTwo.TabIndex = 23;
            this.lblTotalScorePlayerTwo.Text = "Total Score:";
            // 
            // btnDetermineWinner
            // 
            this.btnDetermineWinner.Location = new System.Drawing.Point(28, 371);
            this.btnDetermineWinner.Name = "btnDetermineWinner";
            this.btnDetermineWinner.Size = new System.Drawing.Size(120, 24);
            this.btnDetermineWinner.TabIndex = 24;
            this.btnDetermineWinner.Text = "Determine Winner";
            this.btnDetermineWinner.UseVisualStyleBackColor = true;
            this.btnDetermineWinner.Click += new System.EventHandler(this.btnDetermineWinner_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(474, 367);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 25;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblWinnerResults
            // 
            this.lblWinnerResults.AutoSize = true;
            this.lblWinnerResults.Location = new System.Drawing.Point(281, 372);
            this.lblWinnerResults.Name = "lblWinnerResults";
            this.lblWinnerResults.Size = new System.Drawing.Size(63, 13);
            this.lblWinnerResults.TabIndex = 26;
            this.lblWinnerResults.Text = "winner label";
            // 
            // GolfScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.lblWinnerResults);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDetermineWinner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GolfScoresForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.GolfScoresForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferOneHole)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferTwoHole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstScoresPlayerOne;
        private System.Windows.Forms.TextBox txtNameGolferOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNextPlayerOne;
        private System.Windows.Forms.Label lblPlayerOneHole;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Label lblTotalScorePlayerOne;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstScoresPlayerTwo;
        private System.Windows.Forms.TextBox txtNameGolferTwo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNextPlayerTwo;
        private System.Windows.Forms.Label lblPlayerTwoHole;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblTotalScorePlayerTwo;
        private System.Windows.Forms.Button btnDetermineWinner;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblWinnerResults;
        private System.Windows.Forms.Label lblHoleNumberPlayerOne;
        private System.Windows.Forms.Label lblHoleNumberPlayerTwo;
        private System.Windows.Forms.NumericUpDown numGolferOneHole;
        private System.Windows.Forms.NumericUpDown numGolferTwoHole;
    }
}

