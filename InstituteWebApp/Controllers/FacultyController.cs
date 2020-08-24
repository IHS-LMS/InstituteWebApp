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

        [HttpPost]
        public ActionResult Course(Course course)
        {
            using (KIHSEntities db = new KIHSEntities())
            {
                db.Courses.Add(course);
                db.SaveChanges();
                int id = course.ID;
            }
            return View(course);
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