﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstituteWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}