using System;
using WebApiClient;
using WebClient.EntityModel;
using WebClient.FilterFile;
using WebClient.InterfaceFile;

namespace WebClient.AchieveFile
{
    /// <summary>
    /// HttpWebApiClient实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HttpWebApiClientArchieve<T> : HttpWebApiClientInterface<T> where T : class, IHttpApi
    {
        // public static PolicyWrap PolicyWrap { get; set; }
        public static IHttpApiFactory<T> HAFactory { get; set; }
        public static HttpApiClientConfig ClientConfig { get; set; } = new HttpApiClientConfig
        {
            Url = "https://localhost:44378/",
            Keep = true,
            Interval = new TimeSpan(3),
            LifeTime = new TimeSpan(5),

            retryCount = 2,
            timeoutSeconds = 3
        };

        /// <summary>
        /// 默认无配置参数
        /// </summary>
        public HttpWebApiClientArchieve() : this(null)
        {
        }

        ///// <summary>
        ///// 配置参数
        ///// </summary>
        ///// <param name="ClientConfig"></param>
        public HttpWebApiClientArchieve(HttpApiClientConfig ClientConfig)
        {
            //注册HttpApiFactory
            //注册信息自定义或注册默认值
            //HAFactory = GetHttpApiFactory(ClientConfig);

            //HttpWeiApi接口操作实例
            if (HAFactory != null)
                TOper = HAFactory.CreateHttpApi();
            
        }

        static HttpWebApiClientArchieve()
        {
            //HAFactory = HttpApi.Register<T>();
            HAFactory = InitFactory(HttpApi.Register<T>(), ClientConfig);
        }


        private static IHttpApiFactory<T> InitFactory(HttpApiFactory<T> factory, HttpApiClientConfig ClientConfig)
        {
            if (ClientConfig != null)  //注册配置信息
            {
                //Policy
                //PolicyWrap = Policy.Handle<Exception>()
                //             .Retry(ClientConfig.retryCount)  //重试策略
                //             .Wrap(Policy.Timeout(ClientConfig.timeoutSeconds));  //异常重试策略添加内部超时策略

                //HttpApiFactory
                factory.ConfigureHttpApiConfig(r =>
                {
                    //Http请求服务地址
                    if (!string.IsNullOrWhiteSpace(ClientConfig.Url))
                        r.HttpHost = new Uri(ClientConfig.Url);

                    //设置日志服务
                    //r.ServiceProvider.GetService(typeof(ILogger<T>));
                    //Http日志记录
                    //r.LoggerFactory = null;

                    //获取或设置请求时序列化使用的默认格式 影响JsonFormatter或KeyValueFormatter的序列化
                    r.FormatOptions = new FormatOptions()
                    {
                        //获取或设置是否忽略null值属性的序列化 默认为false
                        IgnoreNullProperty = false,
                        //获取或设置序列化DateTime类型使用的格式 默认为本地日期时间格式
                        DateTimeFormat = "yyyy-MM-dd HH:mm:ss",
                        //获取或设置序列化时是否使用骆驼命名 默认为false
                        UseCamelCase = false
                    };

                    //参数验证和返回值验证,默认为true
                    //r.UseParameterPropertyValidate = true;
                    //r.UseReturnValuePropertyValidate = true;

                    //添加全局过滤器
                    r.GlobalFilters.Add(new ApiGlobalFilter());
                })
               //设置是否维护使用一个CookieContainer实例 该实例为首次创建时的CookieContainer
               //true:维护使用一个CookieContainer实例
               .SetKeepCookieContainer(ClientConfig.Keep ?? false);
                //配置HttpMessageHandler的创建
                //.ConfigureHttpMessageHandler(() =>
                //{
                //    return new ActionHandler();
                //});

                //设置清理过期的HttpApi实例的时间间隔
                if (ClientConfig.Interval != null)
                    factory.SetCleanupInterval(ClientConfig.Interval);

                //设置HttpApi实例的生命周期
                if (ClientConfig.LifeTime != null)
                    factory.SetLifetime(ClientConfig.LifeTime);
            }
            return factory;
        }


        #region 接口实现

        /// <summary>
        /// 接口对象和操作实例
        /// </summary>
        public T TOper { get; set; }


        /// <summary>
        /// Http请求
        /// </summary>
        /// <typeparam name="Result"></typeparam>
        /// <param name="ApiFactoryFac"></param>
        /// <returns></returns>
        public Result Request<Result>(Func<T, Result> ApiFactoryFac)
        {
            return ApiFactoryFac(TOper);
        }

        #endregion

    }
}
