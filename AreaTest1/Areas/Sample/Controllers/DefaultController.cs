using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest1.Areas.Sample.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Sample/Default
        public ActionResult Index()
        {
            

            return View();
        }


        public ActionResult Query()
        {
            CYQ.Data.MAction m = new CYQ.Data.MAction("View_User1");

           // {"page":"1","total":"2","records":"13",  
            //* "rows":[ 

            var date = m.Select("").ToJson();

            


            return Content(date, "application/json", System.Text.Encoding.UTF8);
        }

        // GET: Sample/Default/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sample/Default/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sample/Default/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Default/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sample/Default/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sample/Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sample/Default/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
