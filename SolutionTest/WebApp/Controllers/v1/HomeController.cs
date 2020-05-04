using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApiClient;
using WebApp.InterfaceFiles;
using WebApp.OperModel;
using WebClient.InterfaceFile;

namespace WebApp.Controllers.v1
{
    /// <summary>
    /// Home控制器
    /// </summary>
    //[ApiController]
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    public class HomeController : DefaultController
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        private static List<Teacher> userinfoList = new List<Teacher>()
        {
            new Teacher{
                Id=1,
                Name="aa"
            },
            new Teacher{
                Id=2,
                Name="bb"
            },
            new Teacher{
                Id=3,
                Name="cc"
            }
        };

        private HttpWebApiClientInterface<IWebApi> webApi;
        /// <summary>
        /// 注入
        /// </summary>
        /// <param name="WebApi"></param>
        public HomeController(HttpWebApiClientInterface<IWebApi> WebApi)
        {
            webApi = WebApi;
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ITask<IEnumerable<Teacher>> Get()
        {
            return webApi.Request(w =>
            {
                return w.GetUser().Retry(1).WhenCatch<Exception>();
            });
        }


    }
}

