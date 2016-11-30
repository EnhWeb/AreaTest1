using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ����Ա��
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
        /// ��ɫ��1������Ա���鿴Ա���ȵȣ������� Table_TY_Role ��Ϊ��׼ ��
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
        private string _PassWord;
        /// <summary>
        /// ����
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
        /// ��������
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
        /// ����ʱ��
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
        /// ����¼ʱ��
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
