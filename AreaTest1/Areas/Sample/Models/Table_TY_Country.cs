using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ����
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
        /// ���ƣ��������ƣ�
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
        /// ���루���Ҵ��룩
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
