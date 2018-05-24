using System.Web;
using System.Web.Optimization;

namespace MLRDWEB
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/assets/js/jquery-3.2.1.min.js",
                        "~/assets/js/popper.min.js",
                        "~/assets/js/bootstrap.min.js",
                        "~/assets/js/jquery.sticky.js",
                        "~/assets/js/owl.carousel.min.js",
                        "~/assets/js/jquery.shuffle.min.js",
                        "~/assets/js/jquery.counterup.min.js",
                        "~/assets/js/wow.min.js",
                        "~/assets/js/jquery.meanmenu.min.js",
                        "~/assets/js/jquery.magnific-popup.min.js",
                        "~/assets/js/jquery.hoverdir.js",
                        "~/assets/js/custom.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/style.css",
                      "~/assets/css/responsive.css"));
        }
    }
}
