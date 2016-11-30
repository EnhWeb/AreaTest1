using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaTest1.Areas.Sample.Controllers
{
    public class JqueryBootGridController : Controller
    {
        // GET: Sample/JqueryBootGrid
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 为jquery BootGrid 提供数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">页大小</param>
        /// <param name="sord">排序方式</param>
        /// <param name="searchPhrase">搜索参数</param>
        /// <param name="sidx">排序字段</param>
        /// <returns>json格式结果字符串</returns>
        public JsonResult GetDatas(int page = 2, int rows = 25, string sord = "asc",string searchPhrase = "", string sidx = "Id")
        {
            var mb = new
            {
                Id = 1,
                UserName = "张三",
                PassWord = "test123",
                Mobile = 15811111111,
                Email = "zshan@qq.com",
                CreateTime = DateTime.Now,
                RegClientIp = "158.56.55.236",
                CurrentClientIp = "127.0.0.1"
            };

            #region #    List定义
            List<UserModel> list = new List<UserModel>(30000)
            {
                new UserModel() { Id=1,  UserName="张三", PassWord="test123", Mobile=15811111111, Email="zshan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=2,  UserName="李四", PassWord="test123", Mobile=15811111111, Email="234@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=3,  UserName="王三", PassWord="test123", Mobile=15811111111, Email="345345@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=4,  UserName="五个", PassWord="test123", Mobile=15811111111, Email="ertetr@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=5,  UserName="王五", PassWord="test123", Mobile=15811111111, Email="dgfdgf@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=6,  UserName="刘六", PassWord="test123", Mobile=15811111111, Email="cvbcvb@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=7,  UserName="李七", PassWord="test123", Mobile=15811111111, Email="asdasd@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=8,  UserName="李白", PassWord="test123", Mobile=15811111111, Email="sfdsdf@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=9,  UserName="张四", PassWord="test123", Mobile=15811111111, Email="cvbcvb@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=10, UserName="国家", PassWord="test123", Mobile=15811111111, Email="ghjghj@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=11, UserName="地震", PassWord="test123", Mobile=15811111111, Email="jlkjkljkl@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=12, UserName="有关", PassWord="test123", Mobile=15811111111, Email="ghjgjhgjhgjh@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=13, UserName="人员", PassWord="test123", Mobile=15811111111, Email="zshartnryqq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=14, UserName="我国", PassWord="test123", Mobile=15811111111, Email="zshadgfdgfn@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=15, UserName="一个", PassWord="test123", Mobile=15811111111, Email="zshsfdsfan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=16, UserName="在于", PassWord="test123", Mobile=15811111111, Email="zssfdsdfhan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=17, UserName="是否", PassWord="test123", Mobile=15811111111, Email="zcvbcvbshan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=18, UserName="工作", PassWord="test123", Mobile=15811111111, Email="zhgjgshan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=19, UserName="了解", PassWord="test123", Mobile=15811111111, Email="ztyutyushadn@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=20, UserName="以及", PassWord="test123", Mobile=15811111111, Email="zshrerean@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=21, UserName="于有", PassWord="test123", Mobile=15811111111, Email="zshddxcvfgan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=22, UserName="地方", PassWord="test123", Mobile=15811111111, Email="zshfdgan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=23, UserName="地下", PassWord="test123", Mobile=15811111111, Email="zshaxvcdfgdfgn@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=24, UserName="一种", PassWord="test123", Mobile=15811111111, Email="zshanxcvs@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=25, UserName="上面", PassWord="test123", Mobile=15811111111, Email="zshdsdan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=26, UserName="不堪", PassWord="test123", Mobile=15811111111, Email="zsfsdfhan@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=27, UserName="是要", PassWord="test123", Mobile=15811111111, Email="zshaxcvn@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=28, UserName="中毒", PassWord="test123", Mobile=15811111111, Email="zshasfdwern@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=29, UserName="国际", PassWord="test123", Mobile=15811111111, Email="1233132@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=30, UserName="民族", PassWord="test123", Mobile=15811111111, Email="456456@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=31, UserName="同时", PassWord="test123", Mobile=15811111111, Email="789789789@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=32, UserName="了事", PassWord="test123", Mobile=15811111111, Email="4564565@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=33, UserName="发展", PassWord="test123", Mobile=15811111111, Email="213312312@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=34, UserName="以及", PassWord="test123", Mobile=15811111111, Email="5456456@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=35, UserName="经济", PassWord="test123", Mobile=15811111111, Email="87877878@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=36, UserName="我们", PassWord="test123", Mobile=15811111111, Email="878787@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=37, UserName="人家", PassWord="test123", Mobile=15811111111, Email="65656565@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=38, UserName="有关", PassWord="test123", Mobile=15811111111, Email="45454545@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=39, UserName="的话", PassWord="test123", Mobile=15811111111, Email="56565656@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=40, UserName="和他", PassWord="test123", Mobile=15811111111, Email="87878787@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=41, UserName="主要", PassWord="test123", Mobile=15811111111, Email="454566565@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=42, UserName="产品", PassWord="test123", Mobile=15811111111, Email="12121212@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
                new UserModel() { Id=43, UserName="为了", PassWord="test123", Mobile=15811111111, Email="5465654@qq.com", CreateTime=DateTime.Now, RegClientIp="158.56.55.236",  CurrentClientIp="127.0.0.1"},
            };
            #endregion



            return Json(new
            {
                //pages = Math.Ceiling((Decimal)list.Count / (Decimal)rows),//页数
                current = page,//当前页
                rowCount = rows,//每页条数
                rows = list,//列表
                total = list.Count,//总条数

            }, JsonRequestBehavior.AllowGet);
        }






    }
}