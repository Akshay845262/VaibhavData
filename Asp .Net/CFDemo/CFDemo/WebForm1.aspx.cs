using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CFDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeDBContext edbc = new EmployeeDBContext();
            edbc.Departments.Add(new Department()
            {
                Name = "Sales",
                Location = "Lucknow"
            });
            edbc.SaveChanges();
        }
    }
}