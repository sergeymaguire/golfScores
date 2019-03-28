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
            this.lblHoleNumberPlayerOne = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNameGolferOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNextPlayerOne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHoleNumberPlayerTwo = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtNameGolferTwo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNextPlayerTwo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDetermineWinner = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblWinnerResults = new System.Windows.Forms.Label();
            this.numGolferOneHole = new System.Windows.Forms.NumericUpDown();
            this.numGolferTwoHole = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferOneHole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferTwoHole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numGolferOneHole);
            this.groupBox1.Controls.Add(this.lblHoleNumberPlayerOne);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txtNameGolferOne);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNextPlayerOne);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblPlayerOneScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Golfer #1";
            // 
            // lblHoleNumberPlayerOne
            // 
            this.lblHoleNumberPlayerOne.AutoSize = true;
            this.lblHoleNumberPlayerOne.Location = new System.Drawing.Point(52, 90);
            this.lblHoleNumberPlayerOne.Name = "lblHoleNumberPlayerOne";
            this.lblHoleNumberPlayerOne.Size = new System.Drawing.Size(0, 13);
            this.lblHoleNumberPlayerOne.TabIndex = 32;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(55, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 30;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(49, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Hole #1";
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(120, 297);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerOneScore.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total Score:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numGolferTwoHole);
            this.groupBox2.Controls.Add(this.lblHoleNumberPlayerTwo);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.txtNameGolferTwo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnNextPlayerTwo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblPlayerTwoScore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 354);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Golfer #2";
            // 
            // lblHoleNumberPlayerTwo
            // 
            this.lblHoleNumberPlayerTwo.AutoSize = true;
            this.lblHoleNumberPlayerTwo.Location = new System.Drawing.Point(76, 66);
            this.lblHoleNumberPlayerTwo.Name = "lblHoleNumberPlayerTwo";
            this.lblHoleNumberPlayerTwo.Size = new System.Drawing.Size(0, 13);
            this.lblHoleNumberPlayerTwo.TabIndex = 32;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(62, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 160);
            this.listBox2.TabIndex = 30;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(50, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hole #2";
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(119, 279);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerTwoScore.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Score:";
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
            this.lblWinnerResults.Size = new System.Drawing.Size(0, 13);
            this.lblWinnerResults.TabIndex = 26;
            // 
            // numGolferOneHole
            // 
            this.numGolferOneHole.Location = new System.Drawing.Point(115, 83);
            this.numGolferOneHole.Name = "numGolferOneHole";
            this.numGolferOneHole.Size = new System.Drawing.Size(45, 20);
            this.numGolferOneHole.TabIndex = 33;
            // 
            // numGolferTwoHole
            // 
            this.numGolferTwoHole.Location = new System.Drawing.Point(118, 66);
            this.numGolferTwoHole.Name = "numGolferTwoHole";
            this.numGolferTwoHole.Size = new System.Drawing.Size(45, 20);
            this.numGolferTwoHole.TabIndex = 33;
            // 
            // GolfScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.lblWinnerResults);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnDetermineWinner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GolfScoresForm";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferOneHole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGolferTwoHole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNameGolferOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNextPlayerOne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtNameGolferTwo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNextPlayerTwo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetermineWinner;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblWinnerResults;
        private System.Windows.Forms.Label lblHoleNumberPlayerOne;
        private System.Windows.Forms.Label lblHoleNumberPlayerTwo;
        private System.Windows.Forms.NumericUpDown numGolferOneHole;
        private System.Windows.Forms.NumericUpDown numGolferTwoHole;
    }
}

