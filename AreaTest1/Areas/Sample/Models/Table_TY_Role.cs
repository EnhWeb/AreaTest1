using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// 角色表（用户角色权限表）
    /// </summary>
    public class Table_TY_RoleBean 
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
        private string _RoleName;
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName
        {
            get
            {
                return _RoleName;
            }
            set
            {
                _RoleName = value;
            }
        }
        private string _AdministrativePermissionsIdListJson;
        /// <summary>
        /// 管理权限ID数组Json字符串（如果值为：All 则权限为所有权限都有）
        /// </summary>
        public string AdministrativePermissionsIdListJson
        {
            get
            {
                return _AdministrativePermissionsIdListJson;
            }
            set
            {
                _AdministrativePermissionsIdListJson = value;
            }
        }
        private string _AdministrativePermissionsChinaNameListJson;
        /// <summary>
        /// 管理权限中文名数组Json字符串（如果值为：全部 则权限为所有权限都有）
        /// </summary>
        public string AdministrativePermissionsChinaNameListJson
        {
            get
            {
                return _AdministrativePermissionsChinaNameListJson;
            }
            set
            {
                _AdministrativePermissionsChinaNameListJson = value;
            }
        }
    }
}
