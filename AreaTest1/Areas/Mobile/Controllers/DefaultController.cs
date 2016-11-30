using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest1.Areas.Mobile.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Mobile/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}