using System;
using WebApiClient.Contexts;
using WebClient.InterfaceFile;
using static WebClient.AchieveFile.ErrorCode;

namespace WebClient.AchieveFile
{
    /// <summary>
    /// 统一Api返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResult<T> : IApiResult<T>
    {
        /// <summary>
        /// 返回值
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ApiActionContext ApiActionContext { get; set; }
    }



}
