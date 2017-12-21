using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using PetCareApp.Filters;

namespace PetCareApp.Controllers
{
    [AdminAuthorizationFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChangeTheme(string theme, string url)
        {
            if (theme != null)
            {
                Session["theme"] = theme;
            }

            return new RedirectResult(url);
        }
    }
}