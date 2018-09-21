using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoreCounter
{
    public partial class newContestantForm : Form
    {
        public string contestantName = "";

        public newContestantForm(string contestantNumberAndColor)
        {
            InitializeComponent();
            enterNameLabel.Text = enterNameLabel.Text + contestantNumberAndColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contestantName = newContestantTextBox.Text;
        }
    }
}
