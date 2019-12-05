using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
using System.Reflection;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// Swagger选项过滤器代码（文件上传选择文件路径）
    /// </summary>
    public class SwaggerFileUploadFilter : IOperationFilter
    {
        /// <summary>
        /// FormFile名称
        /// </summary>
        private static readonly string[] FormFilePropertyNames = typeof(IFormFile).GetTypeInfo().DeclaredProperties.Select(x => x.Name).ToArray();

        /// <summary>
        /// 实现接口方法
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(Operation operation, OperationFilterContext context)
        {
            //1：Http请求头输入框
            //先判断是否是匿名访问,
            var descriptor = context.ApiDescription.ActionDescriptor as ControllerActionDescriptor;
            if (descriptor != null)
            {
                var actionAttributes = descriptor.MethodInfo.GetCustomAttributes(inherit: true);
                bool isAnonymous = actionAttributes.Any(a => a is AllowAnonymousAttribute);
                //非匿名的方法,链接中添加accesstoken值
                if (!isAnonymous)
                {
                    operation.Parameters.Add(new NonBodyParameter()
                    {
                        Name = "Key",
                        In = "秘钥Token",//query header body path formData
                        Type = "string",
                        Required = true, //是否必选
                        Description = "Http请求头Key,必填项",
                    });
                }
            }

            //2:SwaggerUI添加上传问价组件
            if (!context.ApiDescription.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase) &&
                           !context.ApiDescription.HttpMethod.Equals("PUT", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }
            var fileParameters = context.ApiDescription.ActionDescriptor.Parameters.Where(n => n.ParameterType == typeof(IFormFile)).ToList();
            if (fileParameters.Count < 0)
                return;

            var formFileParameters = operation.Parameters.OfType<NonBodyParameter>().Where(x => FormFilePropertyNames.Contains(x.Name)).ToArray();
            foreach (var formFileParameter in formFileParameters)
            {
                operation.Parameters.Remove(formFileParameter);
            }

            foreach (var fileParameter in fileParameters)
            {
                operation.Parameters.Add(new NonBodyParameter
                {
                    Name = fileParameter.Name,
                    In = "formData",
                    Description = "文件上传",
                    Required = true,
                    Type = "file"
                });
                operation.Consumes.Add("multipart/form-data");
            }
        }
    }

}
