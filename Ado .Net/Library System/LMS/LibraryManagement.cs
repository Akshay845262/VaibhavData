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
    public partial class LibraryManagement : Form
    {
        public LibraryManagement()
        {
            InitializeComponent();
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {

        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member m = new LMS.Member();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Show();
        }
    }
}
