﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADMINKOMIKA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashBoard()
        {
            return View();
        }
    }
}