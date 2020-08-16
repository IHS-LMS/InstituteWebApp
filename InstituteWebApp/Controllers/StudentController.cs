using InstituteWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebSockets;

namespace InstituteWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Score()
        {
            return View();
        }
        public ActionResult StudentAttendance()
        {
            return View();
        }
        public ActionResult StudentJob()
        {
            return View();
        }
    }
}