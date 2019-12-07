using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.Api.Tool;
using shuiyintong.Common.Extend;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// Swagger文档生成
    /// </summary>
    public class SwaggerController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        public IHostingEnvironment _hostingEnvironment { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SpireDocHelper _spireDocHelper { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SwaggerGenerator _swaggerGenerator { get; set; }
        ///// <summary>
        ///// 构造函数注入
        ///// </summary>
        ///// <param name="hostingEnvironment"></param>
        ///// <param name="spireDocHelper"></param>
        ///// <param name="swaggerGenerator"></param>
        //public SwaggerController(IHostingEnvironment hostingEnvironment, SpireDocHelper spireDocHelper, SwaggerGenerator swaggerGenerator)
        //{
        //    _hostingEnvironment = hostingEnvironment;
        //    _spireDocHelper = spireDocHelper;
        //    _swaggerGenerator = swaggerGenerator;//从ioc容器中获取swagger生成文档的对象
        //}

        /// <summary>
        /// Swagger 文档导出
        /// </summary>
        /// <param name="type"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        [HttpGet]
        public FileResult ExportApiWord(string type, string version)
        {
            string memi = string.Empty, fileExten = string.Empty;
            Stream outdata = null;

            //1.获取api文档json，version是版本，根据指定版本获取指定版本的json对象。
            var model = _swaggerGenerator.GetSwagger(version);
            if (model == null)
                throw new Exception("Swagger Json cannot be equal to null！");

            //2.这里使用了微软的mvc模板引擎技术来生成html，做过mvc项目的同学应该都知道是啥东西，这里不细说了。自己看代码吧，用起来很方便。
            var html = T4Helper.GeneritorSwaggerHtml($"{_hostingEnvironment.WebRootPath}\\SwaggerDoc.cshtml", model);
            //3.将html转换成需要导出的文件类型。
            var op = _spireDocHelper.SwaggerHtmlConvers(html, type, out memi);
            if (!op.Successed)
                throw new Exception(op.Message);

            outdata = op.Data;
            return File(outdata, memi, $"WebAPI文档 {version}{type}");//返回文件流，type是文件格式
        }
    }
}