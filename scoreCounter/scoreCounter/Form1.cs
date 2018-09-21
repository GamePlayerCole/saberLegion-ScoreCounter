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
        public Form1()
        {
            InitializeComponent();
            string contestant1 = "";
            string contestant2 = "";
            int contestant1Score = Convert.ToInt32(File.ReadAllText("contestant1Score.txt"));
            int contestant2Score = Convert.ToInt32(File.ReadAllText("contestant2Score.txt"));
            int roundNumber = Convert.ToInt32(File.ReadAllText("roundNumber.txt"));

            contestant1ScoreLabel.Text = Convert.ToString(contestant1Score);
            contestant2ScoreLabel.Text = Convert.ToString(contestant2Score);
            roundNumberLabel.Text = Convert.ToString(roundNumber);
        }

        
        private void updateContestantsButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("contestant1.txt", contestant1TextBox.Text);
            File.WriteAllText("contestant2.txt", contestant2TextBox.Text);
        }
    }
}
