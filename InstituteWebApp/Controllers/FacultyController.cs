using InstituteWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteWebApp.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Faculty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Course()
        {
            return View();
        }
        public ActionResult GetCourseData(Course course)
        {
            //KIHSEntities db = new KIHSEntities();
            //Course c = new 
            //return Json(course, JsonRequestBehavior.AllowGet);
            using (KIHSEntities db = new KIHSEntities())
            {
                db.Database.ExecuteSqlCommand($"INSERT INTO Department.Course (CourseName) VALUES ('"+course.CourseName+"')");
            }

            return null;
        }
            public ActionResult CourseTimetable()
        {
            return View();
        }
        public ActionResult ExamTimetable()
        {
            return View();
        }
        public ActionResult StudentNightshift()
        {
            return View();
        }
        public ActionResult TeacherCoordinator()
        {
            return View();
        }
    }
}