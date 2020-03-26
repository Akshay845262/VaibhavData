using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace WebForm
{
    public class DataLayer
    {
        SqlDataReader dr;
        private string constr=" ";
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        }
        public DataSet Showdata(string s1)
        {
            string selectquery = "select * from Customers where Country='"+s1+"'";
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ds;
        }
        public string Showdata1(string s)
        {
            string Price = " ";
            string selectquery = "Select UnitPrice from Products where ProductName='" + s + "'";
            
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(selectquery, con);
                    dr = cmd.ExecuteReader();
                    //SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    while(dr.Read())
                    {
                        Price = dr[0].ToString();
                    }
                  
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Price;
        }
    }
}