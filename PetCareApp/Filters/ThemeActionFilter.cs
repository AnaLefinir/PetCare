using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;

namespace PetCareApp.Filters
{
    public class ThemeActionFilterAttribute : ActionFilterAttribute
    {
        private string DefaultTheme = "dark";// TODO: Cambiar a white!

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string theme = (string)filterContext.HttpContext.Session["theme"];
            filterContext.Controller.ViewBag.Theme = theme ?? DefaultTheme;
        }
    }
}