using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 用户登录日志（管理员和会员登录日志都记录在这个表）
    /// </summary>
    public class Table_TY_UserLoginLogBean 
    {
        private int? _Id;
        public int? Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        private int? _AdminId;
        /// <summary>
        /// 管理员ID
        /// </summary>
        public int? AdminId
        {
            get
            {
                return _AdminId;
            }
            set
            {
                _AdminId = value;
            }
        }
        private int? _MemberId;
        /// <summary>
        /// 会员ID
        /// </summary>
        public int? MemberId
        {
            get
            {
                return _MemberId;
            }
            set
            {
                _MemberId = value;
            }
        }
        private string _UserSessiionId;
        /// <summary>
        /// 用户会话ID
        /// </summary>
        public string UserSessiionId
        {
            get
            {
                return _UserSessiionId;
            }
            set
            {
                _UserSessiionId = value;
            }
        }
        private DateTime? _LoginTime;
        /// <summary>
        /// 本次登录时间
        /// </summary>
        public DateTime? LoginTime
        {
            get
            {
                return _LoginTime;
            }
            set
            {
                _LoginTime = value;
            }
        }
        private DateTime? _LastLoginTime;
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime? LastLoginTime
        {
            get
            {
                return _LastLoginTime;
            }
            set
            {
                _LastLoginTime = value;
            }
        }
        private string _TwiceLoginSpacingTime;
        /// <summary>
        /// 两次登录间隔时间（LoginTime-LastLoginTime=间隔）
        /// </summary>
        public string TwiceLoginSpacingTime
        {
            get
            {
                return _TwiceLoginSpacingTime;
            }
            set
            {
                _TwiceLoginSpacingTime = value;
            }
        }
        private string _CurrentLanguage;
        /// <summary>
        /// 当前语言（从cookie中得到当前用户选择的语言）
        /// </summary>
        public string CurrentLanguage
        {
            get
            {
                return _CurrentLanguage;
            }
            set
            {
                _CurrentLanguage = value;
            }
        }
        private string _ClientIp;
        /// <summary>
        /// 客户端IP地址
        /// </summary>
        public string ClientIp
        {
            get
            {
                return _ClientIp;
            }
            set
            {
                _ClientIp = value;
            }
        }
        private string _ClientLoginSiteUrl;
        /// <summary>
        /// 客户端登录网站地址
        /// </summary>
        public string ClientLoginSiteUrl
        {
            get
            {
                return _ClientLoginSiteUrl;
            }
            set
            {
                _ClientLoginSiteUrl = value;
            }
        }
        private string _ClientMacAddress;
        /// <summary>
        /// 客户端网卡MAC地址
        /// </summary>
        public string ClientMacAddress
        {
            get
            {
                return _ClientMacAddress;
            }
            set
            {
                _ClientMacAddress = value;
            }
        }
        private string _ClientBrowserType;
        /// <summary>
        /// 客户端浏览器类型
        /// </summary>
        public string ClientBrowserType
        {
            get
            {
                return _ClientBrowserType;
            }
            set
            {
                _ClientBrowserType = value;
            }
        }
        private string _ClientBrowserVersion;
        /// <summary>
        /// 客户端浏览器版本
        /// </summary>
        public string ClientBrowserVersion
        {
            get
            {
                return _ClientBrowserVersion;
            }
            set
            {
                _ClientBrowserVersion = value;
            }
        }
        private string _ClientBrowserLanguage;
        /// <summary>
        /// 客户端浏览器语言
        /// </summary>
        public string ClientBrowserLanguage
        {
            get
            {
                return _ClientBrowserLanguage;
            }
            set
            {
                _ClientBrowserLanguage = value;
            }
        }
        private string _ClientOperatingSystemType;
        /// <summary>
        /// 客户端操作系统类型
        /// </summary>
        public string ClientOperatingSystemType
        {
            get
            {
                return _ClientOperatingSystemType;
            }
            set
            {
                _ClientOperatingSystemType = value;
            }
        }
        private string _ClientOperatingSystemVersion;
        /// <summary>
        /// 客户端操作系统版本
        /// </summary>
        public string ClientOperatingSystemVersion
        {
            get
            {
                return _ClientOperatingSystemVersion;
            }
            set
            {
                _ClientOperatingSystemVersion = value;
            }
        }
        private string _ClientScreanResolution;
        /// <summary>
        /// 客户端屏幕分辨率
        /// </summary>
        public string ClientScreanResolution
        {
            get
            {
                return _ClientScreanResolution;
            }
            set
            {
                _ClientScreanResolution = value;
            }
        }
        private string _Remark;
        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark
        {
            get
            {
                return _Remark;
            }
            set
            {
                _Remark = value;
            }
        }
    }
}
