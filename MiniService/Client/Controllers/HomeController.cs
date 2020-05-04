using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Client.Models;
using Client.HttpTool;
using Consul;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            //var lst = HttpClientHelper.GetRequest("http://127.0.0.1:5726/Person");
            //ViewBag.Students = lst;
            #region 获取Consul全部服务实例
            //using (ConsulClient client = new ConsulClient(c =>
            //   {
            //    //Consul地址 
            //    c.Address = new Uri("http://localhost:8500/");
            //       c.Datacenter = "dc1";
            //   }))
            //{
            //    //分布式算法---带权平滑轮训算法
            //    var dir = client.Agent.Services().Result.Response;
            //    foreach (var item in dir)
            //    {

            //    }
            //} 
            #endregion


            #region 客户端调用服务
            //客户端请求地址
            string urlReq = "http://GoodOrderService/Person";
            Uri url = new Uri(urlReq);

            //Consul地址解析
            using (ConsulClient client = new ConsulClient(c =>
               {
                   //Consul地址 
                   c.Address = new Uri("http://localhost:8500/");
                   c.Datacenter = "dc1";
               }))
            {
                //分布式算法---带权平滑轮训算法
                var dir = client.Agent.Services().Result.Response;
                var serviceList = dir.Where(c => c.Value.Service.ToLower() == url.Host.ToLower());

                //随机取服务器
                var server = serviceList.ToList()[new Random().Next(0, serviceList.Count())];
                // var server = serviceList.FirstOrDefault();
                var targetUrl = $"{url.Scheme}://{server.Value.Address}:{server.Value.Port}{url.PathAndQuery}";
                var lst = HttpClientHelper.GetRequest(targetUrl);
                lst += "\r\n" + targetUrl;
                ViewBag.Students = lst;
            }

            #endregion

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
