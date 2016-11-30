using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 会员表
    /// </summary>
    public class Table_TY_MemberBean 
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
        private string _UserName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        private string _UserPassWord;
        /// <summary>
        /// 用户密码（MD5值或SHA1或SHA256等等加密方式的密文）
        /// </summary>
        public string UserPassWord
        {
            get
            {
                return _UserPassWord;
            }
            set
            {
                _UserPassWord = value;
            }
        }
        private string _UserPassWordSalt;
        /// <summary>
        /// 用户密码佐料
        /// </summary>
        public string UserPassWordSalt
        {
            get
            {
                return _UserPassWordSalt;
            }
            set
            {
                _UserPassWordSalt = value;
            }
        }
        private string _UserPassWordExpress;
        /// <summary>
        /// 用户密码明文
        /// </summary>
        public string UserPassWordExpress
        {
            get
            {
                return _UserPassWordExpress;
            }
            set
            {
                _UserPassWordExpress = value;
            }
        }
        private string _TradePassword;
        /// <summary>
        /// 交易密码（MD5值或SHA1或SHA256等等加密方式的密文）
        /// </summary>
        public string TradePassword
        {
            get
            {
                return _TradePassword;
            }
            set
            {
                _TradePassword = value;
            }
        }
        private string _TradePasswordSalt;
        /// <summary>
        /// 交易密码佐料
        /// </summary>
        public string TradePasswordSalt
        {
            get
            {
                return _TradePasswordSalt;
            }
            set
            {
                _TradePasswordSalt = value;
            }
        }
        private string _TradePassWordExpress;
        /// <summary>
        /// 交易密码明文
        /// </summary>
        public string TradePassWordExpress
        {
            get
            {
                return _TradePassWordExpress;
            }
            set
            {
                _TradePassWordExpress = value;
            }
        }
        private string _QQ;
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get
            {
                return _QQ;
            }
            set
            {
                _QQ = value;
            }
        }
        private string _MobileNo;
        /// <summary>
        /// 手机号码
        /// </summary>
        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }
            set
            {
                _MobileNo = value;
            }
        }
        private int? _MobileVerificationStatus;
        /// <summary>
        /// 手机验证状态（邦定状态）（0未验证，1已验证）
        /// </summary>
        public int? MobileVerificationStatus
        {
            get
            {
                return _MobileVerificationStatus;
            }
            set
            {
                _MobileVerificationStatus = value;
            }
        }
        private string _EmailAddress;
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                _EmailAddress = value;
            }
        }
        private int? _EmailAddressVerificationStatus;
        /// <summary>
        /// 邮箱地址验证状态（邦定状态）（0未验证，1已验证）
        /// </summary>
        public int? EmailAddressVerificationStatus
        {
            get
            {
                return _EmailAddressVerificationStatus;
            }
            set
            {
                _EmailAddressVerificationStatus = value;
            }
        }
        private string _RealName;
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName
        {
            get
            {
                return _RealName;
            }
            set
            {
                _RealName = value;
            }
        }
        private int? _CountryId;
        /// <summary>
        /// 国籍ID（1中国）其它ID请查看（Table_TY_Country）
        /// </summary>
        public int? CountryId
        {
            get
            {
                return _CountryId;
            }
            set
            {
                _CountryId = value;
            }
        }
        private string _RegisterIpArea;
        /// <summary>
        /// 注册IP所在区域
        /// </summary>
        public string RegisterIpArea
        {
            get
            {
                return _RegisterIpArea;
            }
            set
            {
                _RegisterIpArea = value;
            }
        }
        private string _PopularizeCode;
        /// <summary>
        /// 推广码
        /// </summary>
        public string PopularizeCode
        {
            get
            {
                return _PopularizeCode;
            }
            set
            {
                _PopularizeCode = value;
            }
        }
        private string _AlipayAccount;
        /// <summary>
        /// 支付宝账号
        /// </summary>
        public string AlipayAccount
        {
            get
            {
                return _AlipayAccount;
            }
            set
            {
                _AlipayAccount = value;
            }
        }
        private string _TenpayAccount;
        /// <summary>
        /// 财付通账号
        /// </summary>
        public string TenpayAccount
        {
            get
            {
                return _TenpayAccount;
            }
            set
            {
                _TenpayAccount = value;
            }
        }
        private string _WeChatAccount;
        /// <summary>
        /// 微信账号
        /// </summary>
        public string WeChatAccount
        {
            get
            {
                return _WeChatAccount;
            }
            set
            {
                _WeChatAccount = value;
            }
        }
        private Decimal? _AccountBalance;
        /// <summary>
        /// 账户余额
        /// </summary>
        public Decimal? AccountBalance
        {
            get
            {
                return _AccountBalance;
            }
            set
            {
                _AccountBalance = value;
            }
        }
        private int? _AccountGoldCoin;
        /// <summary>
        /// 账户金币
        /// </summary>
        public int? AccountGoldCoin
        {
            get
            {
                return _AccountGoldCoin;
            }
            set
            {
                _AccountGoldCoin = value;
            }
        }
        private string _RelevancyGameUserName;
        /// <summary>
        /// 关联游戏用户名（邦定游戏用户名）
        /// </summary>
        public string RelevancyGameUserName
        {
            get
            {
                return _RelevancyGameUserName;
            }
            set
            {
                _RelevancyGameUserName = value;
            }
        }
        private string _RegisterIp;
        /// <summary>
        /// 注册IP地址
        /// </summary>
        public string RegisterIp
        {
            get
            {
                return _RegisterIp;
            }
            set
            {
                _RegisterIp = value;
            }
        }
        private DateTime? _RegisterTime;
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? RegisterTime
        {
            get
            {
                return _RegisterTime;
            }
            set
            {
                _RegisterTime = value;
            }
        }
        private DateTime? _ModifyTime;
        /// <summary>
        /// 修改用户资料时间（用户通过前台修改资料或管理员通过后台修改资料）账户余额变动不作更新
        /// </summary>
        public DateTime? ModifyTime
        {
            get
            {
                return _ModifyTime;
            }
            set
            {
                _ModifyTime = value;
            }
        }
        private DateTime? _LastLoginTime;
        /// <summary>
        /// 最后一次登录时间
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
        private string _LastLoginIp;
        /// <summary>
        /// 最后一次登录IP地址
        /// </summary>
        public string LastLoginIp
        {
            get
            {
                return _LastLoginIp;
            }
            set
            {
                _LastLoginIp = value;
            }
        }
        private int? _OnlineFlag;
        /// <summary>
        /// 在线状态（1在线，2离线，3手动退出）
        /// </summary>
        public int? OnlineFlag
        {
            get
            {
                return _OnlineFlag;
            }
            set
            {
                _OnlineFlag = value;
            }
        }
        private int? _UserType;
        /// <summary>
        /// 用户类型（类型：1普通用户，2代理用户，3其它用户）（其它类型请在这里自定义标名）
        /// </summary>
        public int? UserType
        {
            get
            {
                return _UserType;
            }
            set
            {
                _UserType = value;
            }
        }
        private int? _UserStatus;
        /// <summary>
        /// 用户状态（0：未激活，1：正常，2：锁定，3：封号，4：已删除，5：限制）（其它状态请在这里自定义标名）
        /// </summary>
        public int? UserStatus
        {
            get
            {
                return _UserStatus;
            }
            set
            {
                _UserStatus = value;
            }
        }
        private string _RootUserId;
        /// <summary>
        /// 目录层级用户ID树（格式：/1/33/45/128/）
        /// </summary>
        public string RootUserId
        {
            get
            {
                return _RootUserId;
            }
            set
            {
                _RootUserId = value;
            }
        }
        private string _RootUserName;
        /// <summary>
        /// 目录层级UserName树（格式：/!!BetSun@01/gx9999/ab999/ab1768/）
        /// </summary>
        public string RootUserName
        {
            get
            {
                return _RootUserName;
            }
            set
            {
                _RootUserName = value;
            }
        }
        private int? _ParentUserId;
        /// <summary>
        /// 上级用户ID
        /// </summary>
        public int? ParentUserId
        {
            get
            {
                return _ParentUserId;
            }
            set
            {
                _ParentUserId = value;
            }
        }
        private string _ParentUserName;
        /// <summary>
        /// 上级UserName
        /// </summary>
        public string ParentUserName
        {
            get
            {
                return _ParentUserName;
            }
            set
            {
                _ParentUserName = value;
            }
        }
        private int? _AgentUserId;
        /// <summary>
        /// 代理用户ID
        /// </summary>
        public int? AgentUserId
        {
            get
            {
                return _AgentUserId;
            }
            set
            {
                _AgentUserId = value;
            }
        }
        private string _AgentUserName;
        /// <summary>
        /// 代理用户名
        /// </summary>
        public string AgentUserName
        {
            get
            {
                return _AgentUserName;
            }
            set
            {
                _AgentUserName = value;
            }
        }
        private Decimal? _TotalDynamicBonus;
        /// <summary>
        /// 累计动态奖金
        /// </summary>
        public Decimal? TotalDynamicBonus
        {
            get
            {
                return _TotalDynamicBonus;
            }
            set
            {
                _TotalDynamicBonus = value;
            }
        }
        private Decimal? _TotalBonus;
        /// <summary>
        /// 累计已分红
        /// </summary>
        public Decimal? TotalBonus
        {
            get
            {
                return _TotalBonus;
            }
            set
            {
                _TotalBonus = value;
            }
        }
        private Decimal? _TotalInvestmentAmount;
        /// <summary>
        /// 累计投资额度
        /// </summary>
        public Decimal? TotalInvestmentAmount
        {
            get
            {
                return _TotalInvestmentAmount;
            }
            set
            {
                _TotalInvestmentAmount = value;
            }
        }
        private int? _InvestmentStatus;
        /// <summary>
        /// 投资状态 10：正常 20：出局 30：退本 
        /// </summary>
        public int? InvestmentStatus
        {
            get
            {
                return _InvestmentStatus;
            }
            set
            {
                _InvestmentStatus = value;
            }
        }
        private Decimal? _InvestmentAmount;
        /// <summary>
        /// 投资额度
        /// </summary>
        public Decimal? InvestmentAmount
        {
            get
            {
                return _InvestmentAmount;
            }
            set
            {
                _InvestmentAmount = value;
            }
        }
        private int? _InvestmentLevelId;
        /// <summary>
        /// 投资级别Id
        /// </summary>
        public int? InvestmentLevelId
        {
            get
            {
                return _InvestmentLevelId;
            }
            set
            {
                _InvestmentLevelId = value;
            }
        }
        private string _Remark;
        /// <summary>
        /// 备注
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
