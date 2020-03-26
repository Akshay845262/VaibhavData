using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public string Index(string id)
        {
            return "you entered " + id;
        }
    }
}