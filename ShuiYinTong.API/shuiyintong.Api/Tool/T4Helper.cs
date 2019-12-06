using RazorEngine;
using RazorEngine.Templating;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace shuiyintong.Api.Tool
{
    /// <summary>
    /// T4模板生成
    /// </summary>
    public class T4Helper
    {
        /// <summary>
        /// T4生成Razor引擎模板
        /// </summary>
        /// <param name="templatePath"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static string GeneritorSwaggerHtml(string templatePath, SwaggerDocument model)
        {
            var template = File.ReadAllText(templatePath);
            return Engine.Razor.RunCompile(template, "ShuiYinTong.WebAPI", typeof(SwaggerDocument), model);
            //var result = Engine.Razor.RunCompile(new LoadedTemplateSource(template, templatePath), typeof(SwaggerDocument), null, model);
        }
    }
}
