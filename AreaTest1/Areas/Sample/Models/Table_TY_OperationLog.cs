using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class Table_TY_OperationLogBean 
    {
        private Int64? _Id;
        public Int64? Id
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
        private int? _UserType;
        /// <summary>
        /// 用户类型（1为管理员，2为用户，3为系统，4为Windows服务）
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
        private int? _MemberId;
        /// <summary>
        /// 会员Id
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
        private string _Title;
        /// <summary>
        /// 操作日志标题
        /// </summary>
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        private string _Content;
        /// <summary>
        /// 操作日志内容
        /// </summary>
        public string Content
        {
            get
            {
                return _Content;
            }
            set
            {
                _Content = value;
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
        private DateTime? _CreateTime;
        /// <summary>
        ///  创建时间
        /// </summary>
        public DateTime? CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                _CreateTime = value;
            }
        }
        private string _Remark;
        /// <summary>
        ///  备注
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
