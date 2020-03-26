using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebAppDatasetDemo
{
    public class DataLayer
    {
        private string constr = " ";
        public DataLayer()
        {
            try
            {
                constr = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string InsertaStudent(student std)
        {
          string insertquery  = String.Format("insert into student(No,Name,Course,Course_Fee,Age,Gender)values({0},'{1}','{2}',{3},{4},'{5}')",std.NO,std.Name,std.Course,std.Fee,std.Age,std.Gender);
            DataSet ds = new DataSet();
            int i = 0;
            string msg = " ";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(insertquery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    i = da.Fill(ds);
                    da.Update(ds);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
            if(i>0)
            {
                msg = string.Format("one row inserted into the table");
            }
            return msg;
        }
        public DataSet UpdateData(student s1)
        {
            string Updatequery = String.Format("update student set Name='{1}' where NO={0}", s1.NO, s1.Name);
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(Updatequery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    da.Update(ds);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
            return ds;

        }
        public DataSet DeleteData(student s)
        {
            string deletequery = String.Format("delete from student where NO={0}", s.NO);
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(deletequery, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    da.Update(ds);
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
            }
            return ds;
        }
        
        public DataSet Showdata()
        {
            string selectquery = "select * from student";
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
            catch(Exception ex)
            {
               throw new Exception(ex.Message);
            }
            return ds;
        }
    }
}