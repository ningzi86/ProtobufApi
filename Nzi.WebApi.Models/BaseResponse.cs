

using ProtoBuf;
using System;

namespace Nzi.WebApi.Models
{
    [Serializable]
    [ProtoContract]
    public class BaseResponse
    {
        /// <summary>
        /// 接口是否成功
        /// </summary>
        [ProtoMember(1)]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 接口错误消息
        /// </summary>
        [ProtoMember(2)]
        public string ErrorMessage { get; set; }


        #region 异常信息，不在接口中返回，所以不加ProtoMember特性

        /// <summary>
        /// 异常信息
        /// </summary>
        public Exception Exception { get; set; }
         

        #endregion
    }
}
