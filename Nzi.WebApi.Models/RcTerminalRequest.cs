using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nzi.WebApi.Models
{
    /// <summary>
    /// 航站楼列表请求实体
    /// </summary>
    [ProtoContract]
    public class RcTerminalRequest
    {
        /// <summary>
        /// 基础实体
        /// </summary>
        [ProtoMember(1)]
        public BaseRequest BaseRequest { get; set; }

        /// <summary>
        /// 航站楼编号
        /// </summary>
        [ProtoMember(2)]
        public int TerminalId { get; set; } // TerminalId (Primary key)
         

    }
}
