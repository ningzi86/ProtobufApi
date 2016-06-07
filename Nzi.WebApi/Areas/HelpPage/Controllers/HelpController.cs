using System;
using System.Web.Http;
using System.Web.Mvc;
using Nzi.WebApi.Areas.HelpPage.ModelDescriptions;
using Nzi.WebApi.Areas.HelpPage.Models;
using System.Reflection;

namespace Nzi.WebApi.Areas.HelpPage.Controllers
{
    /// <summary>
    /// The controller that will handle requests for the help page.
    /// </summary>
    public class HelpController : Controller
    {
        private const string ErrorViewName = "Error";

        public HelpController()
            : this(GlobalConfiguration.Configuration)
        {
        }

        public HelpController(HttpConfiguration config)
        {
            Configuration = config;
        }

        public HttpConfiguration Configuration { get; private set; }

        public ActionResult Index()
        {
            ViewBag.DocumentationProvider = Configuration.Services.GetDocumentationProvider();
            return View(Configuration.Services.GetApiExplorer().ApiDescriptions);
        }

        public ActionResult Api(string apiId)
        {
            if (!String.IsNullOrEmpty(apiId))
            {
                HelpPageApiModel apiModel = Configuration.GetHelpPageApiModel(apiId);
                if (apiModel != null)
                {
                    return View(apiModel);
                }
            }

            return View(ErrorViewName);
        }

        public ActionResult ResourceModel(string modelName)
        {
            if (!String.IsNullOrEmpty(modelName))
            {
                ModelDescriptionGenerator modelDescriptionGenerator = Configuration.GetModelDescriptionGenerator();
                ModelDescription modelDescription;
                if (modelDescriptionGenerator.GeneratedModels.TryGetValue(modelName, out modelDescription))
                {
                    return View(modelDescription);
                }
            }

            return View(ErrorViewName);
        }

        public void DownLoadProto( string fullName, string assemblyName )
        {
            Assembly assembly = Assembly.Load(assemblyName.Substring(0, assemblyName.LastIndexOf(".")));

            Type T = assembly.GetType(fullName);

            //创建返回参数实例
            object objParam = Activator.CreateInstance(T, null);
            string strProto = string.Empty;


            var meGetProto = typeof(ProtoBuf.Serializer).GetMethod("GetProto").MakeGenericMethod(objParam.GetType());
            strProto            = meGetProto.Invoke(objParam, null).ToString();

            System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}.proto", T.Name));
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            System.Web.HttpContext.Current.Response.ContentType = "application/text";

            byte[] byteProto = System.Text.Encoding.UTF8.GetBytes(strProto);

            System.Web.HttpContext.Current.Response.BinaryWrite(byteProto);
            System.Web.HttpContext.Current.Response.End();


        }

    }
}