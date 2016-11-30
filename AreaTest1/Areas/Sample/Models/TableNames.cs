using System;

namespace Web.Enum.Db
{
    public enum TableNames { Table_TY_Role , Table_TY_SysConfigInfo , Table_TY_UserLoginLog , Table_TY_OperationLog , Table_TY_Message , Table_TY_Member , Table_TY_IncomeExpenditureDetailed , Table_TY_Country , Table_TY_MultiLanguageResource , Table_TY_Admin }

    #region Ã¶¾Ù 
    public enum Table_TY_Role { Id, RoleName, AdministrativePermissionsIdListJson, AdministrativePermissionsChinaNameListJson }
    public enum Table_TY_SysConfigInfo { Id, ConfigType, ConfigChineseName, ConfigName, ConfigValue, ConfigCaption, Sort }
    public enum Table_TY_UserLoginLog { Id, AdminId, MemberId, UserSessiionId, LoginTime, LastLoginTime, TwiceLoginSpacingTime, CurrentLanguage, ClientIp, ClientLoginSiteUrl, ClientMacAddress, ClientBrowserType, ClientBrowserVersion, ClientBrowserLanguage, ClientOperatingSystemType, ClientOperatingSystemVersion, ClientScreanResolution, Remark }
    public enum Table_TY_OperationLog { Id, UserType, MemberId, UserName, Title, Content, ClientIp, CreateTime, Remark }
    public enum Table_TY_Message { Id, MemberId, MessageStatus, MessageTitle, MessageContent, MessagePublishTime, Remark }
    public enum Table_TY_Member { Id, UserName, UserPassWord, UserPassWordSalt, UserPassWordExpress, TradePassword, TradePasswordSalt, TradePassWordExpress, QQ, MobileNo, MobileVerificationStatus, EmailAddress, EmailAddressVerificationStatus, RealName, CountryId, RegisterIpArea, PopularizeCode, AlipayAccount, TenpayAccount, WeChatAccount, AccountBalance, AccountGoldCoin, RelevancyGameUserName, RegisterIp, RegisterTime, ModifyTime, LastLoginTime, LastLoginIp, OnlineFlag, UserType, UserStatus, RootUserId, RootUserName, ParentUserId, ParentUserName, AgentUserId, AgentUserName, TotalDynamicBonus, TotalBonus, TotalInvestmentAmount, InvestmentStatus, InvestmentAmount, InvestmentLevelId, Remark }
    public enum Table_TY_IncomeExpenditureDetailed { Id, MemberId, IncomeExpenditureType, TradeType, Status, TradeAmount, DetailedCaption, CreateTime, CompleteTime, OperatePosition, GoldType, AmountBefore, AmountAfter, Remark }
    public enum Table_TY_Country { Id, Name, Code }
    public enum Table_TY_MultiLanguageResource { Id, ProjectName, ControllersName, ActionName, CultureInfo, ResourceName, ResourceKeyName, ResourceValue, ResourceCaption }
    public enum Table_TY_Admin { Id, RoleId, UserName, PassWord, PassWordSalt, CreateTime, LastLoginTime, Remark }
    #endregion
}