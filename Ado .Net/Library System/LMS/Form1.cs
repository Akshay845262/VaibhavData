using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vaibhav" && textBox2.Text == "12345")
            {
                LibraryManagement w = new LMS.LibraryManagement();
                //w.MdiParent = this;
                // ul.WindowState = FormWindowState.Maximized;
                w.StartPosition = FormStartPosition.CenterScreen;
                w.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
