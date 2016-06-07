using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzi.WebApi.Models
{

    /// <summary>
    /// 航站楼列表响应实体
    /// </summary>
    [ProtoContract]
    public class RcTerminalResponse
    {
        public RcTerminalResponse()
        { 
            this.BaseResponse = new BaseResponse();
        }

        /// <summary>
        /// 基础响应实体
        /// </summary>
        [ProtoMember(1)]
        public BaseResponse BaseResponse { get; set; }


        /// <summary>
        /// 航站楼列表
        /// </summary>
        [ProtoMember(2)]
        public List<RcTerminalModel> RcTerminals { get; set; }
    }


    /// <summary>
    /// 航站楼实体
    /// </summary>
    [ProtoContract]
    public class RcTerminalModel
    {
        /// <summary>
        /// 航站楼编号
        /// </summary>
        [ProtoMember(1)]
        public int TerminalId { get; set; } // TerminalId (Primary key)

        /// <summary>
        /// 编码
        /// </summary>
        [ProtoMember(2)]
        public string TerminalCode { get; set; } // TerminalCode

        /// <summary>
        /// 名称
        /// </summary>
        [ProtoMember(3)]
        public string TerminalName { get; set; } // TerminalName

        /// <summary>
        /// 经度
        /// </summary>
        [ProtoMember(4)]
        public string Lat { get; set; } // Lat

        /// <summary>
        /// 纬度
        /// </summary>
        [ProtoMember(5)]
        public string Lng { get; set; } // Lng

        /// <summary>
        /// 航空公司二字代码
        /// </summary>
        [ProtoMember(6)]
        public string AirportCode { get; set; } // AirportCode
    }
}
