using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/Content/Scripts", "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.5.1.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Style.css"));
            bundles.Add(new ScriptBundle("~/Scripts/").Include(
                      "~/Scripts/SlideShow.js"));
            bundles.Add(new ScriptBundle("~/Content/Scripts", "https://kit.fontawesome.com/3c03c97ac7.js"));
            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;
        }
    }
}
