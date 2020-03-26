using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebForm
{
    public partial class Demo : System.Web.UI.Page
    {
        SqlCommand cmd;
        SqlDataReader reader;
        private string constr = " ";
        protected void Page_Load(object sender, EventArgs e)
        {
            constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            string fetchquery = "select distinct ProductName from Products";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(fetchquery, con);
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    DropDownList2.Items.Add(reader[0].ToString());
                }
                con.Close();
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedItem.Value;
            
            DataLayer d1 = new DataLayer();

            var pdlst = d1.Showdata(s);
            GridView1.DataSource = pdlst;
            GridView1.DataBind();

                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

        }

        
        protected void DropDownList2_vaibhav(object sender, EventArgs e)
        {
            string s1 = DropDownList2.SelectedItem.Value;
            DataLayer d2 = new DataLayer();
            var price = d2.Showdata1(s1);
            TextBox2.Text = price.ToString();
        }
    }
}