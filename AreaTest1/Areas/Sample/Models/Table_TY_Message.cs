using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ��Ϣ��������ϢҲ�������
    /// </summary>
    public class Table_TY_MessageBean 
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
        private int? _MemberId;
        /// <summary>
        /// �û�ID������û�IDΪ�գ���Ϊ���棬�����û��ɼ����ں�̨����ʱ���Բ��Ϊ�յ��û�ID����Ϣ��Ϊ����ʹ�ã�
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
        private int? _MessageStatus;
        /// <summary>
        /// ��Ϣ״̬��1��δ����2���Ѷ���3����ɾ����
        /// </summary>
        public int? MessageStatus
        {
            get
            {
                return _MessageStatus;
            }
            set
            {
                _MessageStatus = value;
            }
        }
        private string _MessageTitle;
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public string MessageTitle
        {
            get
            {
                return _MessageTitle;
            }
            set
            {
                _MessageTitle = value;
            }
        }
        private string _MessageContent;
        /// <summary>
        /// ��Ϣ����
        /// </summary>
        public string MessageContent
        {
            get
            {
                return _MessageContent;
            }
            set
            {
                _MessageContent = value;
            }
        }
        private DateTime? _MessagePublishTime;
        /// <summary>
        /// ��Ϣ����ʱ��
        /// </summary>
        public DateTime? MessagePublishTime
        {
            get
            {
                return _MessagePublishTime;
            }
            set
            {
                _MessagePublishTime = value;
            }
        }
        private string _Remark;
        /// <summary>
        /// ��ע
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
