using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulatore_luce_solare
{
    public partial class fWaiting : Form
    {
        private int Dots;
        private string TextLabel;
        public fWaiting(string Text, string buttonText)
        {
            InitializeComponent();
            this.TextLabel = Text;
            btnAbort.Text = buttonText;
            if (buttonText == "")
                btnAbort.Visible = false;
            lblText.Text = Text;
            Dots = 0;
        }

        private void tDots_Tick(object sender, EventArgs e)
        {
            Dots++;
            Dots %= 4;
            lblText.Text = TextLabel;
            for (int i = 0; i < Dots; i++)
                lblText.Text += '.';
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
