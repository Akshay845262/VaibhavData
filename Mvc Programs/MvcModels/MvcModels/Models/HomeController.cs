using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Models
{
    public class HomeController : Controller
    {
        private Person[] personData =
        {
            new Person{PersonID=1,FirstName="Adam",LastName="Freeman",
            Role = Role.Admin},
            new Person{PersonID=2,FirstName="Sharukh",LastName="Khan",
            Role = Role.User},
            new Person{PersonID=3,FirstName="Johny",LastName="Waker",
            Role = Role.User},
            new Person{PersonID=4,FirstName="Satya",LastName="Narayan",
            Role = Role.Guest}
        };
        public ActionResult GetPerson(int id)
        {
            Person dataItem = personData.Where(p => p.PersonID == id).First();
            return View(dataItem);
        }
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("GetPerson",model);
        }
        public ActionResult DisplaySummary([Bind(Prefix ="HomeAddress")]AddressSummary summary)
        {
            return View(summary);
        }
        public ActionResult GetNames(IList<string> names)
        {
            names = names ?? new List<string>();
            return View(names);
        }
        // GET: Home
        public ActionResult Index(int id)
        {
            ViewBag.Value = id;
            return View();
        }
        public ActionResult Message(string id)
        {
            ViewBag.Message = id;
            return View();
        }
        public ActionResult Address(IList<AddressSummary>addresses)
        {
            addresses = addresses ?? new List<AddressSummary>();
            return View(addresses);
        }
    }
}