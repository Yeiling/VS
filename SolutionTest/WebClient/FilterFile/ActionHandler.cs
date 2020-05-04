using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebClient.FilterFile
{
    /// <summary>
    /// ActionHandler---添加处理机制
    /// </summary>
    public class ActionHandler : DelegatingHandler
    {
        #region 属性 
        ///// <summary>
        ///// 熔断之前允许异常发生的次数，默认是0
        ///// </summary>
        //public int ExptionAllowedBeforeBreaking { get; set; }

        ///// <summary>
        ///// 熔断后继续请求的时间间隔---单位：毫秒
        ///// </summary>
        //public TimeSpan DurationOfBreak { get; set; }

        ///// <summary>
        ///// 超时时间
        ///// </summary>
        //public TimeSpan TimeOut { get; set; }

        ///// <summary>
        ///// Policy熔断策略
        ///// </summary>s
        //public AsyncCircuitBreakerPolicy BreakerPolicy { get; set; }

        ///// <summary>
        ///// Policy超时策略
        ///// </summary>
        //public AsyncTimeoutPolicy TimeoutPolicy { get; set; }


        //public ActionHandler() : this(1, TimeSpan.FromSeconds(3))
        //{ }

        ///// <summary>
        ///// 
        ///// </summary>
        //public ActionHandler(int exptionAllowedBeforeBreaking, TimeSpan durationOfBreak)
        //{
        //    ExptionAllowedBeforeBreaking = exptionAllowedBeforeBreaking;
        //    DurationOfBreak = durationOfBreak;

        //    //Polly熔断机制配置
        //    BreakerPolicy = Policy.Handle<Exception>()
        //           .CircuitBreakerAsync(ExptionAllowedBeforeBreaking, DurationOfBreak,
        //           onBreak: (exp, circuitstate, timespan, context) =>  //熔断打开后的操作
        //           {

        //           },
        //           onReset: context =>  //熔断关闭后重置操作
        //           {
        //           //日志记录
        //       }, () =>   //
        //       {

        //               });
        //    //.ExecuteAsync(() =>
        //    //{
        //    //    return Task.Run(() =>
        //    //    {
        //    //        //........................
        //    //    });
        //    //});

        //    TimeoutPolicy = Policy.TimeoutAsync(TimeSpan.FromSeconds(8));
        //}

        #endregion


        /// <summary>
        /// 返回对象HttpResponseMessage创建
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Task<HttpResponseMessage> httpResponseMessage = null;
            #region 注释掉
            //return Task.Run(() =>
            //{
            //    return new HttpResponseMessage
            //    {
            //        Content = request.Content,
            //        RequestMessage = request,
            //        //ReasonPhrase = string.Empty,
            //        Version = request.Version
            //    };
            //}); 
            #endregion

            try
            {
               
            }
            catch 
            {
                
            }

            return httpResponseMessage;

        }


    }
}
