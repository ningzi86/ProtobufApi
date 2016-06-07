using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzi.WebApi.Models
{
    public class EnumHelper
    {
        #region 请求来源 SourceWay

        /// <summary>
        /// 请求来源
        /// </summary>
        [Serializable]
        [ProtoContract]
        public enum SourceWay
        {
            /// <summary>
            /// 未设置
            /// </summary>
            [ProtoEnum(Name = @"SourceWayNoSetting", Value = 0)]
            [Description("未设置")]
            SourceWayNoSetting = 0,

            /// <summary>
            /// Web
            /// </summary>
            [ProtoEnum(Name = @"Web", Value = 10)]
            Web = 10,

            /// <summary>
            /// Wap
            /// </summary>
            [ProtoEnum(Name = @"Wap", Value = 20)]
            Wap = 20,

            /// <summary>
            /// IOS
            /// </summary>
            [ProtoEnum(Name = @"IOS", Value = 30)]
            IOS = 30,

            /// <summary>
            /// Android
            /// </summary>
            [ProtoEnum(Name = @"Android", Value = 40)]
            Android = 40
        }

        #endregion


        #region 请求语言版本 LanguageVersion

        /// <summary>
        /// 请求语言版本
        /// </summary>
        [Serializable]
        [ProtoContract]
        public enum LanguageVersion
        {
            /// <summary>
            /// 中文
            /// </summary>
            [ProtoEnum(Name = @"CN", Value = 0)]
            CN = 0,

            /// <summary>
            /// 英文
            /// </summary>
            [ProtoEnum(Name = @"EN", Value = 1)]
            EN = 1
        }

        #endregion


        #region 员工权限 DataCommission

        /// <summary>
        /// 员工权限
        /// </summary>
        [Serializable]
        [ProtoContract]
        public enum DataCommission
        {
            [Description("未设置")]
            [ProtoEnum(Name=@"DataCommissionNoSetting", Value =0)]
            DataCommissionNoSetting=0,

            [Description("个人")]
            [ProtoEnum(Name=@"Personal", Value = 1)]
            Personal = 1,

            [Description("部门")]
            [ProtoEnum(Name=@"Department", Value = 2)]
            Department = 2,

            [Description("部门及子部门")]
            [ProtoEnum(Name=@"DepartmentAndSub", Value = 3)]
            DepartmentAndSub = 3,

            [Description("全部")]
            [ProtoEnum(Name=@"All", Value = 4)]
            All = 4
        }

        #endregion

    }
}
