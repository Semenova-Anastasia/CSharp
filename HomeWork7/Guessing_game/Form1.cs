using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_game
{
    public partial class Form1 : Form
    {
        public Guessing guessing = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guessing = new Guessing();
            lbMessage.Text = "The game has begun!";
            UpdateInfo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void UpdateInfo()
        {
            lbTryCount.Text = guessing?.TryCount.ToString();
            if (guessing != null)
            {
                if ((int)guessing?.StGame == 1)
                {
                    lbMessage.Text = "Congratulations!\nYou won!";
                    lbGNum.Text = guessing.GNumber.ToString();
                    guessing = null;
                }
                else if ((int)guessing?.StGame == 2)
                {
                    lbMessage.Text = "Unfortunately, you lose.\nYou can try playing again.";
                    lbGNum.Text = guessing.GNumber.ToString();
                    guessing = null;
                }
            }
        }

        private void btnEnterNum_Click(object sender, EventArgs e)
        {
            if (guessing != null)
            {
                EnterNumber newForm = new EnterNumber(this);
                newForm.Show();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (guessing != null)
            {
                guessing?.CheckAnswer();
                lbMessage.Text = guessing?.Info;
                UpdateInfo();
            }
        }
    }   
}
