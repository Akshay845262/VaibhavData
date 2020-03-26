using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultSamples.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public RedirectToRouteResult RedirectAction()
        {
            return RedirectToAction("Index", "Admin", "MyIdValue"); 
        }
        public ContentResult getContent()
        {
            return Content("Sample Text", "text");
        }
        public JavaScriptResult getScript()
        {
            return JavaScript(@" function getmsg() {alert('script alert from MVC')}");
        }
        public HttpUnauthorizedResult AuthPage(string id)
        {
            return new HttpUnauthorizedResult("You are not authorised to view this content");
        }
    }
}