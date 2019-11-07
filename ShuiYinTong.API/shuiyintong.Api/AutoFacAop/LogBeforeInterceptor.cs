using Autofac.Aspect;
using System.Threading.Tasks;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// Aspect AOP定义一个前置拦截器---事务
    /// </summary>
    public class LogBeforeInterceptor : AspectBeforeAttribute
    {
        /// <summary>
        /// 前置拦截器
        /// </summary>
        /// <param name="aspectContext"></param>
        /// <returns></returns>
        public override Task Before(AspectContext aspectContext)
        {
            //string str = "TestHelloBefore";
            return Task.CompletedTask;
        }
    }
}
