using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 多语言资源表
    /// </summary>
    public class Table_TY_MultiLanguageResourceBean 
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
        private string _ProjectName;
        /// <summary>
        /// 项目名（Shared为共享）
        /// </summary>
        public string ProjectName
        {
            get
            {
                return _ProjectName;
            }
            set
            {
                _ProjectName = value;
            }
        }
        private string _ControllersName;
        /// <summary>
        /// 控制器名称（Shared为共享）
        /// </summary>
        public string ControllersName
        {
            get
            {
                return _ControllersName;
            }
            set
            {
                _ControllersName = value;
            }
        }
        private string _ActionName;
        /// <summary>
        /// Action方法名称（Shared为共享）
        /// </summary>
        public string ActionName
        {
            get
            {
                return _ActionName;
            }
            set
            {
                _ActionName = value;
            }
        }
        private string _CultureInfo;
        /// <summary>
        /// 语言区域（如：zh-CN zh-CHS zh-TW en-US en 等等）
        /// </summary>
        public string CultureInfo
        {
            get
            {
                return _CultureInfo;
            }
            set
            {
                _CultureInfo = value;
            }
        }
        private string _ResourceName;
        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResourceName
        {
            get
            {
                return _ResourceName;
            }
            set
            {
                _ResourceName = value;
            }
        }
        private string _ResourceKeyName;
        /// <summary>
        /// 资源键名称
        /// </summary>
        public string ResourceKeyName
        {
            get
            {
                return _ResourceKeyName;
            }
            set
            {
                _ResourceKeyName = value;
            }
        }
        private string _ResourceValue;
        /// <summary>
        /// 资源值（所在区域的语言对应值）（可以保存如用户名：{0}您好！您是第{1}次登录本系统！）
        /// </summary>
        public string ResourceValue
        {
            get
            {
                return _ResourceValue;
            }
            set
            {
                _ResourceValue = value;
            }
        }
        private string _ResourceCaption;
        /// <summary>
        /// 资源说明（中文说明）
        /// </summary>
        public string ResourceCaption
        {
            get
            {
                return _ResourceCaption;
            }
            set
            {
                _ResourceCaption = value;
            }
        }
    }
}
