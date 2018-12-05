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
    public partial class EnterNumber : Form
    {
        Form1 form;

        public EnterNumber()
        {
            InitializeComponent();
        }

        public EnterNumber(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void btnEnterNum_Click(object sender, EventArgs e)
        {
            form.guessing?.EnterYNumber(tbEnterNum.Text);
            form.lbYNum.Text = tbEnterNum.Text;
            this.Close();
        }
    }
}
