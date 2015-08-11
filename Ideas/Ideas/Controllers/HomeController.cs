﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ideas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult Ideas()
        {
            ViewBag.Message = "Data storage of any interesting ideas";

            return View();
        }

        public ActionResult Chat()
        {
            ViewBag.Message = "Signal R Practice!";

            return View();
        }
    }
}