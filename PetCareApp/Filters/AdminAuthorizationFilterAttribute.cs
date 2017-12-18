using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetCareApp.Filters
{
    public class AdminAuthorizationFilterAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            
            // TODO: Hay que customizar de acuerdo al usuario
            filterContext.Controller.ViewBag.IsAdmin = filterContext.HttpContext.Request.QueryString["isAdmin"] == "true";
        }
    }
}