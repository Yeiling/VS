using Microsoft.Extensions.Logging;
using System;

namespace WebClient.EntityModel
{
    /// <summary>
    /// HttpWebApiClient配置参数
    /// </summary>
    public class HttpApiClientConfig
    {
        /// <summary>
        /// 服务地址
        /// </summary>
        public string Url { get; set; }

        ///// <summary>
        ///// 日志级别
        ///// </summary>
        //public LogLevel LogLevel { get; set; }

        /// <summary>
        /// 设置是否维护使用一个CookieContainer实例 该实例为首次创建时的CookieContainer
        /// </summary>
        public bool? Keep { get; set; }

        /// <summary>
        /// 设置清理过期的HttpApi实例的时间间隔
        /// </summary>
        public TimeSpan Interval { get; set; }

        /// <summary>
        /// 设置HttpApi实例的生命周期
        /// </summary>
        public TimeSpan LifeTime { get; set; }


        /// <summary>
        /// 重试次数
        /// </summary>
        public byte retryCount { get; set; } = 1;
        /// <summary>
        /// 超时秒数
        /// </summary>
        public byte timeoutSeconds { get; set; } = 5;

    }
}
