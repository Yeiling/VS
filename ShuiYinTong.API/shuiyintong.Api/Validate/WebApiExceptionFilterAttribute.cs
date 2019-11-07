using Microsoft.AspNetCore.Mvc.Filters;
using NLog;

namespace shuiyintong.Api.Validate
{
    /// <summary>
    /// WebAPI异常处理---重写
    /// </summary>
    public class WebApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// 获得日志实例
        /// </summary>
        private readonly Logger nlog = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 重写基类的异常处理方法
        /// </summary>
        /// <param name="exceptionContext"></param>
        public override void OnException(ExceptionContext exceptionContext)
        {
            //1.异常日志记录（正式项目里面一般是用log4net记录异常日志）
            //var err = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "——" +
            //    exceptionContext.Exception.GetType().ToString() + "：" + exceptionContext.Exception.Message + "——堆栈信息：" +
            //    exceptionContext.Exception.StackTrace;

            #region 异常处理。。。。
            ////2.返回调用方具体的异常信息
            //if (exceptionContext.Exception is NotImplementedException)
            //    exceptionContext.Exception = new HttpResponseMessage(HttpStatusCode.NotImplemented).Content as Exception;
            //else if (exceptionContext.Exception is TimeoutException)
            //    exceptionContext.Response = new HttpResponseMessage(HttpStatusCode.RequestTimeout);
            ////.....这里可以根据项目需要返回到客户端特定的状态码。如果找不到相应的异常，统一返回服务端错误500
            //else
            //    exceptionContext.Response = new HttpResponseMessage(HttpStatusCode.InternalServerError);

            #endregion

            //NLog保存日志
            nlog.Error(exceptionContext.Exception, exceptionContext.Exception.Message);

            base.OnException(exceptionContext);
        }
    }
}
