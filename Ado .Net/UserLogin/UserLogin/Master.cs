using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLogin
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer ul = new UserLogin.Trainer();
            ul.MdiParent = this;
           // ul.WindowState = FormWindowState.Maximized;
            ul.StartPosition = FormStartPosition.CenterScreen;
            ul.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
