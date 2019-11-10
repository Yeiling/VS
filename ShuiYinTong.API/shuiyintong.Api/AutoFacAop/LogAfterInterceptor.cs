using Autofac.Aspect;
using System.Threading.Tasks;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// Aspect AOP定义一个前置拦截器
    /// </summary>
    public class LogAfterInterceptor : AspectAfterAttribute
    {
        /// <summary>
        /// 后置拦截器拦截器
        /// </summary>
        /// <param name="aspectContext"></param>
        /// <returns></returns>
        public override Task After(AspectContext aspectContext)
        {
            //string str = "TestHelloAfter";
            return Task.CompletedTask;
        }
    }
}
