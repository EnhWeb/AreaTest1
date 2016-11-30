using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// �û���¼��־������Ա�ͻ�Ա��¼��־����¼�������
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
        /// ����ԱID
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
        /// ��ԱID
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
        /// �û��ỰID
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
        /// ���ε�¼ʱ��
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
        /// �ϴε�¼ʱ��
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
        /// ���ε�¼���ʱ�䣨LoginTime-LastLoginTime=�����
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
        /// ��ǰ���ԣ���cookie�еõ���ǰ�û�ѡ������ԣ�
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
        /// �ͻ���IP��ַ
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
        /// �ͻ��˵�¼��վ��ַ
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
        /// �ͻ�������MAC��ַ
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
        /// �ͻ������������
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
        /// �ͻ���������汾
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
        /// �ͻ������������
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
        /// �ͻ��˲���ϵͳ����
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
        /// �ͻ��˲���ϵͳ�汾
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
        /// �ͻ�����Ļ�ֱ���
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
        /// ��ע��Ϣ
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
