using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 国籍
    /// </summary>
    public class Table_TY_CountryBean 
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
        private string _Name;
        /// <summary>
        /// 名称（国家名称）
        /// </summary>
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private string _Code;
        /// <summary>
        /// 编码（国家代码）
        /// </summary>
        public string Code
        {
            get
            {
                return _Code;
            }
            set
            {
                _Code = value;
            }
        }
    }
}
