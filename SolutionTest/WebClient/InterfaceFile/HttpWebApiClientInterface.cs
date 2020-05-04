using System;
using WebApiClient;

namespace WebClient.InterfaceFile
{
    public interface HttpWebApiClientInterface<T> where T : class, IHttpApi
    {
        /// <summary>
        /// 操作实例接口对象
        /// </summary>
        T TOper { get; set; }

        /// <summary>
        ///  调用接口
        /// </summary>
        /// <typeparam name="Result"></typeparam>
        /// <param name="ApiFactoryFac"></param>
        /// <param name="ResultDeal"></param>
        /// <returns></returns>
        Result Request<Result>(Func<T, Result> ApiFactoryFac);

    }
}
