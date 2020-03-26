﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcFilters.Controllers
{
    public class SiteAccountController : Controller
    {
        // GET: SiteAccount
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, string returnUrl)
        {
            if(username.EndsWith("@google.com")&&password=="secret")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            else
            {
                ModelState.AddModelError("", "Google authentication: Incorrect username or password");
                return View();
            }
        }
    }
}