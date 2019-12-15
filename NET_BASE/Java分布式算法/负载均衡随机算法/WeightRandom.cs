using System;
using System.Collections.Generic;
using System.Text;


//分布式算法有很多，常用的有:
//1:哈希一致性算法(环形)
//2:随机轮询算法
//3:加权轮询算法
//4:最小活跃数算法
//5:....
namespace Java分布式算法.负载均衡随机算法
{
    /// <summary>
    /// 加权重随机算法
    /// </summary>
    public class WeightRandom
    {
        //描述：使用Nginx做负载均衡时，Nginx采用随机算法将请求发到服务器，一般采用随机轮询，
        //1：随机轮询

        /// <summary>
        /// 10台服务器---模拟
        /// </summary>
        private static List<string> ServerIps = new List<string>
        {
            "192.168.56.100:8080",
            "192.168.56.101:8080",
            "192.168.56.102:8080",
            "192.168.56.103:8080",
            "192.168.56.104:8080",
            "192.168.56.105:8080",
            "192.168.56.106:8080",
            "192.168.56.107:8080",
            "192.168.56.108:8080",
            "192.168.56.109:8080"
        };

        /// <summary>
        /// 带权重的服务器---Key服务器，value---权重值（越大越优先）
        /// </summary>
        private static Dictionary<string, short> ServersMap = new Dictionary<string, short>
        {
           { "192.168.56.100:8080", 10 },
           { "192.168.56.101:8080", 1  },
           { "192.168.56.102:8080", 3  },
           { "192.168.56.103:8080", 7  },
           { "192.168.56.104:8080", 10 },
           { "192.168.56.105:8080", 4  },
           { "192.168.56.106:8080", 8  },
           { "192.168.56.107:8080", 2  },
           { "192.168.56.108:8080", 6  },
           { "192.168.56.109:8080", 5  }
        };

        /// <summary>
        /// 随机获取Ip服务
        /// </summary>
        /// <returns></returns>
        public static string RandomServer()
        {
            Random r = new Random();
            return ServerIps[r.Next(ServerIps.Count)];
        }


        /// <summary>
        /// 加权随机算法
        /// </summary>
        /// <returns></returns>
        public static string WeightServer1()
        {
            List<string> lst = new List<string>();
            foreach (var key in ServersMap.Keys)
            {
                for (int i = 0; i < ServersMap[key]; i++)
                    lst.Add(key);
            }

            Random r = new Random();
            return lst[r.Next(lst.Count)];
        }


        /// <summary>
        /// 加权随机算法---优于WeightServer1，此算法必须保持顺序
        /// 0__3____7____11_______16
        /// </summary>
        /// <returns></returns>
        public static string WeightServer2()
        {
            int TotalWeight = 0;
            foreach (var key in ServersMap.Keys)
                TotalWeight += ServersMap[key];

            Random r = new Random();
            var rdmNum = r.Next(TotalWeight);

            foreach (var key in ServersMap.Keys)
            {
                if (rdmNum < ServersMap[key])
                    return key;

                rdmNum -= ServersMap[key];
            }
            return null;
        }


        //思路3：使用链表实现(单链表结构：（weight值，服务器集合对象）)
        //定义权重最大值是10，最小值是0
        public static string WeightServer3()
        {
            //实现。。。。

            return null;

        }


    }
}
