using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace scoreCounter
{
    public partial class Form1 : Form
    {
        string contestant1 = "";
        string contestant2 = "";
        int contestant1Score = Convert.ToInt32(File.ReadAllText("contestant1Score.txt"));
        int contestant2Score = Convert.ToInt32(File.ReadAllText("contestant2Score.txt"));
        int roundNumber = Convert.ToInt32(File.ReadAllText("roundNumber.txt"));

        public Form1()
        {
            InitializeComponent();
            contestant1ScoreLabel.Text = Convert.ToString(contestant1Score);
            contestant2ScoreLabel.Text = Convert.ToString(contestant2Score);
            roundNumberLabel.Text = Convert.ToString(roundNumber);
        }

        
        private void updateContestantsButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("contestant1.txt", contestant1TextBox.Text);
            File.WriteAllText("contestant2.txt", contestant2TextBox.Text);
        }

        private void contestant1MinusButton_Click(object sender, EventArgs e)
        {
            contestant1Score = contestant1Score - 1;
            contestant1ScoreLabel.Text = Convert.ToString(contestant1Score);
            File.WriteAllText("contestant1Score.txt", contestant1ScoreLabel.Text);
        }

        private void contestant1PlusButton_Click(object sender, EventArgs e)
        {
            contestant1Score = contestant1Score + 1;
            contestant1ScoreLabel.Text = Convert.ToString(contestant1Score);
            File.WriteAllText("contestant1Score.txt", contestant1ScoreLabel.Text);
        }

        private void contestant2MinusButton_Click(object sender, EventArgs e)
        {
            contestant2Score = contestant2Score - 1;
            contestant2ScoreLabel.Text = Convert.ToString(contestant2Score);
            File.WriteAllText("contestant2Score.txt", contestant2ScoreLabel.Text);
        }

        private void contestant2PlusButton_Click(object sender, EventArgs e)
        {
            contestant2Score = contestant2Score + 1;
            contestant2ScoreLabel.Text = Convert.ToString(contestant2Score);
            File.WriteAllText("contestant2Score.txt", contestant2ScoreLabel.Text);
        }

        private void minusRoundButton_Click(object sender, EventArgs e)
        {
            roundNumber = roundNumber - 1;
            roundNumberLabel.Text = Convert.ToString(roundNumber);
            File.WriteAllText("roundNumber.txt", roundNumberLabel.Text);
        }

        private void plusRoundButton_Click(object sender, EventArgs e)
        {
            roundNumber = roundNumber + 1;
            roundNumberLabel.Text = Convert.ToString(roundNumber);
            File.WriteAllText("roundNumber.txt", roundNumberLabel.Text);
        }

        private void newMatchButton_Click(object sender, EventArgs e)
        {
            roundNumber = 1;
            contestant1Score = 0;
            contestant2Score = 0;

            newContestantForm newContestant1Popup = new newContestantForm("1 (Red)");
            DialogResult dialogResult = newContestant1Popup.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                contestant1 = newContestant1Popup.contestantName;
            }
            newContestant1Popup.Dispose();

            newContestantForm newContestant2Popup = new newContestantForm("2 (Blue)");
            dialogResult = newContestant2Popup.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                contestant2 = newContestant2Popup.contestantName;
            }
            newContestant2Popup.Dispose();

            contestant1TextBox.Text = contestant1;
            contestant2TextBox.Text = contestant2;
            File.WriteAllText("contestant1.txt", contestant1TextBox.Text);
            File.WriteAllText("contestant2.txt", contestant2TextBox.Text);
            contestant1 = "";
            contestant2 = "";

            roundNumberLabel.Text = Convert.ToString(roundNumber);
            File.WriteAllText("roundNumber.txt", roundNumberLabel.Text);

            contestant1ScoreLabel.Text = Convert.ToString(contestant1Score);
            File.WriteAllText("contestant1Score.txt", contestant1ScoreLabel.Text);
            contestant2ScoreLabel.Text = Convert.ToString(contestant2Score);
            File.WriteAllText("contestant2Score.txt", contestant2ScoreLabel.Text);


        }
    }
}
