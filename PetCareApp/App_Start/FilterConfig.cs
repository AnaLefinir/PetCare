using System.Web;
using System.Web.Mvc;
using PetCareApp.Filters;

namespace PetCareApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ThemeActionFilterAttribute());
            //filters.Add(new AuthorizeAttribute());
            //filters.Add(new AdminAuthorizationFilterAttribute());
        }
    }
}
