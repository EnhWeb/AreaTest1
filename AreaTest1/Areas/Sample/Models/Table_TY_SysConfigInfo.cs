using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ϵͳ������Ϣ��
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
        /// �������ͣ������������ã�
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
        /// ������������
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
        /// �������ƣ�����ʱʹ�õ����ƣ�
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
        /// ����ֵ
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
        /// ����˵��
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
        /// ������С�Ŀ�ǰ���ţ�
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
