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
    public partial class fIP : Form
    {
        public string IP { get; set; }
        public fIP()
        {
            InitializeComponent();
            IP = "192.168.107.179";
        }

        private void btnSaveIP_Click(object sender, EventArgs e)
        {
            IP = tbIP.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbIP.Text = IP;
            this.Close();
        }
    }
}
