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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }

        private void Output_Activated(object sender, EventArgs e)
        {
            Label L1 = new Label();
            L1.Text = "Login Success!!!";
            L1.Width = 300;
            L1.Location = new Point(75, 75);
            this.Controls.Add(L1);

        }

        private void b4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
