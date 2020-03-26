using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult MakeBooking()
        {
            return View(new Appointment { Date = DateTime.Now });
        }
        [HttpPost]
        public ViewResult MakeBooking(Appointment appt)
        {
            //if(string.IsNullOrEmpty(appt.ClientName))
            //{
            //    ModelState.AddModelError("ClientName", "Please Enter Your Name");
            //}
            //if(ModelState.IsValidField("Date")&& DateTime.Now>appt.Date)
            //{
            //    ModelState.AddModelError("Date", "Please Enter a Date in the future");
            //}
            //if(!appt.TermsAccepted)
            //{
            //    ModelState.AddModelError("TermsAccepted", "You must accept the terms");
            //}
            if(ModelState.IsValidField("ClientName")&&ModelState.IsValidField("Date")
                &&appt.ClientName=="VaibhavRaj" && appt.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                ModelState.AddModelError("","VaibhavRaj cannot book appointment on Sundays");
            }
            if (ModelState.IsValid)
            {
                //statements to store new appointment in a
                //repository would go here in a real project.
                return View("Completed", appt);
            }
            else
            {
                return View();
            }
        }
        public JsonResult ValidateDate(string Date)
        {
            DateTime parsedDate;
            if(!DateTime.TryParse(Date, out parsedDate))
            {
                return Json("Please enter a valid date(mm/dd/yyyy)",
                    JsonRequestBehavior.AllowGet);
            }
            else if(DateTime.Now>parsedDate)
            {
                return Json("Please enter a date in the future",
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}