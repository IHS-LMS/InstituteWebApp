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

        // GET: Report
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}