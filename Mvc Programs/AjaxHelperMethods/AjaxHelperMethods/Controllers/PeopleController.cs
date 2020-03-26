using AjaxHelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxHelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private Person[] personData =
        {
            new Person{FirstName="Adam",LastName="Freeman",Role=Role.Admin},
            new Person{FirstName="Jackie",LastName="Shroff",Role=Role.User},
            new Person{FirstName="John",LastName="Smith",Role=Role.User},
            new Person{FirstName="Sharukh",LastName="Khan",Role=Role.Guest}
        };
        //[ChildActionOnly]
        public PartialViewResult GetPeopleData(string selectedRole="All")
        {
            IEnumerable<Person> data = personData;
            if(selectedRole !="All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
        // GET: People
        public ActionResult GetPeople(string selectedRole ="All")
        {
            return View((object)selectedRole);
        }
        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{
        //    if(selectedRole==null||selectedRole=="All")
        //    {
        //        return View(personData);
        //    }
        //    else
        //    {
        //        Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        return View(personData.Where(p => p.Role == selected));
        //    }
        //}
    }
}