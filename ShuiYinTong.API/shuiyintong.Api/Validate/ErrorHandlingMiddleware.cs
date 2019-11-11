using Microsoft.AspNetCore.Http;
using NLog;
using shuiyintong.Common.Extend;
using shuiyintong.Entity.HttpRequestResultEntity;
using System;
using System.Threading.Tasks;
using static shuiyintong.Entity.Enums.RespCodeEnum;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// 全局异常过滤器中间件
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        private readonly Logger nlog = LogManager.GetCurrentClassLogger();
        private readonly RequestDelegate Next;
        /// <summary>
        /// 默认构造方法
        /// </summary>
        public ErrorHandlingMiddleware() { }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.Next = next;
        }

        /* other dependencies */
        /// <summary>
        /// 调用委托
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// NLog日志记录
        /// </summary>
        /// <param name="context"></param>
        /// <param name="exception"></param>
        /// <returns></returns>
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            LogEventInfo lei = new LogEventInfo();
            lei.Properties["method"] = context.Request.Method;
            lei.Properties["httptype"] = context.Request.IsHttps ? "Https" : "Http";
            lei.Properties["message"] = exception.Message;
            lei.Properties["url"] = context.Request.Path.ToString();
            nlog.Error(lei);

            BaseResponse<string> ErrValidation = new BaseResponse<string>
            {
                Code = 500,  //context.Response.StatusCode,
                ResponseType = (byte)ResponseType.Fail,
                Data = exception.Message,
                DateTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            return context.Response.WriteAsync(ErrValidation.ToJson());
        }
    }
}
