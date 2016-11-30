using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 系统配置信息表
    /// </summary>
    public class Table_TY_SysConfigInfoBean 
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
        private string _ConfigType;
        /// <summary>
        /// 配置类型（用来分组配置）
        /// </summary>
        public string ConfigType
        {
            get
            {
                return _ConfigType;
            }
            set
            {
                _ConfigType = value;
            }
        }
        private string _ConfigChineseName;
        /// <summary>
        /// 配置中文名称
        /// </summary>
        public string ConfigChineseName
        {
            get
            {
                return _ConfigChineseName;
            }
            set
            {
                _ConfigChineseName = value;
            }
        }
        private string _ConfigName;
        /// <summary>
        /// 配置名称（调用时使用的名称）
        /// </summary>
        public string ConfigName
        {
            get
            {
                return _ConfigName;
            }
            set
            {
                _ConfigName = value;
            }
        }
        private string _ConfigValue;
        /// <summary>
        /// 配置值
        /// </summary>
        public string ConfigValue
        {
            get
            {
                return _ConfigValue;
            }
            set
            {
                _ConfigValue = value;
            }
        }
        private string _ConfigCaption;
        /// <summary>
        /// 配置说明
        /// </summary>
        public string ConfigCaption
        {
            get
            {
                return _ConfigCaption;
            }
            set
            {
                _ConfigCaption = value;
            }
        }
        private int? _Sort;
        /// <summary>
        /// 排序（数小的靠前面排）
        /// </summary>
        public int? Sort
        {
            get
            {
                return _Sort;
            }
            set
            {
                _Sort = value;
            }
        }
    }
}
