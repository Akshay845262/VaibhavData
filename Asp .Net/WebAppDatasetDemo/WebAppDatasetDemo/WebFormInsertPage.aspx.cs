using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDatasetDemo
{
    public partial class WebFormInsertPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            int NO = Convert.ToInt32(TextBox1.Text);
            string Name = TextBox2.Text;
            string Course = TextBox3.Text;
            double Fee=Convert.ToDouble(TextBox4.Text);
            int Age = Convert.ToInt32(TextBox5.Text);
            string Gender = TextBox6.Text;
            student std = new student { NO = NO, Name = Name, Course = Course, Fee = Fee, Age = Age, Gender = Gender };
            DataLayer dlr = new DataLayer();
            dlr.InsertaStudent(std);
        }

        protected void Delete_Button(object sender, EventArgs e)
        {
            int idno = Convert.ToInt32(TextBox1.Text);
            student std1 = new student { NO = idno };
            DataLayer dlr = new DataLayer();
            dlr.DeleteData(std1);
        }

        protected void Update_Button(object sender, EventArgs e)
        {
            int idno = Convert.ToInt32(TextBox1.Text);
            string name = TextBox2.Text;
            student std2 = new student { NO = idno, Name = name };
            DataLayer dlr = new DataLayer();
            dlr.UpdateData(std2);
        }

        protected void Show_Button(object sender, EventArgs e)
        {
            student std2 = new student();
            DataLayer dlr = new DataLayer();
            dlr.UpdateData(std2);
        }
    }
}