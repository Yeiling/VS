using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// Swagger授权访问过滤
    /// </summary>
    public class SwaggerOperationFilter : IOperationFilter
    {
        /// <summary>
        /// 实现Swagger过滤接口验证
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(Operation operation, OperationFilterContext context)
        {
            operation.Parameters = operation.Parameters ?? new List<IParameter>();
            var info = context.MethodInfo;
            context.ApiDescription.TryGetMethodInfo(out info);
            try
            {
                Attribute attribute = info.GetCustomAttribute(typeof(AuthorizeAttribute));
                if (attribute != null)
                {
                    operation.Parameters.Add(new BodyParameter
                    {
                        Name = "Authorization",
                        In = "header",
                        Description = "access_token",
                        Required = true
                    });
                }
            }
            catch
            { }
        }
    }
}
