using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ������־
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
        /// �û����ͣ�1Ϊ����Ա��2Ϊ�û���3Ϊϵͳ��4ΪWindows����
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
        /// ��ԱId
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
        /// �û���
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
        /// ������־����
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
        /// ������־����
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
        private DateTime? _CreateTime;
        /// <summary>
        ///  ����ʱ��
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
        ///  ��ע
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
