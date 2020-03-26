using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JavaScriptDemo.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sort()
        {
            return View();
        }
        public ActionResult Loop()
        {
            return View();
        }
        public ActionResult ErrorHandling()
        {
            return View();
        }
        public ActionResult FindElement()
        {
            ViewBag.className = "intro";
            ViewBag.Message = "This is msg from ViewBag";
            return View();
        }
        public ActionResult ChangeEvent()
        {
            return View();
        }
        public ActionResult MouseEvent()
        {
            return View();
        }
        public ActionResult EventBubble()
        {
            return View();
        }
        public ActionResult CheckCookies()
        {
            return View();
        }
        public ActionResult CreateDomElement()
        {
            return View();
        }
        public ActionResult RemoveDomElement()
        {
            return View();
        }
    }
}