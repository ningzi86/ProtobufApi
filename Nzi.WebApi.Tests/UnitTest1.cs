using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using Nzi.WebApi.Models;

namespace Nzi.WebApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var response = RequestApi.Send<RcTerminalRequest, RcTerminalResponse>(
                new RcTerminalRequest()
                {
                   TerminalId = 100
                },
                "http://localhost/nzi.webapi/",
                "Terminal/_GetTerminals");


            Console.WriteLine(response.BaseResponse.IsSuccess);
            Console.WriteLine(response.BaseResponse.ErrorMessage);
        }
    }
}
