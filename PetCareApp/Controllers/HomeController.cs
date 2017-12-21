using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using PetCareApp.DataAccess;
using PetCareApp.Filters;
using PetCareApp.ModelView.Home;

namespace PetCareApp.Controllers
{
    [AdminAuthorizationFilter]
    public class HomeController : Controller
    {
        private PetCareContext db = new PetCareContext();

        public ActionResult Index()
        {
            //  https://msdn.microsoft.com/en-us/library/jj592907(v=vs.113).aspx
           /*var speciesChartItems = db.SpeciesChartItems.SqlQuery(
                    "SELECT s.Name AS Name, COUNT(p.Id) AS Count FROM Pet p INNER JOIN Species s ON p.SpeciesId = s.Id GROUP BY s.Name")
                .ToList();
            var homeModel = new HomeModel();
            homeModel.SpeciesChartItems = speciesChartItems;*/

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