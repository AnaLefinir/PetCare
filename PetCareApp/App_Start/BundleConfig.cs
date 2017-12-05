using System.Web;
using System.Web.Optimization;

namespace PetCareApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/Login").Include(
                "~/Content/login.css"));


            bundles.Add(new StyleBundle("~/Content/AdmiIndex").Include(
                "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                "~/Content/vendor/font-awesome/css/font-awesome.min.css",
                "~/Content/css/font.css",
                "~/Content/css/style.default.css",
                "~/Content/css/custom.css"
                ));

            bundles.Add(new ScriptBundle("~/Content/jsadmi").Include(
                "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                "~/Content/vendor/chart.js/Chart.min.js",
                "~/Content/vendor/chart.js/Chart.min.js",
                "~/Content/js/charts-home.js",
                "~/Content/js/front.js"));

            bundles.Add(new StyleBundle("~/Content/Admin").Include(
                "~/Content/admin.css"));
        }
    }
}
