﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetCareApp.DataAccess;
using PetCareApp.Models;

namespace PetCareApp.Controllers
{
    public class LoginController : Controller
    {
        private PetCareContext db = new PetCareContext();        
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoLogin(string username, string password)
        {
            User user = db.Users.FirstOrDefault(u => u.Username.Equals(username));

            if (user != null && user.Password.Equals(password))
            {
                Session["LoggedUser"] = user;
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
    }
}