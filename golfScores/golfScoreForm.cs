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
        int[] scores = new int[9];//array for scores
        int playerOneHole = 0;

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
            int total = loadScoresIntoListBox();
            lblTotalScorePlayerOne.Text =  "Total Score: " + total.ToString();
        }

        private void GolfScoresForm_Load(object sender, EventArgs e)
        {
            initializeScores();
        }

        private void initializeScores()
        {
            for (int i = 0; i < scores.Length; i++)//setting scores to zero
            {
                scores[i] = 0;
            }
        }

        private int loadScoresIntoListBox()
        {
            int total = 0;
            lstScoresPlayerOne.Items.Clear();
            for (int i = 0; i < scores.Length; i++)//setting scores to zero
            {
                lstScoresPlayerOne.Items.Add("Hole #" + (i + 1).ToString() +  " Score: " + scores[i].ToString());//adding scores to listbox
                total = total + scores[i]; //accumulating total
            }
            return total;
        }

        private void btnNextPlayerOne_Click(object sender, EventArgs e)
        {
            if (playerOneHole < 9)// if within nine holes add to score
            {
                scores[playerOneHole++] = (int)numGolferOneHole.Value;
            }
        }

       
    }
}
