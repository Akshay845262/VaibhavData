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

namespace Information
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand Cmd;
        SqlDataAdapter ADP;
        DataSet DS;
        SqlDataReader dreader;
        
        MemoryStream MS;
        byte[] PhotoArray;
        string Gender;
        string Query,Query1,Query2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT205\\SQLEXPRESS;Database = StudentInfo; Integrated Security = true");
            con.Open();
            MessageBox.Show("Connection Establish..");
           
            
        }
          
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            pictureBox1.Image = null;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                if (checkBox5.Checked == true)
                {
                    Gender = "M";
                }

                else
                {
                    Gender = "F";
                }

                string query;
                query = "insert into StudentInfo values(" + textBox1.Text + ", '" + textBox2.Text + "','" + comboBox1.Text + "', '" + dateTimePicker1.Value.Date + "','" + Gender + "', @Photo)";
                Cmd = new SqlCommand(query, con);
                ConvertPhoto();
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully...");
            }
            catch (Exception)
            {
                MessageBox.Show(" Exception Thrown...");
            }
        }
        void ConvertPhoto()
        {
            if (pictureBox1.Image != null)
            {
                MS = new MemoryStream();
                pictureBox1.Image.Save(MS, ImageFormat.Jpeg);
                byte[] PhotoArray = new byte[MS.Length];
                MS.Position = 0;
                MS.Read(PhotoArray, 0, PhotoArray.Length);
                Cmd.Parameters.AddWithValue("@Photo", PhotoArray);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are u sure you want to Exit?", "Exit Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Close();
                con = null;

                MessageBox.Show("No Connection is open", "Database Connection");
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("Select * from StudentInfo where SNO=" + textBox1.Text + "", con);
            try
            {
                dreader = Cmd.ExecuteReader();
                if (dreader.Read())
                {
                    textBox1.Text = dreader[0].ToString();
                    textBox2.Text = dreader[1].ToString();
                    comboBox1.Text = dreader[2].ToString();
                    dateTimePicker1.Text = dreader[3].ToString();
                   
                    Gender = dreader[4].ToString();
                    if (checkBox1.Checked = true)
                    {
                        if (Gender == "F")
                        {
                            checkBox1.Checked = false;
                        }
                        else
                        {
                            checkBox1.Checked = true;
                        }
                    }
                    pictureBox1.Image = null;
                    PhotoArray = (byte[])dreader[5];
                    MemoryStream ms = new MemoryStream(PhotoArray);
                    pictureBox1.Image = Image.FromStream(ms);

                }
                else
                {
                    MessageBox.Show("Invalid Search");
                }
                dreader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "All")
            {
                ADP = new SqlDataAdapter("select * from StudentInfo", con);
                DataSet DS = new DataSet();
                ADP.Fill(DS, "StudentInfo");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "StudentInfo";

            }
            else if (comboBox2.Text == "Courses")
            {
                ADP = new SqlDataAdapter("select SNO, Course from StudentInfo", con);
                DataSet DS = new DataSet();
                ADP.Fill(DS, "StudentInfo");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "StudentInfo";
            }
            else if (comboBox2.Text == "Date of Joining")
            {
                ADP = new SqlDataAdapter("select SNO, DOJ from StudentInfo", con);
                DataSet DS = new DataSet();
                ADP.Fill(DS, "StudentInfo");
                dataGridView1.DataSource = DS;
                dataGridView1.DataMember = "StudentInfo";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form Gridview = new Form();
            DataGridView View = new DataGridView();

            ADP = new SqlDataAdapter("select * from StudentInfo", con);
            DataSet Grdset = new DataSet();
            ADP.Fill(Grdset, "StudentInfo");

            View.DataSource = Grdset;
            View.DataMember = "StudentInfo";
            View.Location = new Point(100, 100);
            View.Height = 400;
            View.Width = 500;

            Gridview.Controls.Add(View);

            Gridview.StartPosition = FormStartPosition.CenterScreen;
            Gridview.Height = 300;
            Gridview.Width = 700;
            Gridview.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPNDialog = new OpenFileDialog();
            OPNDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|All Files|*.*";
            DialogResult Result = OPNDialog.ShowDialog();
            if (Result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OPNDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query2 = "Delete from StudentInfo where SNO=" + textBox1.Text + "";
            Cmd = new SqlCommand(Query2, con);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                Gender = "M";
            }

            else
            {
                Gender = "F";
            }
            Query1 = "update StudentInfo set Name='" + textBox2.Text + "',Course='" + comboBox1.Text + "',DOJ='"+ dateTimePicker1.Value.Date+"',Gender='"+Gender+"',Photo=@Photo where SNO=" + textBox1.Text + "";
            Cmd = new SqlCommand(Query1, con);
            
            ConvertPhoto();
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            pictureBox1.Image = null;
        }
    }
}
