﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CsManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ตั้น";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "เทสสอง";

            return View();
        }
    }
}