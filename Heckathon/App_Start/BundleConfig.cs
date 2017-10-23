using System.Web;
using System.Web.Optimization;

namespace Heckathon
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

           
            bundles.Add(new StyleBundle("~/css")
              .Include("~/Content/css/ngDialog-theme-default.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/ngDialog.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/angular-block-ui.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/site.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/dell-ui-bootstrap.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/fonts.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/masthead.css", new CssRewriteUrlTransformWrapper())
              .Include("~/Content/css/layout.css", new CssRewriteUrlTransformWrapper())
              );
        }

        public class CssRewriteUrlTransformWrapper : IItemTransform
        {
            public string Process(string includedVirtualPath, string input)
            {
                return new CssRewriteUrlTransform().Process("~" + VirtualPathUtility.ToAbsolute(includedVirtualPath), input);
            }
        }
    }
}
