using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ����֧����ϸ����֧��ϸ��
    /// </summary>
    public class Table_TY_IncomeExpenditureDetailedBean 
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
        private int? _IncomeExpenditureType;
        /// <summary>
        /// ����֧�����ͣ�1���룬2֧����
        /// </summary>
        public int? IncomeExpenditureType
        {
            get
            {
                return _IncomeExpenditureType;
            }
            set
            {
                _IncomeExpenditureType = value;
            }
        }
        private int? _TradeType;
        /// <summary>
        /// �������ͣ�1����Ա��ֵ��2�û�ת�˳�ֵ��3�û����߳�ֵ��4���֣�5��ɣ�6���㣬7�շֺ죬�ȵȵ� ����Ҫ����ӣ�
        /// </summary>
        public int? TradeType
        {
            get
            {
                return _TradeType;
            }
            set
            {
                _TradeType = value;
            }
        }
        private int? _Status;
        /// <summary>
        /// ��ǰ״̬��-1�������У�1���ɹ���2���رգ�
        /// </summary>
        public int? Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;
            }
        }
        private Decimal? _TradeAmount;
        /// <summary>
        /// ���׽��
        /// </summary>
        public Decimal? TradeAmount
        {
            get
            {
                return _TradeAmount;
            }
            set
            {
                _TradeAmount = value;
            }
        }
        private string _DetailedCaption;
        /// <summary>
        /// ��ϸ˵��
        /// </summary>
        public string DetailedCaption
        {
            get
            {
                return _DetailedCaption;
            }
            set
            {
                _DetailedCaption = value;
            }
        }
        private DateTime? _CreateTime;
        /// <summary>
        /// ����ʱ�䣨��ʼʱ�䣩
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
        private DateTime? _CompleteTime;
        /// <summary>
        /// ���ʱ�䣨����ʱ�䣩
        /// </summary>
        public DateTime? CompleteTime
        {
            get
            {
                return _CompleteTime;
            }
            set
            {
                _CompleteTime = value;
            }
        }
        private string _OperatePosition;
        /// <summary>
        /// ����λ�ã���ʽ����Ŀ��.��������.������  ����  ��Ŀ��.�����ռ���.����.���������ú��߸��ã�ͨ���Ը�ǿ��
        /// </summary>
        public string OperatePosition
        {
            get
            {
                return _OperatePosition;
            }
            set
            {
                _OperatePosition = value;
            }
        }
        private int? _GoldType;
        /// <summary>
        /// ���֣����巽����û����ã�
        /// </summary>
        public int? GoldType
        {
            get
            {
                return _GoldType;
            }
            set
            {
                _GoldType = value;
            }
        }
        private Decimal? _AmountBefore;
        /// <summary>
        /// ����ǰ���
        /// </summary>
        public Decimal? AmountBefore
        {
            get
            {
                return _AmountBefore;
            }
            set
            {
                _AmountBefore = value;
            }
        }
        private Decimal? _AmountAfter;
        /// <summary>
        /// ���׺���
        /// </summary>
        public Decimal? AmountAfter
        {
            get
            {
                return _AmountAfter;
            }
            set
            {
                _AmountAfter = value;
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
