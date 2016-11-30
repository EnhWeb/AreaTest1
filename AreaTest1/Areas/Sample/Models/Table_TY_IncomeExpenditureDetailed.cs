using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 收入支出明细表（收支明细表）
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
        /// 会员ID
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
        /// 收入支出类型（1收入，2支出）
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
        /// 交易类型（1管理员充值，2用户转账充值，3用户在线充值，4提现，5提成，6结算，7日分红，等等等 有需要再添加）
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
        /// 当前状态（-1：进行中，1：成功，2：关闭）
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
        /// 交易金额
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
        /// 明细说明
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
        /// 创建时间（开始时间）
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
        /// 完成时间（结束时间）
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
        /// 操作位置（格式：项目名.控制器名.方法名  或者  项目名.命名空间名.类名.方法名）用后者更好（通用性更强）
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
        /// 币种（具体方法还没有想好）
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
        /// 交易前金额
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
        /// 交易后金额
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
