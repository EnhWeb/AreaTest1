using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ��������Դ��
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
        /// ��Ŀ����SharedΪ����
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
        /// ���������ƣ�SharedΪ����
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
        /// Action�������ƣ�SharedΪ����
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
        /// ���������磺zh-CN zh-CHS zh-TW en-US en �ȵȣ�
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
        /// ��Դ����
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
        /// ��Դ������
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
        /// ��Դֵ��������������Զ�Ӧֵ�������Ա������û�����{0}���ã����ǵ�{1}�ε�¼��ϵͳ����
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
        /// ��Դ˵��������˵����
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
