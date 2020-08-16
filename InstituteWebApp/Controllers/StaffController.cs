using InstituteWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteWebApp.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Experience()
        {
            return View();
        }
        public ActionResult Labor()
        {
            return View();
        }
        public ActionResult StaffEducationalBackground()
        {
            return View();
        }
        public ActionResult Teacher()
        {
            return View();
        }
    }
}