﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace PetCareApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IsAdmin = Request.QueryString["isAdmin"] == "true" ;
            string theme = Request.QueryString["theme"];
            ViewBag.Theme = theme ?? "dark";

            return View();
        }
    }
}