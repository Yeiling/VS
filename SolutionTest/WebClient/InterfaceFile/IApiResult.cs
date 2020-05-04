using System;
using WebApiClient.Contexts;
using static WebClient.AchieveFile.ErrorCode;

namespace WebClient.InterfaceFile
{
    /// <summary>
    /// 请求统一返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IApiResult<T>
    {
        /// <summary>
        /// 返回值
        /// </summary>
        T Data { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        DateTime DateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ApiActionContext ApiActionContext { get; set; }
    }
}
