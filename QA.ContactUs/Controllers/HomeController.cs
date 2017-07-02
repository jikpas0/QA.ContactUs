using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QA.ContactUs.Models;

namespace QA.ContactUs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Contact contact)
        {
            //redirect page to another view or display message sent 
            ViewBag.MessageSent = "";
            if (contact != null)
            {
                ViewBag.MessageSent = "Message has been sent";
            }
            return View();
        }
    }
}