using System.Web;
using System.Web.Optimization;

namespace InTouch_WEBClient
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
//            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            var lessBundle = new Bundle("~/Content/less");
            lessBundle.Include("~/Content/*.less");
            lessBundle.Transforms.Add(new ProcessLess());
            lessBundle.Transforms.Add(new CssMinify());
            bundles.Add(lessBundle);
        }
    }
}
