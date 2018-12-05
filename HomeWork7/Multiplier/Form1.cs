using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplier
{
    public partial class Form1 : Form
    {
        Multiplier multiplier = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiplier = new Multiplier(2, 1001);
            lbMessage.Text = "Get goal number.";
            UpdateInfo();
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "In the game you need to reach the target number using operations '+1' and 'x2'.\n" +
                "You can take a step back or reset the progress using the corresponding buttons.",
                "Game rules");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void UpdateInfo()
        {
            lbYNum.Text = multiplier?.YNumber.ToString();
            lbGNum.Text = multiplier?.GNumber.ToString();
            lbGSteps.Text = multiplier?.GSteps.ToString();
            lbYSteps.Text = multiplier?.YSteps.ToString();
            multiplier?.CheckStatus();
            if (multiplier != null)
            {
                if ((int)multiplier?.StGame == 1)
                {
                    lbMessage.Text = "Congratulations!\nYou won!";
                    multiplier = null;
                }
                else if ((int)multiplier?.StGame == 2)
                {
                    lbMessage.Text = "Unfortunately, you lose. You can try playing again.";
                    multiplier = null;
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (multiplier != null)
            {
                multiplier.Plus();
                UpdateInfo();
            }
            else lbMessage.Text = "Start a new game.";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (multiplier != null)
            {
                multiplier?.Multi();
                UpdateInfo();
            }
            else lbMessage.Text = "Start a new game.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (multiplier != null)
            {
                multiplier?.Reset();
                UpdateInfo();
            }
            else lbMessage.Text = "Start a new game.";
        }

        private void btnSBack_Click(object sender, EventArgs e)
        {
            if (multiplier != null)
            {
                multiplier?.StepBack();
                UpdateInfo();
            }
            else lbMessage.Text = "Start a new game.";
        }
    }
}
