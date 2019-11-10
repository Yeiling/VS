using Autofac.Aspect;
using System.Threading.Tasks;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// Aspect AOP定义一个环绕拦截器
    /// </summary>
    public class LogArroundInterceptor : AspectAroundAttribute
    {
        /// <summary>
        /// 前置拦截器拦截器
        /// </summary>
        /// <param name="aspectContext"></param>
        /// <returns></returns>
        public override Task Before(AspectContext aspectContext)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// 后置拦截器拦截器
        /// </summary>
        /// <param name="aspectContext"></param>
        /// <returns></returns>
        public override Task After(AspectContext aspectContext)
        {
            return Task.CompletedTask;
        }

    }
}
