using System;
using System.Collections.Generic;
using System.Text;

namespace Java分布式算法.负载均衡随机算法
{
    /// <summary>
    /// 轮询算法
    /// </summary>
    public class RoundRoBin
    {
        /// <summary>
        /// 带权重的服务器---Key服务器，value---权重值（越大越优先）
        /// </summary>
        private static Dictionary<string, short> ServersMap = new Dictionary<string, short>
        {
           { "192.168.56.100:8080", 3 },
           { "192.168.56.101:8080", 4 },
           { "192.168.56.102:8080", 5 },
           { "192.168.56.103:8080", 6 },
           { "192.168.56.104:8080", 7 }
        };

        #region 常规轮询算法
        /// <summary>
        /// 常用轮询---此算法有弊端，会弧线同一时间发给同一台服务器
        /// AAAAABBCAAA
        /// </summary>
        /// <returns></returns>
        public static string RoundServer1(int num)
        {
            //思路：先定义一个int Num=0;每次获取服务自增1，然后对服务器权重总数取余数即可
            int TotalWeight = 0;
            foreach (var key in ServersMap.Keys)
                TotalWeight += ServersMap[key];

            //Random r = new Random();
            //var rdmNum = r.Next(TotalWeight);
            var ys = num % TotalWeight;

            foreach (var key in ServersMap.Keys)
            {
                if (ys < ServersMap[key])
                    return key;

                ys -= ServersMap[key];
            }
            return null;
        }
        #endregion


        #region 加权平滑轮询算法
        /// <summary>
        /// 加权平滑轮询算法---使用数组或者集合---尚未实现
        /// </summary>
        /// <param name="num">魂环次数</param>
        /// <returns></returns>
        public static List<string> RoundServer2(int num)
        {
            bool isFisrtRequest = true;

            //每个服务器权重---动态权重
            List<int> WeightList = new List<int>(ServersMap.Keys.Count);
            //每个服务器的初始权重
            List<int> InitList = new List<int>(ServersMap.Keys.Count);
            //静态权重
            int TotalWeight = 0;
            foreach (var key in ServersMap.Keys)
            {
                TotalWeight += ServersMap[key]; //静态权重---权重和，一个固定值

                WeightList.Add(ServersMap[key]); //动态权重
                InitList.Add(ServersMap[key]); //初始权重
            }

            //请求结果服务器
            List<string> reqServer = new List<string>(num);
            while (num >= 0)
            {
                int max = WeightList[0];
                for (int i = 0; i < WeightList.Count; i++)
                {
                    //1:获取最大值
                    if (max < WeightList[i])
                        max = WeightList[i];

                    if (isFisrtRequest)
                    {
                        //第一个减去TotalWeight
                        WeightList[0] -= TotalWeight;
                        isFisrtRequest = false;
                    }
                    else
                        //2:每个字加上初始权重
                        WeightList[i] += InitList[i];
                }

                //:3获取轮询服务器ip地址
                foreach (var key in ServersMap.Keys)
                {
                    if (max < ServersMap[key])
                    {
                        reqServer.Add(key);
                        break;
                    }

                    max -= ServersMap[key];
                }

                num--;
            }
            return reqServer;
        }
        #endregion

        /// <summary>
        /// 获取集合最大值
        /// </summary>
        /// <param name="arry"></param>
        /// <returns></returns>
        public static short GetMax(List<short> arry)
        {
            short max = arry[0];
            for (int i = 1; i < arry.Count; i++)
            {
                if (max < arry[i])
                    max = arry[i];
            }
            return max;
        }


    }

    ///// <summary>
    ///// 加权平滑算法类
    ///// </summary>
    //public class RoundRoBinWeight
    //{
    //    /// <summary>
    //    /// 服务器IP
    //    /// </summary>
    //    public string ServerIp { get; set; }
    //    /// <summary>
    //    /// 静态权重
    //    /// </summary>
    //    public int TotalWeight { get; set; }
    //    /// <summary>
    //    /// 动态权重
    //    /// </summary>
    //    public int CurrentWeight { get; set; }

    //    /// <summary>
    //    /// 构造函数
    //    /// </summary>
    //    /// <param name="ip"></param>
    //    /// <param name="totalWeight"></param>
    //    /// <param name="currentWeight"></param>
    //    public RoundRoBinWeight(string ip, int totalWeight, int currentWeight)
    //    {
    //        ServerIp = ip;
    //        TotalWeight = totalWeight;
    //        CurrentWeight = currentWeight;
    //    }

    //    public 

    //}
}
