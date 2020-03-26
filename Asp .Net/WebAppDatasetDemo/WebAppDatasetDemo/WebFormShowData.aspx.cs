using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDatasetDemo
{
    public partial class WebFormShowData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DataLayer dl = new DataLayer();
                var pdlst = dl.Showdata();
                GridView1.DataSource = pdlst;
                GridView1.DataBind();
            }
        }
    }
}