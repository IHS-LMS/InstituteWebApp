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
        // GET: Report
        public ActionResult Index()
        {
            KIHSEntities db = new KIHSEntities();
            Student student = db.Students.SingleOrDefault(x => x.ID == 2);

            ReportViewModel svm = new ReportViewModel();
            svm.FullName = student.FullName;

            return View(svm);
        }
    }
}