using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace WebClient.MiddleWare
{
    /// <summary>
    /// 自定义中间件
    /// </summary>
    public class PollyMiddleWare
    {
        private readonly RequestDelegate _next;
        public PollyMiddleWare(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await context.Response.WriteAsync(ex.Message);
            }
        }


    }
}
