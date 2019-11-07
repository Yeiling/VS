using Castle.DynamicProxy;
using NLog;
using System;

namespace shuiyintong.Api.AutoFacAop
{
    /// <summary>
    /// AutoFac AOP拦截器 需要实现 IInterceptor接口 Intercept方法
    /// </summary>
    public class LogInterceptor : IInterceptor
    {
        /// <summary>
        /// 日志记录器
        /// </summary>
        private readonly Logger nlog = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 实现Castle.DynamicProxy(动态代理中的接口IInterceptor)
        /// </summary>
        /// <param name="invocation"></param>
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                nlog.Error(ex, ex.Message);
                throw;
            }
        }

        ///// <summary>
        ///// 实现Castle.DynamicProxy(动态代理中的接口IInterceptor)
        ///// </summary>
        ///// <param name="invocation"></param>
        //        public void Intercept(IInvocation invocation)
        //        {
        //            try
        //            {
        //                //在被拦截的方法执行完毕后 继续执行
        //                //调用Proceed函数将会实现方法体以外的函数，就是切面以外的函数
        //                invocation.Proceed();
        //            }
        //            catch (Exception ex)
        //            {
        //                nlog.Error("方法执行前:拦截{0}类下的方法{1}的参数是{2},异常信息{3},返回结果是{4}",
        //invocation.TargetType.FullName,
        //invocation.Method.Name,
        //string.Join(",", invocation.Arguments.Select(a => (a ?? "").ToString()).ToArray()),
        //ex.Message,
        //invocation.ReturnValue.ToJson());
        //            }

        //        }
    }
}
