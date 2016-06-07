using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nzi.WebApi.Tests
{
    public class RequestApi
    {

        #region (public) 发送Http请求，数据格式为protobuf

        /// <summary>
        /// 发送Http请求，数据格式为protobuf
        /// </summary>
        /// <typeparam name="Request">请求类型</typeparam>
        /// <typeparam name="Response">响应类型</typeparam>
        /// <param name="request">请求实体</param>
        /// <param name="requestUri">请求地址</param>
        /// <returns>响应实体</returns>
        public static Response Send<Request, Response>( Request request, string baseUri, string requestUri )
            where Request : class, new()
            where Response : class, new()
        {

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress  = new Uri(baseUri);

            using( MemoryStream ms = new MemoryStream() )
            {
                ProtoBuf.Serializer.Serialize<Request>(ms, request);

                HttpContent httpContent = new ByteArrayContent(ms.ToArray());
                httpContent.Headers.Add("content-type", "application/x-protobuf");

                HttpResponseMessage httpResponseMessage = httpClient.PostAsync(requestUri, httpContent).Result;
                Response response = ProtoBuf.Serializer.Deserialize<Response>(httpResponseMessage.Content.ReadAsStreamAsync().Result);

                return response;

            }

        }

        #endregion

    }
}
