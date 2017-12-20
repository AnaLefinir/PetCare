using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetCareApp.Models;

namespace PetCareApp.Filters
{
    public class AdminAuthorizationFilterAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = filterContext.HttpContext.Session["LoggedUser"];
            if (user == null)
            {
                filterContext.Result = new RedirectResult("~/Login/Index");
                
                return;
            }
            
            filterContext.Controller.ViewBag.IsAdmin = ((Vet) user).IsAdmin;
        }
    }
}