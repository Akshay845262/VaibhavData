using MvcFilters.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFilters.Controllers
{
    [Authorize(Users="user@google.com,user,admin")]
    
    public class ProductController : Controller
    {
        [SiteAuthentication]
        // GET: Product
        public string Index()
        {
            return "This is Index action method from Product controller";
        }
        public string Edit()
        {
            return "This is Edit method of Product controller";
        }
        public string Create()
        {
            return "This is create method of Product controller";
        }
    }
}