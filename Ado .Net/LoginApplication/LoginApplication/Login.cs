using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "Vaibhav" && tb2.Text == "Trainee")
            {
                Output o = new LoginApplication.Output();
                o.StartPosition=FormStartPosition.CenterScreen;
                o.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
