using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteWebApp.Controllers
{
    public class HostelController : Controller
    {
        // GET: Hostel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HostelAttendance()
        {
            return View();
        }
        public ActionResult HostelEmployee()
        {
            return View();
        }
        public ActionResult HostelRegistration()
        {
            return View();
        }
        public ActionResult HostelRoom()
        {
            return View();
        }

    }
}