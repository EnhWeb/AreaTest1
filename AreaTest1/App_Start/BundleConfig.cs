using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaTest1
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(System.Web.Optimization.BundleCollection bundles)
        {
            bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new System.Web.Optimization.StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/normalize.css",
                      "~/Content/site.css"
                      ));
        }
    }


}