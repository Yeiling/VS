using Castle.DynamicProxy;
using log4net;
using shuiyintong.Common.Extend;
using System.Linq;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// 拦截器 需要实现 IInterceptor接口 Intercept方法
    /// </summary>
    public class LogInterceptor : IInterceptor
    {
        /// <summary>
        /// 日志记录器
        /// </summary>
        private readonly ILog _log = LogManager.GetLogger(typeof(LogInterceptor));

        /// <summary>
        /// 实现Castle.DynamicProxy(动态代理中的接口IInterceptor)
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            string str = string.Format("方法执行前:拦截{0}类下的方法{1}的参数是{2}",
               invocation.TargetType.FullName,
               invocation.Method.Name, string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()));

            //在被拦截的方法执行完毕后 继续执行
            //调用Proceed函数将会实现方法体以外的函数，就是切面以外的函数
            invocation.Proceed();

            str = string.Format("方法执行完毕，返回结果：{0}", invocation.ReturnValue.ToJson());



        }
    }
}
