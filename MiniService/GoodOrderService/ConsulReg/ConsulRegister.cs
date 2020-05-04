using Consul;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodOrderService.ConsulReg
{
    public static class ConsulRegister
    {
        /// <summary>
        /// 服务注册到Consul
        /// </summary>
        /// <param name="configuration"></param>
        public static void Register(this IConfiguration configuration)
        {
            //声明一个Consul客户端
            ConsulClient client = new ConsulClient(c =>
            {
                //Consul地址
                c.Address = new Uri("http://localhost:8500/");
                c.Datacenter = "dc1";

            });
            //ip地址
            string ip = configuration["ip"];
            //端口号
            int port = int.Parse(configuration["port"]);
            //从数据库读取配置
            client.Agent.ServiceRegister(new AgentServiceRegistration
            {
                ID = ip + ":" + port,
                Name = "GoodOrderService",  //服务名---分组组名
                Address = ip,//"127.0.0.1",
                Port = port,//5726,
                Tags = null,
                //健康检查
                Check = new AgentServiceCheck
                {
                    Interval = TimeSpan.FromSeconds(15),  //间隔20秒检查一次
                    HTTP = $"http://{ip}:{port}/api/HealthCheck",  //检查地址
                    Timeout = TimeSpan.FromSeconds(5),
                    DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(5)
                }
            }); ;


        }
    }
}
