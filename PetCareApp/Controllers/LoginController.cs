using System;
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
        public ActionResult DoLogin(string email, string password)
        {
            Vet vet = db.Vets.FirstOrDefault(u => u.Email.Equals(email));

            if (vet != null && vet.Password.Equals(password))
            {
                Session["LoggedUser"] = vet;
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
    }
}