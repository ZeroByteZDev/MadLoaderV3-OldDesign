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
    public partial class Bootstrapper : Form
    {
        public Bootstrapper()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            siticoneProgressBar1.Increment(1);
            if (siticoneProgressBar1.Value == 100)
            {
                timer1.Stop();
                UI.ActivationLogin ac = new UI.ActivationLogin();
                ac.Show();
                this.Hide();
            }
        }
    }
}
