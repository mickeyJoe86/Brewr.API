﻿using System.Web;
using System.Web.Optimization;

namespace Brewr
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/vendor/bootstrap/dist/css/bootstrap.min.css",
                      "~/vendor/startbootstrap-sb-admin-2/dist/css/sb-admin-2.css",
                      "~/vendor/font-awesome/css/font-awesome.min.css",
                      "~/Content/site.css"
                      ));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                      "~/vendor/jquery/dist/jquery.min.js",
                      "~/vendor/bootstrap/dist/js/bootstrap.min.js",
                      "~/vendor/startbootstrap-sb-admin-2/dist/css/timeline.css"));

            bundles.Add(new ScriptBundle("~/Angular/Lib").Include(
                       "~/vendor/angular/angular.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/Angular/Modules").Include(
                        "~/app/app.js",
                        "~/app/mainController.js"));

            bundles.Add(new ScriptBundle("~/Angular/Services").Include());
        }
    }
}
