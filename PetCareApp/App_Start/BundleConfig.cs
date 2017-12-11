using System.Web;
using System.Web.Optimization;

namespace PetCareApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                "~/Content/bootstrap.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/Content/templates/darkadmin/dark").Include(
                "~/Content/themes/darkadmin/css/font.css",
                "~/Content/themes/darkadmin/css/style.dark.css"
            ));

            bundles.Add(new StyleBundle("~/Content/templates/darkadmin/white").Include(
                "~/Content/themes/darkadmin/css/font.css",
                "~/Content/themes/darkadmin/css/style.white.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/umd/popper.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/templates/darkadmin").Include(
                "~/Content/themes/darkadmin/js/front.js"
            ));
            //Login view
            bundles.Add(new StyleBundle("~/Content/views/login").Include(
                "~/Content/views/login.css"));

            //Home view
            bundles.Add(new StyleBundle("~/Content/views/home").Include(
                "~/Content/views/home.css"));
           
        }
    }
}
