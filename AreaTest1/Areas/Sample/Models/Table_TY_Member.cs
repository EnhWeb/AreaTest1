using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ��Ա��
    /// </summary>
    public class Table_TY_MemberBean 
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
        private string _UserPassWord;
        /// <summary>
        /// �û����루MD5ֵ��SHA1��SHA256�ȵȼ��ܷ�ʽ�����ģ�
        /// </summary>
        public string UserPassWord
        {
            get
            {
                return _UserPassWord;
            }
            set
            {
                _UserPassWord = value;
            }
        }
        private string _UserPassWordSalt;
        /// <summary>
        /// �û���������
        /// </summary>
        public string UserPassWordSalt
        {
            get
            {
                return _UserPassWordSalt;
            }
            set
            {
                _UserPassWordSalt = value;
            }
        }
        private string _UserPassWordExpress;
        /// <summary>
        /// �û���������
        /// </summary>
        public string UserPassWordExpress
        {
            get
            {
                return _UserPassWordExpress;
            }
            set
            {
                _UserPassWordExpress = value;
            }
        }
        private string _TradePassword;
        /// <summary>
        /// �������루MD5ֵ��SHA1��SHA256�ȵȼ��ܷ�ʽ�����ģ�
        /// </summary>
        public string TradePassword
        {
            get
            {
                return _TradePassword;
            }
            set
            {
                _TradePassword = value;
            }
        }
        private string _TradePasswordSalt;
        /// <summary>
        /// ������������
        /// </summary>
        public string TradePasswordSalt
        {
            get
            {
                return _TradePasswordSalt;
            }
            set
            {
                _TradePasswordSalt = value;
            }
        }
        private string _TradePassWordExpress;
        /// <summary>
        /// ������������
        /// </summary>
        public string TradePassWordExpress
        {
            get
            {
                return _TradePassWordExpress;
            }
            set
            {
                _TradePassWordExpress = value;
            }
        }
        private string _QQ;
        /// <summary>
        /// QQ
        /// </summary>
        public string QQ
        {
            get
            {
                return _QQ;
            }
            set
            {
                _QQ = value;
            }
        }
        private string _MobileNo;
        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }
            set
            {
                _MobileNo = value;
            }
        }
        private int? _MobileVerificationStatus;
        /// <summary>
        /// �ֻ���֤״̬���״̬����0δ��֤��1����֤��
        /// </summary>
        public int? MobileVerificationStatus
        {
            get
            {
                return _MobileVerificationStatus;
            }
            set
            {
                _MobileVerificationStatus = value;
            }
        }
        private string _EmailAddress;
        /// <summary>
        /// �����ַ
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                _EmailAddress = value;
            }
        }
        private int? _EmailAddressVerificationStatus;
        /// <summary>
        /// �����ַ��֤״̬���״̬����0δ��֤��1����֤��
        /// </summary>
        public int? EmailAddressVerificationStatus
        {
            get
            {
                return _EmailAddressVerificationStatus;
            }
            set
            {
                _EmailAddressVerificationStatus = value;
            }
        }
        private string _RealName;
        /// <summary>
        /// ��ʵ����
        /// </summary>
        public string RealName
        {
            get
            {
                return _RealName;
            }
            set
            {
                _RealName = value;
            }
        }
        private int? _CountryId;
        /// <summary>
        /// ����ID��1�й�������ID��鿴��Table_TY_Country��
        /// </summary>
        public int? CountryId
        {
            get
            {
                return _CountryId;
            }
            set
            {
                _CountryId = value;
            }
        }
        private string _RegisterIpArea;
        /// <summary>
        /// ע��IP��������
        /// </summary>
        public string RegisterIpArea
        {
            get
            {
                return _RegisterIpArea;
            }
            set
            {
                _RegisterIpArea = value;
            }
        }
        private string _PopularizeCode;
        /// <summary>
        /// �ƹ���
        /// </summary>
        public string PopularizeCode
        {
            get
            {
                return _PopularizeCode;
            }
            set
            {
                _PopularizeCode = value;
            }
        }
        private string _AlipayAccount;
        /// <summary>
        /// ֧�����˺�
        /// </summary>
        public string AlipayAccount
        {
            get
            {
                return _AlipayAccount;
            }
            set
            {
                _AlipayAccount = value;
            }
        }
        private string _TenpayAccount;
        /// <summary>
        /// �Ƹ�ͨ�˺�
        /// </summary>
        public string TenpayAccount
        {
            get
            {
                return _TenpayAccount;
            }
            set
            {
                _TenpayAccount = value;
            }
        }
        private string _WeChatAccount;
        /// <summary>
        /// ΢���˺�
        /// </summary>
        public string WeChatAccount
        {
            get
            {
                return _WeChatAccount;
            }
            set
            {
                _WeChatAccount = value;
            }
        }
        private Decimal? _AccountBalance;
        /// <summary>
        /// �˻����
        /// </summary>
        public Decimal? AccountBalance
        {
            get
            {
                return _AccountBalance;
            }
            set
            {
                _AccountBalance = value;
            }
        }
        private int? _AccountGoldCoin;
        /// <summary>
        /// �˻����
        /// </summary>
        public int? AccountGoldCoin
        {
            get
            {
                return _AccountGoldCoin;
            }
            set
            {
                _AccountGoldCoin = value;
            }
        }
        private string _RelevancyGameUserName;
        /// <summary>
        /// ������Ϸ�û��������Ϸ�û�����
        /// </summary>
        public string RelevancyGameUserName
        {
            get
            {
                return _RelevancyGameUserName;
            }
            set
            {
                _RelevancyGameUserName = value;
            }
        }
        private string _RegisterIp;
        /// <summary>
        /// ע��IP��ַ
        /// </summary>
        public string RegisterIp
        {
            get
            {
                return _RegisterIp;
            }
            set
            {
                _RegisterIp = value;
            }
        }
        private DateTime? _RegisterTime;
        /// <summary>
        /// ע��ʱ��
        /// </summary>
        public DateTime? RegisterTime
        {
            get
            {
                return _RegisterTime;
            }
            set
            {
                _RegisterTime = value;
            }
        }
        private DateTime? _ModifyTime;
        /// <summary>
        /// �޸��û�����ʱ�䣨�û�ͨ��ǰ̨�޸����ϻ����Աͨ����̨�޸����ϣ��˻����䶯��������
        /// </summary>
        public DateTime? ModifyTime
        {
            get
            {
                return _ModifyTime;
            }
            set
            {
                _ModifyTime = value;
            }
        }
        private DateTime? _LastLoginTime;
        /// <summary>
        /// ���һ�ε�¼ʱ��
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
        private string _LastLoginIp;
        /// <summary>
        /// ���һ�ε�¼IP��ַ
        /// </summary>
        public string LastLoginIp
        {
            get
            {
                return _LastLoginIp;
            }
            set
            {
                _LastLoginIp = value;
            }
        }
        private int? _OnlineFlag;
        /// <summary>
        /// ����״̬��1���ߣ�2���ߣ�3�ֶ��˳���
        /// </summary>
        public int? OnlineFlag
        {
            get
            {
                return _OnlineFlag;
            }
            set
            {
                _OnlineFlag = value;
            }
        }
        private int? _UserType;
        /// <summary>
        /// �û����ͣ����ͣ�1��ͨ�û���2�����û���3�����û����������������������Զ��������
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
        private int? _UserStatus;
        /// <summary>
        /// �û�״̬��0��δ���1��������2��������3����ţ�4����ɾ����5�����ƣ�������״̬���������Զ��������
        /// </summary>
        public int? UserStatus
        {
            get
            {
                return _UserStatus;
            }
            set
            {
                _UserStatus = value;
            }
        }
        private string _RootUserId;
        /// <summary>
        /// Ŀ¼�㼶�û�ID������ʽ��/1/33/45/128/��
        /// </summary>
        public string RootUserId
        {
            get
            {
                return _RootUserId;
            }
            set
            {
                _RootUserId = value;
            }
        }
        private string _RootUserName;
        /// <summary>
        /// Ŀ¼�㼶UserName������ʽ��/!!BetSun@01/gx9999/ab999/ab1768/��
        /// </summary>
        public string RootUserName
        {
            get
            {
                return _RootUserName;
            }
            set
            {
                _RootUserName = value;
            }
        }
        private int? _ParentUserId;
        /// <summary>
        /// �ϼ��û�ID
        /// </summary>
        public int? ParentUserId
        {
            get
            {
                return _ParentUserId;
            }
            set
            {
                _ParentUserId = value;
            }
        }
        private string _ParentUserName;
        /// <summary>
        /// �ϼ�UserName
        /// </summary>
        public string ParentUserName
        {
            get
            {
                return _ParentUserName;
            }
            set
            {
                _ParentUserName = value;
            }
        }
        private int? _AgentUserId;
        /// <summary>
        /// �����û�ID
        /// </summary>
        public int? AgentUserId
        {
            get
            {
                return _AgentUserId;
            }
            set
            {
                _AgentUserId = value;
            }
        }
        private string _AgentUserName;
        /// <summary>
        /// �����û���
        /// </summary>
        public string AgentUserName
        {
            get
            {
                return _AgentUserName;
            }
            set
            {
                _AgentUserName = value;
            }
        }
        private Decimal? _TotalDynamicBonus;
        /// <summary>
        /// �ۼƶ�̬����
        /// </summary>
        public Decimal? TotalDynamicBonus
        {
            get
            {
                return _TotalDynamicBonus;
            }
            set
            {
                _TotalDynamicBonus = value;
            }
        }
        private Decimal? _TotalBonus;
        /// <summary>
        /// �ۼ��ѷֺ�
        /// </summary>
        public Decimal? TotalBonus
        {
            get
            {
                return _TotalBonus;
            }
            set
            {
                _TotalBonus = value;
            }
        }
        private Decimal? _TotalInvestmentAmount;
        /// <summary>
        /// �ۼ�Ͷ�ʶ��
        /// </summary>
        public Decimal? TotalInvestmentAmount
        {
            get
            {
                return _TotalInvestmentAmount;
            }
            set
            {
                _TotalInvestmentAmount = value;
            }
        }
        private int? _InvestmentStatus;
        /// <summary>
        /// Ͷ��״̬ 10������ 20������ 30���˱� 
        /// </summary>
        public int? InvestmentStatus
        {
            get
            {
                return _InvestmentStatus;
            }
            set
            {
                _InvestmentStatus = value;
            }
        }
        private Decimal? _InvestmentAmount;
        /// <summary>
        /// Ͷ�ʶ��
        /// </summary>
        public Decimal? InvestmentAmount
        {
            get
            {
                return _InvestmentAmount;
            }
            set
            {
                _InvestmentAmount = value;
            }
        }
        private int? _InvestmentLevelId;
        /// <summary>
        /// Ͷ�ʼ���Id
        /// </summary>
        public int? InvestmentLevelId
        {
            get
            {
                return _InvestmentLevelId;
            }
            set
            {
                _InvestmentLevelId = value;
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
