using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AreaTest1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(System.Web.Mvc.GlobalFilterCollection filters)
        {
            filters.Add(new System.Web.Mvc.HandleErrorAttribute());
        }
    }
}