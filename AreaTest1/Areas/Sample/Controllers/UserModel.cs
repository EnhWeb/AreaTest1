using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaTest1.Areas.Sample.Controllers
{
    /// <summary>
    /// 用户实体 模型
    /// </summary>
    public class UserModel
    {

        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }


        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }


        /// <summary>
        /// 手机
        /// </summary>
        public long Mobile { get; set; }


        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }


        /// <summary>
        /// 注册客户端IP地址
        /// </summary>
        public string RegClientIp { get; set; }


        /// <summary>
        /// 当前IP地址
        /// </summary>
        public string CurrentClientIp { get; set; }

    }
}
