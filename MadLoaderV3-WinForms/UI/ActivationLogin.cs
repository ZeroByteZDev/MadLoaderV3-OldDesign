using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLoaderV3_WinForms.UI
{
    public partial class ActivationLogin : Form
    {
        public ActivationLogin()
        {
            InitializeComponent();
        }

        private void activationbtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab("Activation");
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectTab("Login");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }
    }
}
