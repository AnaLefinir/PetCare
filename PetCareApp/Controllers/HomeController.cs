using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using PetCareApp.DataAccess;
using PetCareApp.Filters;
using PetCareApp.Models;
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
            // https://www.mikesdotnetting.com/article/299/entity-framework-code-first-and-stored-procedures
            var speciesChartItems = db.Database.SqlQuery<SpeciesChartItem>(
                    "SELECT s.Name AS Name, COUNT(p.Id) AS Count FROM Pet p INNER JOIN Species s ON p.SpeciesId = s.Id GROUP BY s.Name")
                .ToList();
            var homeModel = new HomeModel();
            homeModel.SpeciesChartItems = speciesChartItems;

            var incomechartItems = db.Database
                .SqlQuery<IncomeChartItem>(
                    "SELECT TOP 4 YEAR(v.VisitDate) AS 'Year', MONTH(v.VisitDate) AS 'Month', SUM(v.VisitPrice) AS Income FROM Visit v GROUP BY YEAR(v.VisitDate), MONTH(v.VisitDate) ORDER BY YEAR(v.VisitDate), MONTH(v.VisitDate) DESC")
                .ToList();
            homeModel.IncomeChartItems = incomechartItems;

            return View(homeModel);
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