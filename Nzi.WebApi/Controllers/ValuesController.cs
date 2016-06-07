using Nzi.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Nzi.WebApi.Controllers
{
    public class ValuesController :ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get( int id )
        {
            return "value";
        }

        // POST api/values
        public void Post( [FromBody]string value )
        {
        }

        // PUT api/values/5
        public void Put( int id, [FromBody]string value )
        {
        }

        // DELETE api/values/5
        public void Delete( int id )
        {
        }

        /// <summary>
        /// 获取航站楼信息
        /// </summary>
        /// <param name="request">请求实体</param>
        /// <returns>响应实体</returns>
        [HttpPost]
        [Route("Terminal/_GetTerminals")]
        public RcTerminalResponse RcTerminal( RcTerminalRequest request )
        {
            RcTerminalResponse response = new RcTerminalResponse();

            response.BaseResponse = new BaseResponse() { IsSuccess = true, ErrorMessage =  request.TerminalId.ToString() };
            return response;
        }
    }
}
