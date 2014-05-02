using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace angularjs_webapi_demo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/lib").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Client/lib/highstock/highstock.js",
                "~/Client/lib/clippy/clippy.js",
                "~/Scripts/angular.js",
                "~/Scripts/angular-route.js",
                "~/Scripts/angular-strap.js",
                "~/Scripts/angular-strap.tpl.js"));

            bundles.Add(new ScriptBundle("~/Scripts/app").Include(
                "~/Client/app.js",
                "~/Client/overview/overviewCtrl.js",
                "~/Client/details/detailsCtrl.js",
                "~/Client/components/stockChartDirective.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/lib/clippy/clippy.css",
                "~/Content/bootstrap.css"));
        }
    }
}