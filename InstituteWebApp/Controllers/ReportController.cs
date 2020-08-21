using InstituteWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteWebApp.Controllers
{
    public class ReportController : Controller
    {
        KIHSEntities db = new KIHSEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SendIndexData()
        {
            List<Student> st = db.Students.ToList();
            return this.Json(st, JsonRequestBehavior.AllowGet);
        }
    }
}