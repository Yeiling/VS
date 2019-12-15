using Java分布式算法.负载均衡随机算法;
using System;
using System.Collections.Generic;

namespace Java分布式算法
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机获取服务器
            //var server = WeightRandom.RandomServer();

            //加权随机算法
            var ser = WeightRandom.WeightServer();


            Console.ReadKey();
        }
    }
}
