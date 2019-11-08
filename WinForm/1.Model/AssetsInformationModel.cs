using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForm.Model
{
    public class AssetsInformation
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        /// <summary>
        /// 资产名称
        /// </summary>
        public string AssetName { get; set; }
        /// <summary>
        /// 资产编码
        /// </summary>
        public string AssetCode { get; set; }
        /// <summary>
        /// 资产型号
        /// </summary>
        public string AssetModel { get; set; }
        /// <summary>
        /// 管理部门       
        /// </summary>
        public string ManagementDepartment { get; set; }
        /// <summary>
        /// 使用部门
        /// </summary>
        public string UseDepartment { get; set; }
        /// <summary>
        /// 使用状态    
        /// </summary>
        public string UseState { get; set; }
        /// <summary>
        /// 使用年限 
        /// </summary>
        public string UseDate { get; set; }
        /// <summary>
        /// 使用地点
        /// </summary>
        public string UsePlace
        {
            get;set;
        }
        /// <summary>
        /// 安装日期
        /// </summary>
        public string InstallationDate { get; set; }
        /// <summary>
        /// 二维码地址
        /// </summary>
        public string QdPath { get; set; }
    }
}
