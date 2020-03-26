using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeminarInvites.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            return View();
        }
        public String Index1()
        {
            string s = "<h1>Jai Maharastra..!</h1>";
            return s;
        }
        public int sum()
        {
            int a = 10, b = 30, sum;
            sum = a + b;
            return sum;
        }
    }
}