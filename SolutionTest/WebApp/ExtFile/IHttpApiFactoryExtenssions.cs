using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;

namespace WebApp.ExtFile
{
    /// <summary>
    /// 扩展IHttpApiFactory
    /// </summary>
    public static class IHttpApiFactoryExtenssions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpApiFactory"></param>
        /// <param name="act"></param>
        public static void UseIHttpApiFactory<T>(this IHttpApiFactory<T> httpApiFactory, Action<HttpApiFactoryOper<T>> act) where T : class, IHttpApi
        {
            act(new HttpApiFactoryOper<T>(httpApiFactory));
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HttpApiFactoryOper<T> where T : class, IHttpApi
    {
        private IHttpApiFactory<T> _httpApiFactory;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpApiFactory"></param>
        public HttpApiFactoryOper(IHttpApiFactory<T> httpApiFactory)
        {
            _httpApiFactory = httpApiFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        public HttpApiFactoryOper<T> Retry(int retryCoount, Func<T, bool> act)
        {
            var oper = _httpApiFactory.CreateHttpApi();
            return act(oper) ? this : null;

        }
    }
}
