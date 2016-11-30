using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Viyi.Util



            


            return View();
        }




        public class UserBen
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int age { get; set; }
        }


        [HttpGet]
        /// <summary>
        /// Json测式 进行自定义格式json对像输出 http://localhost:5193/home/jsontest
        /// </summary>
        /// <returns>json结果</returns>
        public ActionResult JsonTest()
        {
            UserBen[] user = new UserBen[] 
            { 
                new UserBen { age = 1, Name = "Tomato Soup", Email = "123@qq.com" }, 
                new UserBen { age = 2, Name = "Yo-yo", Email = "1234@qq.com" }, 
                new UserBen { age = 3, Name = "Hammer", Email = "12345@qq.com" } 
            };
            var result = new
            {
                pagecount=56,
                pagesize=10,
                tatal=558,
                user=user
            };
            return Json(result, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
            //return new JsonResult() { JsonRequestBehavior= JsonRequestBehavior.AllowGet, Data=new {falses="fsad",l1=23,users=user} };
        }

        /// <summary>
        /// 得到IP地址对应的 真实地址 http://localhost:5193/home/GetIpAddress
        /// 数据库会自动从网站本地目录搜索（搜索文件名为："qqwry.dat", "qqwry.gz", "ip.gz", "ip.gz.config", "ipdata.config" ），如果搜索不到则进行自动下载
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public ActionResult GetIpAddress(string ip)
        {
            var result = new
            {
                ip = NewLife.IP.Ip.GetAddress("202.203.96.68"),
                dbpath = AppDomain.CurrentDomain.BaseDirectory,
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        }





    }
}