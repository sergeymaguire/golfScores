using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golfScores
{
    public partial class GolfScoresForm : Form
    {
        int[] scores1 = new int[9];//array for scores
        int[] scores2 = new int[9];//array for scores
        int playerOneHole = 0;
        int playerTwoHole = 0;

        public GolfScoresForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();// allows user to quit the game
        }

        private void btnDetermineWinner_Click(object sender, EventArgs e)
        {
            int total1 = loadPlayerOneScores();
            int total2 = loadPlayerTwoScores();
            lblTotalScorePlayerOne.Text =  "Total Score: " + total1.ToString();
            lblTotalScorePlayerTwo.Text = "Total Score: " + total2.ToString();
        }

        private void GolfScoresForm_Load(object sender, EventArgs e)
        {
            initializeScores(scores1);
            initializeScores(scores2);
        }

        private void initializeScores(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)//setting scores to zero
            {
                scores[i] = 0;
            }
        }

        private int loadPlayerOneScores()
        {
            int total = 0;
            lstScoresPlayerOne.Items.Clear();
            for (int i = 0; i < scores1.Length; i++)//setting scores to zero
            {
                lstScoresPlayerOne.Items.Add("Hole #" + (i + 1).ToString() +  " Score: " + scores1[i].ToString());//adding scores to listbox
                total = total + scores1[i]; //accumulating total for player one
            }
           
            return total;
        }

        private int loadPlayerTwoScores()
        {
            int total = 0;
            lstScoresPlayerTwo.Items.Clear();
            for (int i = 0; i < scores2.Length; i++)//setting scores to zero
            {
                lstScoresPlayerTwo.Items.Add("Hole #" + (i + 1).ToString() + " Score: " + scores2[i].ToString());//adding scores to listbox
                total = total + scores2[i]; //accumulating total for player one
            }

            return total;
        }

        private void btnNextPlayerOne_Click(object sender, EventArgs e)
        {
            if (playerOneHole < 9)// if within nine holes add to score
            {
                scores1[playerOneHole++] = (int)numGolferOneHole.Value;
                lblPlayerOneHole.Text = "Hole #" + playerOneHole.ToString();
            }


        }

        private void btnNextPlayerTwo_Click(object sender, EventArgs e)
        {
            if (playerTwoHole < 9)// if within nine holes add to score
            {
                scores2[playerTwoHole++] = (int)numGolferTwoHole.Value;
                lblPlayerTwoHole.Text = "Hole #" + playerTwoHole.ToString();
            }
        }
    }
}
