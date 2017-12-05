using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetCareApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EnterSystem(string email, string password)
        {
            ViewBag.email = email;
            ViewBag.password = password;

            if (password == "doctor")
            {
                return View();
            }else if (password == "admi")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }

            
        }
    }
}