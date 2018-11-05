using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADMINKOMIKA.DAL;
using ADMINKOMIKA.Models;
using System.Web.Mvc;

namespace ADMINKOMIKA.Controllers
{
    public class LoginController : Controller
    {
        private DALLogin DAL = new DALLogin();
        // GET: Login
        public ActionResult Index()
        {
            Session.Clear();
            return View(new Login());
        }

        [HttpPost]
        public ActionResult Index(Login get)
        {
            if (DAL.passwordistrue(get))
            {
                Session["UserName"] = get.username;
                return RedirectToAction("DashBoard", "Home", new { });
            }
            else
            {
                return View(new Login() { validationtext = "Wrong Password" });
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login", new { });
        }
    }
}