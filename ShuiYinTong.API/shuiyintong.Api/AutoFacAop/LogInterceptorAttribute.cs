using AspectCore.DynamicProxy;
using System;
using System.Threading.Tasks;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// AspectCore AOP
    /// </summary>
    public class LogInterceptorAttribute : AbstractInterceptorAttribute
    {
        /// <summary>
        /// 重写AbstractInterceptorAttribute的Invoke方法
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async override Task Invoke(AspectContext context, AspectDelegate next)
        {
            try
            {
                Console.WriteLine("Before service call");
                await next(context);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Service threw an exception!");
                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("After service call");
            }
        }
    }
}
