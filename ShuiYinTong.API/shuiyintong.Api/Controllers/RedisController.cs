using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using shuiyintong.DBUtils.IService;

namespace shuiyintong.Api.Controllers
{
    /// <summary>
    /// Redis测试服务
    /// </summary>
    public class RedisController : BaseController
    {
        /// <summary>
        /// Redis服务
        /// </summary>
        public IRediServer rediServer { get; set; }
        /// <summary>
        /// Redis库编号
        /// </summary>
        private readonly short RedisDbNum = 1;

        /// <summary>
        /// 设置值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        [HttpGet]
        public bool Set<T>(string Key, T Value) => rediServer.Set<T>(Key, Value);




    }
}