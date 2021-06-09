﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    [Authorize]
    [HandleError(View = "Error")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Dashboard","Agent");
        }
        public ActionResult Agents()
        {
            return RedirectToAction("GetAllEmployee", "Employee");
        }
        [Authorize (Roles="Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}