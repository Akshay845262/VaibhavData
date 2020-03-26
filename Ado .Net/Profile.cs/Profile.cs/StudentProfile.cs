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

namespace Profile.cs
{
    public partial class StudentProfile : Form
    {
        SqlConnection con;
        SqlCommand Cmd;
        SqlDataReader dreader,RDR1,RDR2;
        SqlDataAdapter adp;
        DataSet ds;
        string Query,Query1,Query2;

        public StudentProfile()
        {
            InitializeComponent();
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Server=BLT205\\SQLEXPRESS;Database = StudentInfo; Integrated Security = true");
            con.Open();
            MessageBox.Show("I am here");

            adp = new SqlDataAdapter("select * from student", con);
            ds = new DataSet();
            adp.Fill(ds, "StudentInfo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Query = "Insert into student Values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox5.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox6.Text +"')";
            Cmd = new SqlCommand(Query, con);
            Cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox2.Focus();

            MessageBox.Show("Row Inserted Successfully...", "Insert");
        }

        private void button4_Click(object sender, EventArgs e)
        {//search button
            Cmd = new SqlCommand("Select * from student where No=" + textBox1.Text + "", con);
            try
            {
                dreader = Cmd.ExecuteReader();
                if(dreader.Read())
                {
                    textBox1.Text = dreader[0].ToString();
                    textBox2.Text = dreader[1].ToString();
                    textBox5.Text = dreader[2].ToString();
                    textBox3.Text = dreader[3].ToString();
                    textBox4.Text = dreader[4].ToString();
                    textBox6.Text = dreader[5].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Search");
                }
                dreader.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid Data");
            }
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are u sure you want to Exit?","Exit Application",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                con.Close();
                con = null;

                MessageBox.Show("No Connection is open", "Database Connection");
                Application.Exit();
            }            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Query5;
            Query5 = "Select * from student where No>(SELECT No FROM student where No="+textBox1.Text+")";
            Cmd = new SqlCommand(Query5, con);
            try
            {
                RDR2 = Cmd.ExecuteReader();
                if (RDR2.Read())
                {
                    textBox1.Text = RDR2[0].ToString();
                    textBox2.Text = RDR2[1].ToString();
                    textBox5.Text = RDR2[2].ToString();
                    textBox3.Text = RDR2[3].ToString();
                    textBox4.Text = RDR2[4].ToString();
                    textBox6.Text = RDR2[5].ToString();
                }
                else
                {
                    MessageBox.Show("No Records");
                }
                RDR2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Thrown");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Query6;
            Query6 = "Select * from student where No<(SELECT No FROM student where No=" + textBox1.Text + ") ORDER BY No DESC";
            Cmd = new SqlCommand(Query6, con);
            try
            {
                RDR2 = Cmd.ExecuteReader();
                if (RDR2.Read())
                {
                    textBox1.Text = RDR2[0].ToString();
                    textBox2.Text = RDR2[1].ToString();
                    textBox5.Text = RDR2[2].ToString();
                    textBox3.Text = RDR2[3].ToString();
                    textBox4.Text = RDR2[4].ToString();
                    textBox6.Text = RDR2[5].ToString();
                }
                else
                {
                    MessageBox.Show("No Records");
                }
                RDR2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Thrown");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                int i = 0;

                textBox1.Text = ds.Tables[0].Rows[i]["No"].ToString();
                textBox2.Text = ds.Tables[0].Rows[i]["Name"].ToString();
                textBox5.Text = ds.Tables[0].Rows[i]["Course"].ToString();
                textBox3.Text = ds.Tables[0].Rows[i]["Course_Fee"].ToString();
                textBox4.Text = ds.Tables[0].Rows[i]["Age"].ToString();
                textBox6.Text = ds.Tables[0].Rows[i]["Gender"].ToString();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form GridView = new Form();
            DataGridView view = new DataGridView();

            adp = new SqlDataAdapter("select * from student",con);
            DataSet grdset = new DataSet();
            adp.Fill(grdset, "StudentInfo");

            view.DataSource = grdset;
            view.DataMember = "StudentInfo";

            view.Location = new Point(100, 100);
            GridView.Controls.Add(view);

            GridView.StartPosition = FormStartPosition.CenterScreen;
            GridView.Height = 400;
            GridView.Width = 400;
            GridView.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Query4;
            Query4 = "Select * from student where No=(SELECT MAX(No) FROM student)";
            Cmd = new SqlCommand(Query4, con);
            try
            {
                RDR2 = Cmd.ExecuteReader();
                if (RDR2.Read())
                {
                    textBox1.Text = RDR2[0].ToString();
                    textBox2.Text = RDR2[1].ToString();
                    textBox5.Text = RDR2[2].ToString();
                    textBox3.Text = RDR2[3].ToString();
                    textBox4.Text = RDR2[4].ToString();
                    textBox6.Text = RDR2[5].ToString();
                }
                else
                {
                    MessageBox.Show("No Records");
                }
                RDR2.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Exception Thrown");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Query3;
            Query3 = "Select * from student";
            Cmd = new SqlCommand(Query3, con);
            try
            {
                RDR1 = Cmd.ExecuteReader();
                if(RDR1.Read())
                {
                    textBox1.Text = RDR1[0].ToString();
                    textBox2.Text = RDR1[1].ToString();
                    textBox5.Text = RDR1[2].ToString();
                    textBox3.Text = RDR1[3].ToString();
                    textBox4.Text = RDR1[4].ToString();
                    textBox6.Text = RDR1[5].ToString();
                }
                else
                {
                    MessageBox.Show("No Records");
                }
                RDR1.Close();
            }
            catch(Exception )
            {
                MessageBox.Show("Exception Thrown");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Query2 = "Delete from student where No=" + textBox1.Text + "";
            Cmd = new SqlCommand(Query2, con);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Query1 = "update student set Name='" + textBox2.Text + "',Course='" + textBox5.Text + "',Course_Fee='" + textBox3.Text + "',Age='" + textBox4.Text + "' ,Gender='" + textBox6.Text + "' where No='" + textBox1.Text + "'";
            Cmd = new SqlCommand(Query1, con);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated");
        }
    }
}
