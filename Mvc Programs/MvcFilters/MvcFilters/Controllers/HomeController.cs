using MvcFilters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcFilters.Controllers
{
    public class HomeController : Controller
    {
        //[CustomAction]
        //[ProfileAction]
        //[ProfileResult]
        [ProfileAll]
        public string FilterTest()
        {
            System.Threading.Thread.Sleep(2000);
            return "This is the FilterTest action";
        }
        [HandleError(ExceptionType =typeof(ArgumentOutOfRangeException),View ="RangeError")]
        public string RangeTest(int id)
        {
            if(id>100)
            {
                return string.Format("The Value of id:{0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }
        // GET: Home
        //public string Index()
        //{
        //    if(!Request.IsAuthenticated)
        //    {
        //        FormsAuthentication.RedirectToLoginPage(); 
        //    }

        //    return "This is index action method from home controller";
        //}
        [OutputCache(Duration = 10, VaryByParam= "none", Location = System.Web.UI.OutputCacheLocation.Client)]
        public string Index()
        {
            return String.Format("This Index page rendered at {0}", DateTime.Now);
        }

        public string Edit()
        {
            if(!Request.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            return "This is edit method of home controller";
        }
        public string Create()
        {
            if (!Request.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            return "This is create method of home controller";
        }

    }
}