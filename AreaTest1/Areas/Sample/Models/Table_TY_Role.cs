using System;

namespace Web.Entity.Db
{
    /// <summary>
    /// ��ɫ���û���ɫȨ�ޱ�
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
        /// ��ɫ����
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
        /// ����Ȩ��ID����Json�ַ��������ֵΪ��All ��Ȩ��Ϊ����Ȩ�޶��У�
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
        /// ����Ȩ������������Json�ַ��������ֵΪ��ȫ�� ��Ȩ��Ϊ����Ȩ�޶��У�
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
