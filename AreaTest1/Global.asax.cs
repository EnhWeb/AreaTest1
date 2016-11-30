using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AreaTest1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //注册ASP.NET MVC应用程序中的所有区域
            AreaRegistration.RegisterAllAreas();
            
            //注册全局S选器集合
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);


            //注册路由表中路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);




            //注册邦定和微小
            BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);

            CYQ.Data.AppDebug.Start();
        }

        
    }
}
