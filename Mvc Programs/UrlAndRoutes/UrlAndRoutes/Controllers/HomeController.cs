﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }
    }
}