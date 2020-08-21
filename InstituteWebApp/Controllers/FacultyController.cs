using InstituteWebApp.Models;
using System;
using System.Collections.Generic;
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
        public JsonResult GetCourseData(Course course)
        {
            return Json(course, JsonRequestBehavior.AllowGet);
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