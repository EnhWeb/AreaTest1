using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 管理员表
    /// </summary>
    public class Table_TY_AdminBean 
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
        private int? _RoleId;
        /// <summary>
        /// 角色（1：管理员，查看员，等等，具体以 Table_TY_Role 表为标准 ）
        /// </summary>
        public int? RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                _RoleId = value;
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
        private string _PassWord;
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                _PassWord = value;
            }
        }
        private string _PassWordSalt;
        /// <summary>
        /// 密码佐料
        /// </summary>
        public string PassWordSalt
        {
            get
            {
                return _PassWordSalt;
            }
            set
            {
                _PassWordSalt = value;
            }
        }
        private DateTime? _CreateTime;
        /// <summary>
        /// 创建时间
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
        private DateTime? _LastLoginTime;
        /// <summary>
        /// 最后登录时间
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
