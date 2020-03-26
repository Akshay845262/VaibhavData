using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;
using System.IO;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT205\\SQLEXPRESS;Database = AgeCalc; Integrated Security = true");
            con.Open();
            MessageBox.Show("Connection Establish..");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string query;
            query = "insert into student values(" + stdID.Text + ", '" + stdName.Text + "','" + DOB.Value.Date + "','" + age.Text + "')";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully...");

        }
    }
}
