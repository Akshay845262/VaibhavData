using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }
        public ActionResult CreatePersonForm()
        {
            return View(new Person());
        }
        public ActionResult CreatePersonRouteForm()
        {
            return View(new Person());
        }
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "NewYork", "London", "Paris" };
            string message = "This is HTML element:<input>";
            return View((object)message);
        }
        public ActionResult InlineHelper()
        {
            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "NewYork", "London", "Paris" };
            string message = "This is HTML element:<input>";
            return View((object)message);
        }
        public ActionResult ExternalHelper()
        {
            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "NewYork", "London", "Paris" };
            string message = "This is HTML element:<input>";
            return View((object)message);
        }
    }
}