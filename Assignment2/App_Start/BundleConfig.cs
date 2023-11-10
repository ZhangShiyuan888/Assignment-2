﻿using System.Web;
using System.Web.Optimization;

namespace Assignment2
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include("~/Scripts/MyJavaScript.js",
                "~/Scripts/check.js",
                "~/Scripts/Home-changePage.js",
                "~/Scripts/Details-select.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css","~/Content/StyleSheet1.css","~/Content/Photos-Style.css", "~/Content/Category-Style.css", "~/Content/Product-Edit-Style.css",
                      "~/Content/Creat-Style.css",
                      "~/Content/Product-Style.css",
                      "~/Content/Site.css"));
        }
    }
}
