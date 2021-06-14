using System.Web;
using System.Web.Optimization;

namespace RoyalAirlines
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.easing.1.3.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/datatables/datatables.bootstrap.js",
                        "~/Scripts/jquery.waypoints.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/jquery.countTo.js",
                        "~/Scripts/jquery.stellar.min.js",
                        "~/Scripts/jquery.magnific-popup.min.js",
                        "~/Scripts/magnific-popup-options.js",
                        "~/Scripts/bootstrap-datepicker.min.js",
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/animate.css",
                      "~/Content/icomoon.css",
                      "~/Content/themify-icons.css",
                      "~/Content/bootstrap.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/bootstrap-datepicker.min.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/owl.theme.default.min.css",
                      "~/Content/datatables/css/datatables.bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
