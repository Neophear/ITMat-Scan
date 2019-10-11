using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMat_Scan
{
    public partial class MainMenu : Form
    {
        bool capture = false;
        StringBuilder builder = new StringBuilder();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.B)
            {
                capture = true;
                e.SuppressKeyPress = true;
            }
            else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
            {
                capture = false;
                textBox1.Text += builder.ToString() + Environment.NewLine;
                builder.Clear();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (capture)
            {
                builder.Append(e.KeyChar);
            }
        }

        private void btnLoanOutIn_Click(object sender, EventArgs e)
        {
            LoanOutIn loan = new LoanOutIn();
            loan.Show();
        }

        private void afslutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
