
using ProtoBuf;
using System;

namespace Nzi.WebApi.Models
{

    [Serializable]
    [ProtoContract]
    public class BaseRequest
    {
        /// <summary>
        /// 客户端版本号
        /// </summary>
        [ProtoMember(1)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [ProtoMember(2)]
        public EnumHelper.SourceWay SourceWay { get; set; }

        /// <summary>
        /// 请求语言版本
        /// </summary>
        [ProtoMember(3)]
        public EnumHelper.LanguageVersion LanguageVersion { get; set; }

        /// <summary>
        /// 终端操作系统,设备类型,
        /// 如：android.4.4.4,MI3
        /// </summary>
        [ProtoMember(4)]
        public string TerminalExt { get; set; }

        /// <summary>
        /// RegistrationId
        /// </summary>
        [ProtoMember(5)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// IMEI
        /// </summary>
        [ProtoMember(6)]
        public string IMEI { get; set; }

        /// <summary>
        /// 操作人(员工、CRM必填)
        /// </summary>
        [ProtoMember(7)]
        public int OpEmployeeID { get; set; }

        /// <summary>
        /// Token(员工、CRM必填)
        /// </summary>
        [ProtoMember(8)]
        public string Token { get; set; }

        /// <summary>
        /// 数据权限(员工、CRM必填)
        /// </summary>
        [ProtoMember(9)]
        public EnumHelper.DataCommission DataCommission { get; set; }

        /// <summary>
        /// 部门编号(员工、CRM必填)
        /// </summary>
        [ProtoMember(10)]
        public int DeptID { get; set; }

    }


}
