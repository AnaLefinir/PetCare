using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetCareApp.DataAccess;
using PetCareApp.Models;

namespace PetCareApp.Controllers
{
    public class PetController : Controller
    {
        private  PetCareContext db = new PetCareContext();
        // GET: Pet
        public ActionResult Index()
        {
            Console.Write("Here!");
            return View(db.Pets.ToList());
        }
    }
}