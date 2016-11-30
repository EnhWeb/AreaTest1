using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 消息表（公告信息也在这个表）
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
        /// 用户ID（如果用户ID为空，则为公告，所有用户可见，在后台管理时可以查出为空的用户ID的消息作为公告使用）
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
        /// 消息状态（1：未读，2：已读，3：已删除）
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
        /// 消息标题
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
        /// 消息内容
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
        /// 消息发布时间
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
        /// 备注
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
